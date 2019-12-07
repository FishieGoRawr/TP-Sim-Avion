using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aviation___Generateur_de_scénario
{
    public class PositionGeo
    {
        int m_posX { get; set; }
        int m_posY { get; set; }
        string m_posDegreeMin { get; set; }

        public PositionGeo(TextBox posDegreeMin)
        {
            string[] pos = posDegreeMin.Tag.ToString().Split(' ');

            m_posX = Convert.ToInt32(pos[0]);
            m_posY = Convert.ToInt32(pos[1]);
            m_posDegreeMin = posDegreeMin.Text;
        }

        public PositionGeo()
        {
            m_posX = 0;
            m_posY = 0;
        }

        public override string ToString()
        {
            return m_posDegreeMin;
        }
    }
}
