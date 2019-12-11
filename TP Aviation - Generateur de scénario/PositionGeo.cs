﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    /// <summary>
    /// Classe pour obtenir la position géoraphique d'un aréoport
    /// </summary>
    
    public class PositionGeo
    {
        public int m_posX { get; set; } //Position en X sur la carte
        public int m_posY { get; set; } //Position en Y sur la carte
        public string m_posDegreeMin { get; set; } //Position sous format degree/minute

        /// <summary>
        /// Constructeur d'une position géo
        /// </summary>
        /// <param name="posDegreeMin">Textbox en parametres. Le text contient la string format posDegreeMin, le Tag contient la position X,Y</param>
        public PositionGeo(TextBox posDegreeMin)
        {
            string[] pos = posDegreeMin.Tag.ToString().Split(' ');

            m_posX = Convert.ToInt32(pos[0]);
            m_posY = Convert.ToInt32(pos[1]);
            m_posDegreeMin = posDegreeMin.Text;
        }

        /// <summary>
        /// Constructeur de base de positionGeo au position x0y0.
        /// </summary>
        public PositionGeo()
        {
            m_posX = 0;
            m_posY = 0;
        }

        /// <summary>
        /// Permet d'obtenir le string sous forme degreeMin
        /// </summary>
        /// <returns>Retourne la position sous forme degreeMin</returns>
        public override string ToString()
        {
            return m_posDegreeMin;
        }
    }
}
