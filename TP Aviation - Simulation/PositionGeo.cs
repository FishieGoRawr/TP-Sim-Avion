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


        //public PositionGeo(TextBox posDegreeMin)
        //{
        //    string[] pos = posDegreeMin.Tag.ToString().Split(' ');

        //    m_posX = Convert.ToInt32(pos[0]);
        //    m_posY = Convert.ToInt32(pos[1]);
        //    m_posDegreeMin = posDegreeMin.Text;
        //}

        public PositionGeo()
        {
            m_posX = 0;
            m_posY = 0;
        }

        public int PosY
        {
            get { return m_posY; }
            set { m_posY = value; }
        }

        public int PosX
        {
            get { return m_posX; }
            set { m_posX = value; }
        }

        public override string ToString()
        {
            return m_posDegreeMin;
        }
    }
}
