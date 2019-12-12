using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public class Feu : DistanceClient
    {
        protected int m_intensite;

        /// <summary>
        /// Constructeur d'un client feu
        /// </summary>
        /// <param name="width">Width de la carte</param>
        /// <param name="height">Height de la carte</param>
        /// <param name="rand">Random</param>
        public Feu(int width, int height, Random rand) : base()
        {
            this.m_nom = "Feu";
            this.m_destination = randomPosition(width, height, rand);
            this.m_intensite = randomIntensite(rand);
        }

        /// <summary>
        /// Obtient une position random pour le feu
        /// </summary>
        /// <param name="width">Width de la carte</param>
        /// <param name="height">Height de la carte</param>
        /// <param name="rand">Random</param>
        /// <returns>PositionGeo aléatoire dans la carte</returns>
        public override PositionGeo randomPosition(int width, int height, Random rand)
        {
            PositionGeo position = new PositionGeo();
            position.PosX = rand.Next(width);
            position.PosY = rand.Next(height);

            return position;
        }

        /// <summary>
        /// Obtient une intensité random pour le feu.
        /// </summary>
        /// <param name="rand"></param>
        /// <returns></returns>
        public int randomIntensite(Random rand)
        {
            int intensite = 0;
            intensite = rand.Next(1,5);

            return intensite;
        }

        /// <summary>
        /// Retourne une version lisible d'un feu
        /// </summary>
        /// <returns>Feu sous forme de string</returns>
        public override string ToString()
        {
            return m_nom + " " + m_destination + " " + m_intensite;
        }
        public override PositionGeo Destination
        {
            get { return m_destination; }
            set { m_destination = value; }
        }

    }
}
