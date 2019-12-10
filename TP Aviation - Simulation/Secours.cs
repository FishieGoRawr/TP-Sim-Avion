using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Secours : DistanceClient
    {
        public Secours(int width, int height, Random rand) : base()
        {
            this.m_nom = "Secours";
            this.m_destination = randomPosition(width, height, rand);
        }

        public override PositionGeo randomPosition(int width, int height, Random rand)
        {
            PositionGeo position = new PositionGeo();

            position.PosX = rand.Next(width);
            position.PosY = rand.Next(height);

            return position;
        }

        public override string ToString()
        {
            return m_nom + " X: " + m_destination.PosX + " Y: " + m_destination.PosY;
        }
    }
}
