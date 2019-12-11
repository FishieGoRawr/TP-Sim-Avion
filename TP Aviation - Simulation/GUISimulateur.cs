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
            updateGUI();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            controller.genererObservateur(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererFeu(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererSecours(pcbWorldmap.Width, pcbWorldmap.Height);
        }

        public void updateGUI()
        {
            Bitmap img = Properties.Resources.worldmap_good;
            BufferedGraphicsContext currentContext;
            BufferedGraphics buffer;

            currentContext = BufferedGraphicsManager.Current;
            buffer = currentContext.Allocate(pcbWorldmap.CreateGraphics(), pcbWorldmap.DisplayRectangle);

            
            

            //MAP
            Graphics g = buffer.Graphics;
            g.DrawImage(img, 0, 0, img.Width, img.Height);

            //AÉROPORTS
            img = new Bitmap(Properties.Resources.airport);
            //int[,] pos = controller.obtenirPositionsAreoports();
            for (int i = 0; i < controller.m_scenario.listAreoport.Count; i++)
            {
                //g.DrawImage(img, controller.m_scenario.listAreoport[i].Localisation.m_posX / 2, controller.m_scenario.listAreoport[i].Localisation.m_posY / 2, 35, 35);
                //g.DrawImage(img, pos[i, 0] - (35 / 2), pos[i, 1] - (35 / 2), 35, 35);
                //img.Dispose();
            }

            ////CLIENTS
            List<string> listPositionsClients = controller.obtenirPositionsClients();

            foreach (string client in listPositionsClients)
            {
                string[] clientSplit = client.Split(' ');

                if (clientSplit[0] == "Feu")
                {
                    //using (Bitmap img = new Bitmap(Properties.Resources.feu))
                    img = new Bitmap(Properties.Resources.feu);
                }
                else if (clientSplit[0] == "Observateur")
                {
                    //using (Bitmap img = new Bitmap(Properties.Resources.jumelle))
                    img = new Bitmap(Properties.Resources.jumelle);
                }
                else if (clientSplit[0] == "Secours")
                {
                    //using (Bitmap img = new Bitmap(Properties.Resources.secours))
                    img = new Bitmap(Properties.Resources.secours);
                }

                g.DrawImage(img, Convert.ToInt32(clientSplit[1]) - (15/2), Convert.ToInt32(clientSplit[2]) - (15/2), 15, 15);
                img.Dispose();
            }

            buffer.Render();
            buffer.Dispose();
            g.Dispose();
            GC.Collect();
        }

        public int[] obtenirTalleMap()
        {
            int[] temp = new int[2];
            temp[0] = pcbWorldmap.Width;
            temp[1] = pcbWorldmap.Height;
            return temp;
        }
    }
}
