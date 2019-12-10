using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Observation : EnVol
    {
         
        public Observation(Aeronef aeronef) : base(aeronef)
        {
            etat = 5;
        }

        public override void avancer(Aeronef aeronef, int tempsPasse)
        {

        }
    }
}
