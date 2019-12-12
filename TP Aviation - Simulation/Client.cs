using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class Client
    {
        protected String m_nom;

        /// <summary>
        /// Cosntructeur de client
        /// </summary>
        public Client()
        {

        }

        /// <summary>
        /// Ascesseur du nom du client
        /// </summary>
        public String Nom
        {
            get { return m_nom; }
        }

        /// <summary>
        /// Ascesseur de la position X nom du client
        /// </summary>
        public virtual int PosX
        {
            get { return -1; }
        }

        /// <summary>
        /// Ascesseur de la position Y du client
        /// </summary>
        public virtual int PosY
        {
            get { return -1; }
        }

        /// <summary>
        /// Ascesseur de la quantite du client
        /// </summary>
        public virtual int Quantite
        {
            get { return 0; }
        }

        /// <summary>
        /// Ascesseur du poid du client
        /// </summary>
        public virtual double Poid
        {
            get { return 0; }
        }

        /// <summary>
        /// Ascesseur de la destination du client
        /// </summary>
        public virtual PositionGeo Destination
        {
            get { return null; }
            set {  }
        }
    }
}
