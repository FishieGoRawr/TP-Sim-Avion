using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Feu : DistanceClient
    {
        protected int m_intensite;

        public Feu(int width, int height, Random rand) : base()
        {
            this.m_nom = "Feu";
            this.m_destination = randomPosition(width, height, rand);
            this.m_intensite = randomIntensite(rand);
        }

        public override PositionGeo randomPosition(int width, int height, Random rand)
        {
            PositionGeo position = new PositionGeo();
            position.PosX = rand.Next(width);
            position.PosY = rand.Next(height);

            return position;
        }

        public int randomIntensite(Random rand)
        {
            int intensite = 0;
            intensite = rand.Next(5);

            return intensite;
        }

        public override string ToString()
        {
            return m_nom + " " + m_destination + " " + m_intensite;
        }
    }
}
