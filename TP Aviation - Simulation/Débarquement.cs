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

        /// <summary>
        /// Constructeur de l'état débarquemet
        /// </summary>
        /// <param name="aeronef">Aéronef auquel l'état appartient</param>
        public Débarquement(Aeronef aeronef) : base(aeronef)
        {
            Index = 6;
            this.m_aeronef = aeronef;
            this.tempsRestant = aeronef.Debarquement;
        }

        /// <summary>
        /// Diminue le temps temps de débarquement selon le temps passer par tick
        /// </summary>
        /// <param name="tempsPasse">Minute passée dans la simulation pendant le tick</param>
        /// <param name="clients">Liste des clients dans l'aéroport auquel appartient l'aéronef</param>
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
