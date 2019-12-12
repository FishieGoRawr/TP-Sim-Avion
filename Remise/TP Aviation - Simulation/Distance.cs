using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class Distance : Aeronef
    {
        public int m_nbAller;
        public bool m_dispo;

        /// <summary>
        /// Cosntructeur de distance
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="type"></param>
        /// <param name="vitesse"></param>
        /// <param name="entretien"></param>
        /// <param name="origine"></param>
        public Distance(string nom, string type, int vitesse, int entretien, PositionGeo origine) : base(nom, type, vitesse, entretien, origine)
        {

        }

        /// <summary>
        /// Cosntructeur vide de distance
        /// </summary>
        public Distance()
        {

        }

        /// <summary>
        /// Ascesseur de la disponibilité de l'aéronef
        /// </summary>
        public override bool Dispo
        {
            get { return m_dispo; }
            set { m_dispo = value; }
        }
    }
}
