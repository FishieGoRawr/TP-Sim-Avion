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

        public TransportClient(List<Aeroport> listAreoport, Random rand) : base()
        {
        }

        public override PositionGeo Destination
        {
            get { return m_destination.Localisation; }
        }
    }
}
