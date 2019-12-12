using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Embarquement : Etat
    {
        int tempsRestant;
        public Embarquement(Aeronef aeronef) : base(aeronef)
        {
            etat = 2;
            this.m_aeronef = aeronef;
            this.tempsRestant = aeronef.Embarquement;
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {
            tempsRestant = tempsRestant - tempsPasse;

            if (tempsRestant <= 0)
            {
                Index = 3;
            }
        }
    }
}
