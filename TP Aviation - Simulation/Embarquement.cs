using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Embarquement : État
    {
        public Embarquement(Aeronef aeronef) : base(aeronef)
        {
            etat = 2;
        }

        public override void avancer(Aeronef aeronef, int tempsPasse)
        {
            if (0 == 0)
                Etat = 3;
        }
    }
}
