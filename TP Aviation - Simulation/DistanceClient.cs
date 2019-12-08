using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class DistanceClient : Client
    {
        protected PositionGeo m_destination;

        public DistanceClient(String nom, PositionGeo destination) : base(nom)
        {

        }
    }
}
