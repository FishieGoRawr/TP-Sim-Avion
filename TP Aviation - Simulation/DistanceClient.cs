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

        public DistanceClient() : base()
        {

        }

        virtual public PositionGeo randomPosition(int width, int height, Random rand)
        {
            PositionGeo position = new PositionGeo();

            return position;
        }

        public override int PosX
        {
            get { return m_destination.PosX; }
        }
        public override int PosY
        {
            get { return m_destination.PosX; }
        }

    }
}
