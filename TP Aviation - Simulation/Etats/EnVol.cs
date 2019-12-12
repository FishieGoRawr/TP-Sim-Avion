using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class EnVol : Etat
    {
        protected PositionGeo m_positionActuelle;

        /// <summary>
        /// Constructeur vide
        /// </summary>
        /// <param name="aeronef"></param>
        public EnVol(Aeronef aeronef) : base(aeronef)
        {
            
        }

        /// <summary>
        /// Ce qui se passe quand un avion est en vol
        /// </summary>
        /// <param name="tempsPasse"></param>
        /// <param name="clients"></param>
        public override void avancer(int tempsPasse, List<Client> clients)
        {

        }

        /// <summary>
        /// Accesseur pour la position actuelle de l'avion en vol
        /// </summary>
        public PositionGeo PositionActuelle
        {
            get { return m_positionActuelle; }
        }
    }
}
