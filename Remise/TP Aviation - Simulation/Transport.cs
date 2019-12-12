using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class Transport : Aeronef
    {
        public int m_tempsEmb;
        public int m_tempsDeb;

        /// <summary>
        /// Constructeur vide de transport
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="type"></param>
        /// <param name="vitesse"></param>
        /// <param name="entretien"></param>
        /// <param name="origine"></param>
        /// <param name="charger"></param>
        /// <param name="decharger"></param>
        public Transport(string nom, string type, int vitesse, int entretien, PositionGeo origine, int charger, int decharger) : base(nom, type, vitesse, entretien, origine)
        {

        }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Transport()
        {

        }

        /// <summary>
        /// Avancer d'un cycle
        /// </summary>
        /// <param name="temps">Temps d'un cycle</param>
        /// <param name="clients">Liste de clients</param>
        public override void avancerAvion(int temps, List<Client> clients)
        {
        }

        /// <summary>
        /// Accesseur du temps d'embarquement
        /// </summary>
        public override int Embarquement
        {
            get { return m_tempsEmb; }
        }

        /// <summary>
        /// Accesseur du temps de debarquement
        /// </summary>
        public override int Debarquement
        {
            get { return m_tempsDeb; }
        }
    }
}
