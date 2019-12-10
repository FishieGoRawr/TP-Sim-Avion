using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Maintenance : État
    {
        public Maintenance(Aeronef aeronef) : base(aeronef)
        {
            etat = 8;
        }

        public override void avancer(Aeronef aeronef, int tempsPasse)
        {

        }
    }
}
