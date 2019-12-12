using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Attente : Etat
    {
        /// <summary>
        /// Constructeur de l'état allerRetour
        /// </summary>
        /// <param name="aeronef">Aéronef auquel l'état appartient</param>
        public Attente(Aeronef aeronef) : base(aeronef)
        {
            etat = 1;
            this.m_aeronef = aeronef;
        }

        /// <summary>
        /// Vérifie s'il y a assez de client dans l'aéroport pour décoller
        /// </summary>
        /// <param name="tempsPasse">Minute passée dans la simulation pendant le tick</param>
        /// <param name="clients">Liste des clients dans l'aéroport auquel appartient l'aéronef</param>
        public override void avancer(int tempsPasse, List<Client> clients)
        {
            if (this.m_aeronef.Dispo && clients.Count > 0)
            {
                if (m_aeronef.Type == "Passagers")
                {
                    int total = 0;
                    List<int> iClient = new List<int>();

                    foreach (var client in clients)
                    {
                        for (int i = 0; i < clients.Count; i++)
                        {
                            if ((clients[i].Nom == "Passager") && (clients[i].Destination == client.Destination))
                            {
                                total = total + clients[i].Quantite;
                                iClient.Add(i);
                                this.m_aeronef.IndexClient = i;
                            }
                        }
                    }

                    //Si plus de 75% ed l'aéronef est rempli
                    if (total >= (m_aeronef.Capacite * 0.75))
                    {
                        for (int i = 0; i < clients.Count; i++)
                        {
                            this.m_aeronef.m_clientDestination = new PositionGeo(clients[i].Destination.PosX, clients[i].Destination.PosY);
                            //m_aeronef.m_clientDestination = clients[i].Destination;
                            //clients.RemoveAt(iClient[i]);
                        }

                        m_aeronef.Dispo = false;
                        Index = 2;
                    }
                    else if (total > m_aeronef.Capacite)
                    {
                        //diviser client
                    }
                    else
                    {
                        m_aeronef.IndexClient = -1;
                    }
                }
                else if (m_aeronef.Type == "Marchandises")
                {
                    double total = 0;
                    List<int> iClient = new List<int>();

                    foreach (var client in clients)
                    {
                        for (int i = 0; i < clients.Count; i++)
                        {
                            if ((clients[i].Nom == "Marchandise") && (clients[i].Destination == client.Destination))
                            {
                                total = total + clients[i].Quantite;
                            }
                        }

                        //Si plus de 75% ed l'aéronef est rempli
                        if (total >= (m_aeronef.Capacite * 0.75))
                        {
                            for (int i = 0; i < iClient.Count; i++)
                            {
                                clients.RemoveAt(iClient[i]);
                            }
                            Index = 2;
                        }
                    }
                }
                else if (m_aeronef.Type == "Incendies" || m_aeronef.Type == "Secours")
                {
                    Index = 5;
                }
                else
                {
                    Index = 4;
                }
            }
        }
    }
}
