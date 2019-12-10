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
            m_positionActuelle = distanceParcourue(tempsPasse);


            switch (m_aeronef.Type)
            {
                case "Secours":
                    if (m_positionActuelle.Equals(clients[0].Destination))
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
    }
}
