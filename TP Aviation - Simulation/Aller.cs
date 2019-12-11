using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Aller : EnVol
    {
        public Aller(Aeronef aeronef) : base(aeronef)
        {
            Index = 3;
            this.m_aeronef = aeronef;
        }

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

            if (m_positionActuelle.Equals(clients[m_aeronef.IndexClient].Destination))
            {
                m_aeronef.Origine = clients[m_aeronef.IndexClient].Destination;
                m_positionActuelle = null;
                Index = 6;
            }
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
