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
               
        /// <summary>
        /// Permet de mettre en pause/resume la boucle principale
        /// </summary>
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

        /// <summary>
        /// Boucle principale du logiciel
        /// </summary>
        public void spin()
        {
            while (m_simulateurEnMarche)
            {
                Thread.Sleep(50);
                genererClients();
                

                foreach (Aeroport airport in listAreoport)
                {
                    airport.bougerAvion(5);
                }

                m_horloge.ajouteMinutes();
            }
        }

        /// <summary>
        /// Permet d'abonner une méthode a l'evenement "TempsChanged"
        /// </summary>
        /// <param name="handler"></param>
        public void abonnerOnHeureChanged(HorlogeEventHandler handler)
        {
            m_horloge.TempsChanged += handler;
        }
        
        /// <summary>
        /// Accesseur de la liste d'aeroport
        /// </summary>
        public List<Aeroport> Liste
        {
            get { return listAreoport; }
            set { listAreoport = value; }
        }

        /// <summary>
        /// Genere des clients lorsque les heures passent
        /// </summary>
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
                    ajouterPassager();
                    ajouterMarchandise();
                }
                m_derniereHeure = heure;
            }

        }

        /// <summary>
        /// Crée un lien avec le constructeur principal
        /// </summary>
        /// <param name="controller"></param>
        public void setController(ControllerSimulateur controller)
        {
            m_controller = controller;
        }

        /// <summary>
        /// Permet de créer des clients passager
        /// </summary>
        public void ajouterPassager()
        {
            foreach (var areoport in listAreoport)
            {
                areoport.m_listClient.Add(usine.creerPassager(listAreoport, areoport, rand));
            }
        }

        /// <summary>
        /// Permet de créer des clients marchandise
        /// </summary>
        public void ajouterMarchandise()
        {
            foreach (var areoport in listAreoport)
            {
                areoport.m_listClient.Add(usine.creerMarchandise(listAreoport, areoport, rand));
            }
        }

        /// <summary>
        /// Permet de créer des clients observateur
        /// </summary>
        /// <param name="width">Width de la carte</param>
        /// <param name="height">Height de la carte</param>
        public void ajouterObservateur(int width, int height)
        {
            int index;
            Client tempo = usine.creerObservateur(width, height, rand);
            index = trouverPlusProche(listAreoport, tempo);

            if(index != -1)
            {
                listAreoport[index].m_listClient.Add(tempo);
                m_listClients.Add(tempo);
            }
            else
            {
                m_listClients.Add(tempo);
            }
                
        }

        /// <summary>
        /// Permet de créer des clients incendie
        /// </summary>
        /// <param name="width">Width de la carte</param>
        /// <param name="height">Height de la carte</param>
        public void ajouterFeu(int width, int height)
        {
            Random nbFeu = new Random();

                int index;
                Client tempo = usine.creerFeu(width, height, rand);
                index = trouverPlusProche(listAreoport, tempo);

                if (index != -1)
                {
                    listAreoport[index].m_listClient.Add(tempo);
                    m_listClients.Add(tempo);
                }
                else
                {
                    m_listClients.Add(tempo);
                }
        }

        /// <summary>
        /// Permet de créer des clients secours
        /// </summary>
        /// <param name="width">Width de la carte</param>
        /// <param name="height">Height de la carte</param>
        public void ajouterSecours(int width, int height)
        {
            Random nbSecours = new Random();
                int index;
                Client tempo = usine.creerSecours(width, height, rand);
                index = trouverPlusProche(listAreoport, tempo);

                if (index != -1)
                {
                    listAreoport[index].m_listClient.Add(tempo);
                    m_listClients.Add(tempo);
                }
                else
                {
                    m_listClients.Add(tempo);
                }
        }

        /// <summary>
        /// Trouve l'aréoport, qui a un avion disponible pour la situation, le plus proche d'un client
        /// </summary>
        /// <param name="listAreoport">Liste d'aréoport</param>
        /// <param name="client">Client a verifier</param>
        /// <returns></returns>
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

        /// <summary>
        /// Vérifie si l'areoport passé possède un avion incendie de dispo
        /// </summary>
        /// <param name="areoport">Areoport a verifier</param>
        /// <returns>1 si oui, 0 si non</returns>
        public int possedeAreoIncendie(Aeroport areoport)
        {
            int temp = -1;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Incendies")
                    if (areoport.m_listAeronef[i].Dispo)
                    {
                        temp = 1;
                    }
                    else
                    {
                        temp = 2;
                    }
            }
            return temp;
        }

        /// <summary>
        /// Vérifie si l'areoport passé possède un avion observateur de dispo
        /// </summary>
        /// <param name="areoport">Areoport a verifier</param>
        /// <returns>1 si oui, 0 si non</returns>
        public int possedeAreoObservateur(Aeroport areoport)
        {
            int temp = -1;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Observateurs")
                    if (areoport.m_listAeronef[i].Dispo)
                    {
                        temp = 1;
                    }
                    else
                    {
                        temp = 2;
                    }
            }
            return temp;
        }

        /// <summary>
        /// Vérifie si l'areoport passé possède un avion secours de dispo
        /// </summary>
        /// <param name="areoport">Areoport a verifier</param>
        /// <returns>1 si oui, 0 si non</returns>
        public int possedeAreoSecours(Aeroport areoport)
        {
            int temp = -1;
            for (int i = 0; i < areoport.m_listAeronef.Count; i++)
            {
                if (areoport.m_listAeronef[i].Type == "Secours")
                    if (areoport.m_listAeronef[i].Dispo)
                    {
                        temp = 1;
                    }
                    else
                    {
                        temp = 2;
                    }
            }
            return temp;
        }

        /// <summary>
        /// Obtient une ligne droite vers la destination
        /// </summary>
        /// <param name="a">x2 - x1</param>
        /// <param name="b">y2 - y1</param>
        /// <returns>Retourne l'hypotenuse distance jusqu'au client</returns>
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
