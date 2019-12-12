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

        /// <summary>
        /// Constructeur de base de l'etat maintenance
        /// </summary>
        /// <param name="aeronef">Aeronef a qui affecter l'etat</param>
        public Maintenance(Aeronef aeronef) : base(aeronef)
        {
            Index = 7;
            this.m_aeronef = aeronef;
            this.tempsRestant = aeronef.Entretien;
        }

        /// <summary>
        /// Doit etre overrider, avance d'un cycle
        /// </summary>
        /// <param name="tempsPasse">temps passé dans le cycle</param>
        /// <param name="clients">Liste de clients du scénario</param>
        public override void avancer(int tempsPasse, List<Client> clients)
        {
            tempsRestant = tempsRestant - tempsPasse;

            if (tempsRestant <= 0)
            {

                Index = 1;
            }
        }
    }
}
