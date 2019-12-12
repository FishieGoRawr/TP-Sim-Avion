using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Secours : DistanceClient
    {
        /// <summary>
        /// Constructeur d'un client secours
        /// </summary>
        /// <param name="width">Widht de la carte</param>
        /// <param name="height">Height de la carte</param>
        /// <param name="rand"></param>
        public Secours(int width, int height, Random rand) : base()
        {
            this.m_nom = "Secours";
            this.m_destination = randomPosition(width, height, rand);
        }

        /// <summary>
        /// Obtient une position géo aléatoire pour un client secours
        /// </summary>
        /// <param name="width">With de la carte</param>
        /// <param name="height">Height de la carte</param>
        /// <param name="rand"></param>
        /// <returns>Retourne une posGeo aléatoire</returns>
        public override PositionGeo randomPosition(int width, int height, Random rand)
        {
            PositionGeo position = new PositionGeo();

            position.PosX = rand.Next(width);
            position.PosY = rand.Next(height);

            return position;
        }

        /// <summary>
        /// Obtient une version stringifié du client secours
        /// </summary>
        /// <returns>Retourne un string</returns>
        public override string ToString()
        {
            return m_nom + " X: " + m_destination.PosX + " Y: " + m_destination.PosY;
        }

        /// <summary>
        /// Accesseur de la positionGeo
        /// </summary>
        public override PositionGeo Destination
        {
            get { return m_destination; }
            set { m_destination = value; }
        }
    }
}
