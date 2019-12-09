using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Secours : DistanceClient
    {
        public Secours(int width, int height) : base()
        {
            this.m_nom = "Secours";
            this.m_destination = randomPosition(width, height);
        }

        public override PositionGeo randomPosition(int width, int height)
        {
            PositionGeo position = new PositionGeo();

            Random rand = new Random();

            position.PosX = rand.Next(width);
            position.PosY = rand.Next(height);

            return position;
        }
    }
}
