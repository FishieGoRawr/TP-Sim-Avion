using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            controller = new ControllerSimulateur(this);
        }

        public void updateTimer(int[] temps)
        {
            MethodInvoker invoker = delegate
            {
                int heures = temps[0];
                int minutes = temps[1];

                if (heures < 10)
                {
                    if (minutes < 10)
                        lblHorloge.Text = $"0{heures} : 0{minutes}";
                    else
                        lblHorloge.Text = $"0{heures} : {minutes}";
                }
                else
                {
                    if (minutes < 10)
                        lblHorloge.Text = $"{heures} : 0{minutes}";
                    else
                        lblHorloge.Text = $"{heures} : {minutes}";
                }

                this.Refresh();
            };

            this.Invoke(invoker);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            controller.startSpin();
        }

        private void BtnChargerScenario_Click(object sender, EventArgs e)
        {
            controller.deserialize();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            controller.genererPassager();
            controller.genererMarchandise();
            controller.genererObservateur(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererFeu(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererSecours(pcbWorldmap.Width, pcbWorldmap.Height);
        }
    }
}
