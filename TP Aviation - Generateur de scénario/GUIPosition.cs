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
            Console.WriteLine("X: " + e.X);
            Console.WriteLine("Y: " + e.Y);
        }

        private void convertPosToDegree(int x, int y)
        {

        }
    }
}
