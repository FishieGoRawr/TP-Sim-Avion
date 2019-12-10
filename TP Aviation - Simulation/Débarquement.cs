using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Débarquement : État
    {
        public Débarquement(Aeronef aeronef) : base(aeronef)
        {
            etat = 7;
        }

        public override void avancer(Aeronef aeronef, int tempsPasse)
        {

        }
    }
}
