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

        /// <summary>
        /// Constructeur vide de DistanceClient, hérite de Client
        /// </summary>
        public DistanceClient() : base()
        {

        }

        /// <summary>
        /// Obtient une position aléatoire pour la génération d'un client
        /// </summary>
        /// <param name="width">Width de la carte</param>
        /// <param name="height">Height de la carte</param>
        /// <param name="rand">Aléatoire</param>
        /// <returns>Retourne une position geographique</returns>
        virtual public PositionGeo randomPosition(int width, int height, Random rand)
        {
            PositionGeo position = new PositionGeo();

            return position;
        }

        /// <summary>
        /// Accesseur de la PosX
        /// </summary>
        public override int PosX
        {
            get { return m_destination.PosX; }
        }

        /// <summary>
        /// Accesseur de la PosY
        /// </summary>
        public override int PosY
        {
            get { return m_destination.PosY; }
        }

    }
}
