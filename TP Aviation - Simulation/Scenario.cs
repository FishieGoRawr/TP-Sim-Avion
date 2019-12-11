using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public class Scenario
    {
        static Scenario m_scenario;
        public List<Aeroport> listAreoport;
        public List<Client> m_listClients = new List<Client>();
        UsineClient usine;
        Random rand;
        bool m_simulateurEnMarche;
        Thread mainThread { get; set; }
        Horloge m_horloge { get; set; }
        public int m_derniereHeure { get; set; }
        public ControllerSimulateur m_controller { get; set; }

        Scenario()
        {
            listAreoport = new List<Aeroport>();
            usine = UsineClient.getUsineClient;
            rand = new Random(DateTime.Now.Millisecond);
            m_simulateurEnMarche = false;
            mainThread = new Thread(new ThreadStart(spin));
            m_horloge = new Horloge();
            m_derniereHeure = 0;

            //TEMPO
            listAreoport.Add(new Aeroport());
        }
              
        public static Scenario getScenario
        {
            get
            {
                if (m_scenario == null)
                {
                    m_scenario = new Scenario();

                }
                return m_scenario;
            }
        }

        public void changerStatusSpin()
        {

            if (mainThread.IsAlive)
            {
                if (m_simulateurEnMarche)
                {
                    mainThread.Suspend();
                    m_simulateurEnMarche = false;
                }
                else
                {
                    mainThread.Resume();
                    m_simulateurEnMarche = true;
                }
            }
            else
            {
                mainThread.Start();
                m_simulateurEnMarche = true;
            }
        }

        public void spin()
        {
            while (m_simulateurEnMarche)
            {
                Thread.Sleep(50);
                genererClients();
                m_horloge.ajouteMinutes();
            }
        }

        public void abonnerOnHeureChanged(HorlogeEventHandler handler)
        {
            m_horloge.TempsChanged += handler;
        }
        
        public List<Aeroport> Liste
        {
            get { return listAreoport; }
            set { listAreoport = value; }
        }

        public void genererClients()
        {
            int heure = m_horloge.m_heures;
            int[] tailleMap = m_controller.obtenirTailleMap();

            if (m_derniereHeure != heure)
            {
                if (heure % 2 == 0)
                {
                    ajouterFeu(tailleMap[0], tailleMap[1]);
                    ajouterObservateur(tailleMap[0], tailleMap[1]);
                    ajouterSecours(tailleMap[0], tailleMap[1]);
                }
                else
                {
                    //ajouterPassager();
                    //ajouterMarchandise();
                }
                m_derniereHeure = heure;
            }

        }

        public void setController(ControllerSimulateur controller)
        {
            m_controller = controller;
        }

        public void ajouterPassager()
        {
            foreach (var areoport in listAreoport)
            {
                areoport.m_listClient.Add(usine.creerPassager(listAreoport, areoport, rand));
            }
        }

        public void ajouterMarchandise()
        {
            foreach (var areoport in listAreoport)
            {
                areoport.m_listClient.Add(usine.creerMarchandise(listAreoport, areoport, rand));
            }
        }

        public void ajouterObservateur(int width, int height)
        {
            int index;
            Client tempo = usine.creerObservateur(width, height, rand);
            index = trouverPlusProche(listAreoport, tempo);

            if(index != -1)
            {
                listAreoport[index].m_listClient.Add(tempo);
                Console.WriteLine(tempo);
                m_listClients.Add(tempo);
            }
            else
            {
                m_listClients.Add(tempo);
            }
                
        }

        public void ajouterFeu(int width, int height)
        {
            Random nbFeu = new Random();

                int index;
                Client tempo = usine.creerFeu(width, height, rand);
                index = trouverPlusProche(listAreoport, tempo);

                if (index != -1)
                {
                    listAreoport[index].m_listClient.Add(tempo);
                    Console.WriteLine(tempo);
                    m_listClients.Add(tempo);
                }
                else
                {
                    m_listClients.Add(tempo);
                }
        }

        public void ajouterSecours(int width, int height)
        {
            Random nbSecours = new Random();
                int index;
                Client tempo = usine.creerSecours(width, height, rand);
                index = trouverPlusProche(listAreoport, tempo);

                if (index != -1)
                {
                    listAreoport[index].m_listClient.Add(tempo);
                    Console.WriteLine(tempo);
                    m_listClients.Add(tempo);
                }
                else
                {
                    m_listClients.Add(tempo);
                }
        }

        public int trouverPlusProche(List<Aeroport> listAreoport, Client client)
        {
            int posX;
            int posY;
            int clientPosX;
            int clientPosY;
            double distance;
            double plusPetit = 0;
            int indexAreoport = -1;

            switch (client.Nom)
            {
                case "Feu":
                    for (int i = 0; i < listAreoport.Count; i++)
                    {
                        if (possedeAreoIncendie(listAreoport[i]) == 1)
                        {
                            posX = listAreoport[i].m_localisation.PosX;
                            posY = listAreoport[i].m_localisation.PosY;

                            clientPosX = client.PosX;
                            clientPosY = client.PosY;

                            distance = pythagore(clientPosX - posX, clientPosY - posY);

                            if (plusPetit == 0 || distance < plusPetit)
                            {
                                plusPetit = distance;
                                indexAreoport = i;
                            }
                        }
                        else if (possedeAreoIncendie(listAreoport[i]) == 2)
                        {
                            indexAreoport = -1;
                        }

                    }
                    break;
                case "Observateur":
                    for (int i = 0; i < listAreoport.Count; i++)
                    {
                        if (possedeAreoObservateur(listAreoport[i]) == 1)
                        {
                            posX = listAreoport[i].m_localisation.PosX;
                            posY = listAreoport[i].m_localisation.PosY;

                            clientPosX = client.PosX;
                            clientPosY = client.PosY;

                            distance = pythagore(clientPosX - posX, clientPosY - posY);


                            if (plusPetit == 0 || distance < plusPetit)
                            {
                                plusPetit = distance;
                                indexAreoport = i;
                            }
                        }
                        else if (possedeAreoObservateur(listAreoport[i]) == 2)
                        {
                            indexAreoport = -1;
                        }
                    }
                    break;
                case "Secours":
                    for (int i = 0; i < listAreoport.Count; i++)
                    {
                        if (possedeAreoSecours(listAreoport[i]) == 1)
                        {
                            posX = listAreoport[i].m_localisation.PosX;
                            posY = listAreoport[i].m_localisation.PosY;

                            clientPosX = client.PosX;
                            clientPosY = client.PosY;

                            distance = pythagore(clientPosX - posX, clientPosY - posY);


                            if (plusPetit == 0 || distance < plusPetit)
                            {
                                plusPetit = distance;
                                indexAreoport = i;
                            }
                        }
                        else if (possedeAreoSecours(listAreoport[i]) == 2)
                        {
                            indexAreoport = -1;
                        }
                    }
                    break;
                default:
                    break;
            }
            
            return indexAreoport;
        }

        public int possedeAreoIncendie(Aeroport areoport)
        {
            int temp = -1;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Incendies")
                    if (areoport.m_listAeronef[i].Dispo)
                    {
                        areoport.m_listAeronef[i].Dispo = false;
                        temp = 1;
                    }
                    else
                    {
                        temp = 2;
                    }
            }
            return temp;
        }

        public int possedeAreoObservateur(Aeroport areoport)
        {
            int temp = -1;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Observateurs")
                    if (areoport.m_listAeronef[i].Dispo)
                    {
                        areoport.m_listAeronef[i].Dispo = false;
                        temp = 1;
                    }
                    else
                    {
                        temp = 2;
                    }
            }
            return temp;
        }

        public int possedeAreoSecours(Aeroport areoport)
        {
            int temp = -1;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Secours")
                    if (areoport.m_listAeronef[i].Dispo)
                    {
                        areoport.m_listAeronef[i].Dispo = false;
                        temp = 1;
                    }
                    else
                    {
                        temp = 2;
                    }
            }
            return temp;
        }

        public double pythagore(int a, int b)
        {
            double c = 0;

            a = a * a;
            b = b * b;
            c = Math.Sqrt(a + b);

            return c;
        }
    }
}
