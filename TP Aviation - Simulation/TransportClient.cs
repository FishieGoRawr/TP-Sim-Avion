using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class TransportClient : Client
    {
        protected Aeroport m_destination;

        /// <summary>
        /// Constructeur vide de transportclient
        /// </summary>
        /// <param name="listAreoport"></param>
        /// <param name="rand"></param>
        public TransportClient(List<Aeroport> listAreoport, Random rand) : base()
        {
        }

        /// <summary>
        /// Obtient la positiongeo de transport client
        /// </summary>
        public override PositionGeo Destination
        {
            get { return m_destination.Localisation; }
        }
    }
}
