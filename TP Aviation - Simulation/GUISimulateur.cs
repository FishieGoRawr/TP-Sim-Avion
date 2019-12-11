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
        bool simulateurEnMarche;

        public GUISimulateur()
        {
            InitializeComponent();

            simulateurEnMarche = false;
            controller = new ControllerSimulateur(this);
            controller.abonnerOnHeureChanged(OnHeureAjoutee);

        }

        public void OnHeureAjoutee(string temps)
        {
            MethodInvoker invoker = delegate
            {
                lblHorloge.Text = temps;
                updateGUI();
            };

            this.Invoke(invoker);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            controller.changerStatusSpin();

            if (simulateurEnMarche)
                btnStart.Text = "Démarrer";
            else
                btnStart.Text = "Arrêter";

            simulateurEnMarche = !simulateurEnMarche;
        }

        private void BtnChargerScenario_Click(object sender, EventArgs e)
        {
            controller.deserialize();
            dessinerAreoports();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        public void updateGUI()
        {

        }

        private void dessinerAreoports()
        {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = currentContext.Allocate(pcbWorldmap.CreateGraphics(), pcbWorldmap.DisplayRectangle);

            Bitmap imgAreoport = Properties.Resources.airport;
            Bitmap map = Properties.Resources.worldmap_good;
            

            Graphics g = buffer.Graphics;
            g.DrawImage(map, 0, 0, map.Width, map.Height);

            int posX = 0, posY = 0;
            int[,] positionsAreoports = controller.obtenirPositionsAreoports();


            for (int i = 0; i < positionsAreoports.GetLength(0); i++)
            {
                posX = positionsAreoports[i, 0];
                posY = positionsAreoports[i, 1];

                Console.WriteLine($"X: {posX} | Y: {posY}");
                g.DrawImage(imgAreoport, posX - (35/2), posY - (35/2), 35, 35);
            }

            buffer.Render();
            buffer.Dispose();
            g.Dispose();
        }
    }
}
