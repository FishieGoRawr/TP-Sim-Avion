using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class EnVol : État
    {
        PositionGeo m_positionActuelle;
        public EnVol(Aeronef aeronef) : base(aeronef)
        {
            
        }

        public override void avancer(Aeronef aeronef, int tempsPasse)
        {

        }
    }
}
