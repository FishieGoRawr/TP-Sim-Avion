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

        private void PcbWorldmap_MouseClick(object sender, MouseEventArgs e)
        {
            string coordString = "";
            coordString = convertPosToMinSec(e.X, e.Y);

            guigen.changerValeurPosition(coordString, e.X, e.Y);
            this.Dispose();
        }

        private string convertPosToMinSec(double x, double y)
        {
            string coords = "";

            double degFromMidX = Math.Abs(x - pcbWorldmap.Width / 2);
            double horizontalDegree = (degFromMidX * 360) / pcbWorldmap.Width;
            double horizontalMin = (horizontalDegree - Math.Floor(horizontalDegree)) * 60;

            double degFromMidY = Math.Abs(y - pcbWorldmap.Height / 2);
            double verticalDegree = (degFromMidY * 180) / pcbWorldmap.Height;
            double verticalMin = (verticalDegree - Math.Floor(verticalDegree)) * 60;

            if (x < (pcbWorldmap.Width / 2) && y < (pcbWorldmap.Height / 2)) //Cadran 1
                coords = $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)}' N, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)}' O";
            else if (x > (pcbWorldmap.Width / 2) && y < (pcbWorldmap.Height / 2)) //Cadran 2
                coords = $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)}' N, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)}' E";
            else if (x < (pcbWorldmap.Width / 2) && y > (pcbWorldmap.Height / 2)) //Cadran 3
                coords = $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)}' S, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)}' O";
            else //Cadran 4
                coords = $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)}' S, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)}' E";
            
            return coords;
        }
    }
}