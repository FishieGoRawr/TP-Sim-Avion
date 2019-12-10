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
            Index = 5;
            this.m_aeronef = aeronef;
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {

        }
    }
}
