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
            etat = 6;
        }

        public override void avancer(Aeronef aeronef, int tempsPasse)
        {

        }
    }
}
