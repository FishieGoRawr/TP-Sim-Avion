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
        public GUIPosition()
        {
            InitializeComponent();
        }

        private void PcbWorldmap_MouseClick(object sender, MouseEventArgs e)
        {
            convertPosToDegree(e.X, e.Y);

        }

        private void convertPosToDegree(double x, double y)
        {
            double lon, lat;

            if (x < (pcbWorldmap.Width / 2))
                lon = (reverseNumber(0,180, (x * 180) / 1000)) * -1;
            else
                lon = (x * 180) / 1000;

            if (y < pcbWorldmap.Height / 2)
                lat = reverseNumber(0,90, (y * 90) / 249.5) ;
            else
                lat = reverseNumber(0, 90, (y * 90) / 249.5);

            Console.WriteLine("Lon: " + lon);
            Console.WriteLine("Lat: " + lat);
        }

        private double reverseNumber(double min, double max, double input)
        {
            return (max + min) - input;
        }

        private void GUIPosition_Load(object sender, EventArgs e)
        {

        }
    }
}
