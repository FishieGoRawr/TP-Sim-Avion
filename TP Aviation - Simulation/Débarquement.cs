using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Débarquement : Etat
    {
        int tempsRestant;
        public Débarquement(Aeronef aeronef) : base(aeronef)
        {
            Index = 6;
            this.m_aeronef = aeronef;
            this.tempsRestant = aeronef.Debarquement;
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {
            if (tempsRestant <= 0)
            {

                Index = 7;
            }
            else
            {
                tempsRestant = tempsRestant - tempsPasse;
            }
        }
    }
}
