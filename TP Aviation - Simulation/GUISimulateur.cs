using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aviation___Simulation
{
    public partial class GUISimulateur : Form
    {
        ControllerSimulateur controller;

        public GUISimulateur()
        {
            InitializeComponent();
            controller = new ControllerSimulateur();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            controller.genererPassager();
            controller.genererMarchandise();
            controller.genererObservateur(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererFeu(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererSecours(pcbWorldmap.Width, pcbWorldmap.Height);
        }
    }
}
