using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{
    public class PositionGeo
    {
        double m_latitude, m_longitude;
        string horizontal, vertical;

        public PositionGeo(string pos)
        {
            string[] posSplit = new string[2];
            posSplit = pos.Split(' ');

            horizontal = posSplit[0].Substring(4);
            m_longitude = Convert.ToDouble(posSplit[0].Substring(0, 4));
            vertical = posSplit[2].Substring(4);
            m_latitude = Convert.ToDouble(posSplit[2].Substring(0, 4));
        }

        public PositionGeo(int posX, int posY)
        {
            m_longitude = posX;
            m_latitude = posY;
        }

        public PositionGeo()
        {
            m_longitude = 0;
            m_latitude = 0;
        }

        private double[] convertPosToDegree(double x, double y)
        {
            double lon, lat;
            double[] coords = new double[2];

            if (x < ( Properties.Resources.worldmap_good.Width / 2))
                lon = (inverserNombre(0, 180, (x * 180) / 1000)) * -1;
            else
                lon = (x * 180) / 1000;

            if (y < Properties.Resources.worldmap_good.Height / 2)
                lat = inverserNombre(0, 90, (y * 90) / 249.5);
            else
                lat = inverserNombre(0, 90, (y * 90) / 249.5);

            coords[0] = Math.Round(lon, 3);
            coords[1] = Math.Round(lat, 3);

            return coords;
        }

        private double inverserNombre(double min, double max, double input)
        {
            return (max + min) - input;
        }

        public override string ToString()
        {
            return  m_longitude + horizontal + " " + m_latitude + vertical;
        }
    }
}
