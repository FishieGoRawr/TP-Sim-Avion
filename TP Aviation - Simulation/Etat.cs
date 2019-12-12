using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public class Etat
    {
        protected int etat = 1;
        protected Aeronef m_aeronef;

        /// <summary>
        /// Constructeur d'un état
        /// </summary>
        /// <param name="aeronef">Aeronef a qui est associé l'état</param>
        public Etat(Aeronef aeronef)
        {
            m_aeronef = aeronef;
        }

        /// <summary>
        /// Retourne l'etat ou est rnedu l'aeronef
        /// </summary>
        public virtual int Index
        {
            get { return etat; }
            set { etat = value; }
        }

        /// <summary>
        /// Methode qui doit etre override, permet d'avancer d'un cycle.
        /// </summary>
        /// <param name="tempsPasse">Temps passé dans le cycle</param>
        /// <param name="clients">Liste de clients du scénario</param>
        public virtual void avancer(int tempsPasse, List<Client> clients)
        {

        }
    }
}
