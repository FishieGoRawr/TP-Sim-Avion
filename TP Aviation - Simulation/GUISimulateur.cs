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
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            controller.genererPassager();
            controller.genererMarchandise();
            controller.genererObservateur(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererFeu(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererSecours(pcbWorldmap.Width, pcbWorldmap.Height);
        }

        public int[] obtenirTailleCarte()
        {
            int[] temp = new int[2];
            temp[0] = pcbWorldmap.Width;
            temp[1] = pcbWorldmap.Height;

            return temp;
        }

        public void updateGUI()
        {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = currentContext.Allocate(pcbWorldmap.CreateGraphics(), pcbWorldmap.DisplayRectangle);
            Graphics g = buffer.Graphics;
            Bitmap img;

            //AREOPORTS
            img = new Bitmap(Properties.Resources.worldmap_good);
            g.DrawImage(img, 0, 0, img.Width, img.Height);
            img.Dispose();

            int posX = 0, posY = 0;
            int[,] positionsAreoports = controller.obtenirPositionsAreoports();

            using (img = new Bitmap(Properties.Resources.airport))
            {
                for (int i = 0; i < positionsAreoports.GetLength(0); i++)
                {
                    posX = positionsAreoports[i, 0];
                    posY = positionsAreoports[i, 1];

                    g.DrawImage(img, posX - (35 / 2), posY - (35 / 2), 35, 35);
                }
            }
            img.Dispose();

            //CLIENTS
            List<string> listPositionsClients = controller.obtenirPositionsClients();

            foreach (string client in listPositionsClients)
            {
                string[] clientSplit = client.Split(' ');

                if (clientSplit[0] == "Feu")
                {
                    using (img = new Bitmap(Properties.Resources.feu))
                        g.DrawImage(img, Convert.ToInt32(clientSplit[1]), Convert.ToInt32(clientSplit[2]), 35, 35);
                }
                else if (clientSplit[0] == "Observateur")
                {
                    using (img = new Bitmap(Properties.Resources.jumelle))
                        g.DrawImage(img, Convert.ToInt32(clientSplit[1]), Convert.ToInt32(clientSplit[2]), 35, 35);
                }
                else if (clientSplit[0] == "Secours")
                {
                    using (img = new Bitmap(Properties.Resources.secours))
                        g.DrawImage(img, Convert.ToInt32(clientSplit[1]), Convert.ToInt32(clientSplit[2]), 35, 35);
                }

                img.Dispose();
            }

            buffer.Render();
            buffer.Dispose();
            g.Dispose();
            GC.Collect();
        }

        public void enableStartButton()
        {
            btnStart.Enabled = true;
        }
    }
}
