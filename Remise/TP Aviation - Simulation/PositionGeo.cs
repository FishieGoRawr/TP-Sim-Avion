using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public class PositionGeo
    {
        public int m_posX { get; set; }
        public int m_posY { get; set; }
        public string m_posDegreeMin;

        /// <summary>
        /// Constructeur de position géo
        /// </summary>
        /// <param name="x">X a mettre dans la position geo</param>
        /// <param name="y">Y a metter dans la position geo</param>
        public PositionGeo(int x, int y)
        {
            m_posX = x;
            m_posY = y;
            m_posDegreeMin = "";
        }

        /// <summary>
        /// Constructeur vide de PositionGeo
        /// </summary>
        public PositionGeo()
        {
            m_posX = 0;
            m_posY = 0;
            m_posDegreeMin = "";
        }

        /// <summary>
        /// Accesseur de PosY
        /// </summary>
        public int PosY
        {
            get { return m_posY; }
            set { m_posY = value; }
        }

        /// <summary>
        /// Accesseur de PosX
        /// </summary>
        public int PosX
        {
            get { return m_posX; }
            set { m_posX = value; }
        }

        /// <summary>
        /// Retourne la PositionGeo sous format stringifier
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return m_posDegreeMin;
        }
    }
}
