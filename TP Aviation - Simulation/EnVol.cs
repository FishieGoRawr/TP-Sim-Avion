using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class EnVol : Etat
    {
        protected PositionGeo m_positionActuelle;
        public EnVol(Aeronef aeronef) : base(aeronef)
        {
            
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {

        }

        public PositionGeo PositionActuelle
        {
            get { return m_positionActuelle; }
        }
    }
}
