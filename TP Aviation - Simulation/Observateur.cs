using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Observateur : DistanceClient

    {
        int m_rayon;

        public Observateur(int width, int height, Random rand) : base()
        {
            this.m_nom = "Observateur";
            this.m_destination = randomPosition(width, height, rand);
            this.m_rayon = 20;
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
            return m_nom + " " + m_destination + " " + m_rayon;
        }
    }
}
