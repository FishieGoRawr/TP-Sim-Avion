using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Observation : EnVol
    {
        /// <summary>
        /// Constructeur de l'état Observation
        /// </summary>
        /// <param name="aeronef">Aeronef a qui affecter l'etat observation</param>
        public Observation(Aeronef aeronef) : base(aeronef)
        {
            Index = 5;
            this.m_aeronef = aeronef;
            this.m_positionActuelle = aeronef.Origine;
        }

        /// <summary>
        /// Ce qui se produit dans un cycle
        /// </summary>
        /// <param name="tempsPasse">temps passé dans le cycle</param>
        /// <param name="clients">liste de clients</param>
        public override void avancer(int tempsPasse, List<Client> clients)
        {
            int x = m_positionActuelle.PosX;
            int y = m_positionActuelle.PosY;

            int clientX = clients[m_aeronef.IndexClient].Destination.PosX;
            int clientY = clients[m_aeronef.IndexClient].Destination.PosY;

            double distance = pythagore(clientX - x, clientY - y);
            double ticks = distance / (m_aeronef.Vitesse * tempsPasse);

            m_positionActuelle.PosX += Convert.ToInt32((clientX - x) / ticks);
            m_positionActuelle.PosY += Convert.ToInt32((clientY - y) / ticks);

            switch (m_aeronef.Type)
            {
                case "Secours":
                    if (m_positionActuelle.Equals(clients[m_aeronef.IndexClient].Destination))
                    {
                        PositionGeo tempo = m_aeronef.Origine;
                        m_aeronef.Origine = clients[m_aeronef.IndexClient].Destination;
                        clients[m_aeronef.IndexClient].Destination = tempo;
                    }
                    else
                    {

                    }
                    break;
                case "Incendies":
                    if (true)
                    {

                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Trouve la ligne droite jusqu'a destination
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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
