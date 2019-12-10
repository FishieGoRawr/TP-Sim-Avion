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
        public List<Areoport> listAreoport;
        UsineClient usine;
        Random rand;
        bool m_simulateurEnMarche;
        Thread mainThread { get; set; }
        Horloge m_horloge { get; set; }
        ControllerSimulateur m_controller;

        Scenario()
        {
            listAreoport = new List<Areoport>();
            usine = UsineClient.getUsineClient;
            rand = new Random(DateTime.Now.Millisecond);
            m_simulateurEnMarche = false;
            mainThread = new Thread(new ThreadStart(spin));
            m_horloge = new Horloge();
            

            //TEMPO
            listAreoport.Add(new Areoport());
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
                Thread.Sleep(1);
                m_horloge.ajouteMinutes();
            }
        }

        public void abonnerOnHeureChanged(HorlogeEventHandler handler)
        {
            m_horloge.TempsChanged += handler;
        }
        
        public List<Areoport> Liste
        {
            get { return listAreoport; }
            set { listAreoport = value; }
        }

        public void ajouterPassager()
        {
            foreach (var areoport in listAreoport)
            {
                areoport.m_listClient.Add(usine.creerPassager(listAreoport, areoport, rand));
                Console.WriteLine(usine.creerPassager(listAreoport, areoport, rand));
            }
        }

        public void ajouterMarchandise()
        {
            foreach (var areoport in listAreoport)
            {
                areoport.m_listClient.Add(usine.creerMarchandise(listAreoport, areoport, rand));
                Console.WriteLine(usine.creerMarchandise(listAreoport, areoport, rand));
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
            }
                
        }

        public void ajouterFeu(int width, int height)
        {
            Random nbFeu = new Random();
            for (int i = 0; i < nbFeu.Next(1, 4); i++)
            {
                int index;
                Client tempo = usine.creerFeu(width, height, rand);
                index = trouverPlusProche(listAreoport, tempo);

                if (index != -1)
                {
                    listAreoport[index].m_listClient.Add(tempo);
                    Console.WriteLine(tempo);
                }
            }
        }

        public void ajouterSecours(int width, int height)
        {
            Random nbSecours = new Random();
            for (int i = 0; i < nbSecours.Next(1, 3); i++)
            {
                int index;
                Client tempo = usine.creerSecours(width, height, rand);
                index = trouverPlusProche(listAreoport, tempo);

                if (index != -1)
                {
                    listAreoport[index].m_listClient.Add(tempo);
                    Console.WriteLine(tempo);
                }
            }
        }

        public int trouverPlusProche(List<Areoport> listAreoport, Client client)
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
                        if (possedeAreoIncendie(listAreoport[i]))
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

                    }
                    break;
                case "Observateur":
                    for (int i = 0; i < listAreoport.Count; i++)
                    {
                        if (possedeAreoObservateur(listAreoport[i]))
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

                    }
                    break;
                case "Secours":
                    for (int i = 0; i < listAreoport.Count; i++)
                    {
                        if (possedeAreoSecours(listAreoport[i]))
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

                    }
                    break;
                default:
                    break;
            }
            
            return indexAreoport;
        }

        public bool possedeAreoIncendie(Areoport areoport)
        {
            bool temp = false;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Incendies")
                    if(areoport.m_listAeronef[i].Dispo)
                        temp = true;
                else
                    temp = false;
            }
            return temp;
        }

        public bool possedeAreoObservateur(Areoport areoport)
        {
            bool temp = false;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Observateurs")
                    if (areoport.m_listAeronef[i].Dispo)
                        temp = true;
                    else
                    temp = false;
            }
            return temp;
        }

        public bool possedeAreoSecours(Areoport areoport)
        {
            bool temp = false;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Secours")
                    if (areoport.m_listAeronef[i].Dispo)
                        temp = true;
                    else
                        temp = false;
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
