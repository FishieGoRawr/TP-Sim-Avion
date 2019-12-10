using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Attente : État
    {
        int tempsRestant;
        public Attente(Aeronef aeronef) : base(aeronef)
        {
            etat = 1;
            this.m_aeronef = aeronef;
            this.tempsRestant = aeronef.Entretien;
        }

        public override void avancer(Aeronef aeronef, int tempsPasse)
        {

            if(tempsRestant <= 0)
            {
                if (aeronef.Type == "Passagers" || aeronef.Type == "Marchandises")
                {
                    Etat = 2;
                }
                else if (aeronef.Type == "Incendies" || aeronef.Type == "Secours")
                {
                    Etat = 5;
                }
                else
                {
                    Etat = 4;
                }
            }
            else
            {
                tempsRestant = tempsRestant - tempsPasse;
            }

            
        }
    }
}
