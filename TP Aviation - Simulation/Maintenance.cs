using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Maintenance : Etat
    {
        int tempsRestant;
        public Maintenance(Aeronef aeronef) : base(aeronef)
        {
            Index = 7;
            this.m_aeronef = aeronef;
            this.tempsRestant = aeronef.Entretien;
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {
            if (tempsRestant <= 0)
            {

                Index = 1;
            }
            else
            {
                tempsRestant = tempsRestant - tempsPasse;
            }
        }
    }
}
