using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aviation___Generateur_de_scénario
{
    public partial class GUIPosition : Form
    {
        GUIGenerateur guigen;
        public GUIPosition(GUIGenerateur gui)
        {
            guigen = gui;
            InitializeComponent();
        }

        private void pcbWorldmap_MouseClick(object sender, MouseEventArgs e)
        {
            string coordString = "";
            //double[] coords = convertPosToDegree(e.X, e.Y);
            double[] coords = convertPosToMinSec(e.X, e.Y);

            //if (coords[0] < 0 && coords[1] > 0)
            //    coordString = "N" + coords[1] + " O" + coords[0];
            //else if (coords[0] < 0 && coords[1] < 0)
            //    coordString = "S" + coords[1] + " O" + coords[0];
            //else if (coords[0] > 0 && coords[1] < 0)
            //    coordString = "S" + coords[1] + " E" + coords[0];
            //else
            //    coordString = "N" + coords[1] + " E" + coords[0];


            //guigen.changerValeurPosition(coordString);
            //this.Dispose();
        }

        private double[] convertPosToDegree(double x, double y)
        {
            double lon, lat;
            double[] coords = new double[2];

            if (x < (pcbWorldmap.Width / 2))
                lon = (reverseNumber(0, 180, (x * 180) / 1000)) * -1;
            else
                lon = (x * 180) / 1000;

            if (y < pcbWorldmap.Height / 2)
                lat = reverseNumber(0, 90, (y * 90) / 249.5);
            else
                lat = reverseNumber(0, 90, (y * 90) / 249.5);

            coords[0] = Math.Round(lon, 3);
            coords[1] = Math.Round(lat, 3);

            return coords;
        }

        private double[] convertPosToMinSec(double x, double y)
        {
            double[] coords = new double[2];
            char horizontal = ' ', vertical = ' ';
            double milieuX = pcbWorldmap.Width / 2;
            double milieuY = pcbWorldmap.Height / 2;
            double degFromMidX = Math.Abs(x - milieuX);
            double degFromMidY = Math.Abs(y - milieuY);
            double horizontalDegreeMin = (degFromMidX * 360) / pcbWorldmap.Width;
            double verticalDegreeMin = (degFromMidY * 180) / pcbWorldmap.Height;

            if (x < (pcbWorldmap.Width / 2) && y < (pcbWorldmap.Height / 2)) //Cadran 1
            {
                horizontal = 'O';
                vertical = 'N';
            }
            else if (x > (pcbWorldmap.Width / 2) && y < (pcbWorldmap.Height / 2)) //Cadran 2
            {
                horizontal = 'E';
                vertical = 'N';
            }
            else if (x < (pcbWorldmap.Width / 2) && y > (pcbWorldmap.Height / 2)) //Cadran 3
            {
                horizontal = 'O';
                vertical = 'S';
            }
            else //Cadran 4
            {
                horizontal = 'E';
                vertical = 'S';
            }            

            return coords;
        }

        private double reverseNumber(double min, double max, double input)
        {
            return (max + min) - input;
        }
    }
}
