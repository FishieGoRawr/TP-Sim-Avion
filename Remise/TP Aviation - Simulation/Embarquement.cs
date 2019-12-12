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

        /// <summary>
        /// Constructeur de l'état Embarquement
        /// </summary>
        /// <param name="aeronef">Aeronef à utilisé pour l'embarquement</param>
        public Embarquement(Aeronef aeronef) : base(aeronef)
        {
            etat = 2;
            this.m_aeronef = aeronef;
            this.tempsRestant = aeronef.Embarquement;
        }

        /// <summary>
        /// Override de la méthode "avancer" d'Etat. Permet d'avancer un cycle.
        /// </summary>
        /// <param name="tempsPasse">Donne le temps passé dans le cycle</param>
        /// <param name="clients">Fournit la liste des clients du scénario</param>
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
