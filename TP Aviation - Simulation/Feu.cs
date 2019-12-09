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

        public Feu(int width, int height) : base()
        {
            this.m_nom = "Feu";
            this.m_destination = randomPosition(width, height);
            this.m_intensite = randomIntensite();
        }

        public override PositionGeo randomPosition(int width, int height)
        {
            PositionGeo position = new PositionGeo();

            Random rand = new Random();

            position.PosX = rand.Next(width);
            position.PosY = rand.Next(height);

            return position;
        }

        public int randomIntensite()
        {
            Random rand = new Random();
            int intensite = 0;
            intensite = rand.Next(5);

            return intensite;
        }
    }
}
