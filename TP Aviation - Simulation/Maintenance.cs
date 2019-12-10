using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Maintenance : Etat
    {
        public Maintenance(Aeronef aeronef) : base(aeronef)
        {
            Index = 8;
            this.m_aeronef = aeronef;
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {

        }
    }
}
