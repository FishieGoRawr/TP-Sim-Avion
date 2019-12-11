using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class AllerRetour : EnVol
    {
        public AllerRetour(Aeronef aeronef) : base(aeronef)
        {
            Index = 6;
            this.m_aeronef = aeronef;
            this.m_positionActuelle = aeronef.Origine;
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {
            int clientX;
            int clientY;

            int x;
            int y;

            x = m_positionActuelle.PosX;
            y = m_positionActuelle.PosY;

            clientX = clients[m_aeronef.IndexClient].Destination.PosX;
            clientY = clients[m_aeronef.IndexClient].Destination.PosY;

            double distance = pythagore(clientX - x, clientY - y);

            m_positionActuelle = distanceParcourue(tempsPasse);

            switch (m_aeronef.Type)
            {
                case "Secours":
                    if ()
                    {
                        
                    }
                    else
                    {

                    }
                    break;
                case "Incendies":
                    break;
                default:
                    break;
            }
        }

        public PositionGeo distanceParcourue(int temps)
        {
            PositionGeo nouvellePosition = new PositionGeo();



            return nouvellePosition;
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
