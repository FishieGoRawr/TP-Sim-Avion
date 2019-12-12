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

        /// <summary>
        /// Constructeur de base d'observateur
        /// </summary>
        /// <param name="width">Widht de la carte</param>
        /// <param name="height">Hauteur de la carte</param>
        /// <param name="rand"></param>
        public Observateur(int width, int height, Random rand) : base()
        {
            this.m_nom = "Observateur";
            this.m_destination = randomPosition(width, height, rand);
            this.m_rayon = 20;
        }

        /// <summary>
        /// Obtient une position aléatoire dans la carte pour un observateur
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="rand"></param>
        /// <returns>Positiongeo aléatoire dans la carte</returns>
        public override PositionGeo randomPosition(int width, int height, Random rand)
        {
            PositionGeo position = new PositionGeo();

            position.PosX = rand.Next(width);
            position.PosY = rand.Next(height);

            return position;
        }

        /// <summary>
        /// Version stringifier d'un observateur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return m_nom + " " + m_destination + " " + m_rayon;
        }

        /// <summary>
        /// Accesseur de la positiongeo de l'observateur
        /// </summary>
        public override PositionGeo Destination
        {
            get { return m_destination; }
            set { m_destination = value; }
        }
    }
}
