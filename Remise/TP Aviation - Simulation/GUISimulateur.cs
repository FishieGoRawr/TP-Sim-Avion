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

        /// <summary>
        /// Constructeur du GUISimulateur
        /// </summary>
        public GUISimulateur()
        {
            InitializeComponent();

            simulateurEnMarche = false;
            controller = new ControllerSimulateur(this);
            controller.abonnerOnHeureChanged(OnHeureAjoutee);
            controller.deserialize();
        }

        /// <summary>
        /// Event lorsque le temps change.
        /// </summary>
        /// <param name="temps">Temps de l'horloge</param>        
        public void OnHeureAjoutee(string temps)
        {
            MethodInvoker invoker = delegate
            {
                lblHorloge.Text = temps;
                updateGUI();
            };

            this.Invoke(invoker);
        }

        /// <summary>
        /// EventHandler du bouton "BtnStart" lors d'un click. Permet de stopper et de continuer la simulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            controller.changerStatusSpin();

            if (simulateurEnMarche)
                btnStart.Text = "Démarrer";
            else
                btnStart.Text = "Arrêter";

            simulateurEnMarche = !simulateurEnMarche;
        }
        
        /// <summary>
        /// Permet de changer le scénario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChargerScenario_Click(object sender, EventArgs e)
        {
            controller.deserialize();
            updateGUI();
        }
        
        /// <summary>
        /// Ajoute des clients sur demande, on le laisse au cas ou.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            controller.genererObservateur(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererFeu(pcbWorldmap.Width, pcbWorldmap.Height);
            controller.genererSecours(pcbWorldmap.Width, pcbWorldmap.Height);
        }
        
        /// <summary>
        /// Permet d'actualiser le GUI avec tout les items nécessaire.
        /// </summary>
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
            foreach (Aeroport aeroport in controller.m_scenario.listAreoport)
            {
                img = new Bitmap(Properties.Resources.airport);
                int areoPosX = aeroport.Localisation.PosX - (35 / 2);
                int areoPosY = aeroport.Localisation.PosY - (35 / 2);

                g.DrawImage(img, areoPosX, areoPosY, 35, 35);
                img.Dispose();
            }

            ////CLIENTS
            List<string> listPositionsClients = controller.obtenirPositionsClients();

            foreach (string client in listPositionsClients)
            {
                string[] clientSplit = client.Split(' ');

                if (clientSplit[0] == "Feu")
                    img = new Bitmap(Properties.Resources.feu);
                else if (clientSplit[0] == "Observateur")
                    img = new Bitmap(Properties.Resources.jumelle);
                else if (clientSplit[0] == "Secours")
                    img = new Bitmap(Properties.Resources.secours);

                g.DrawImage(img, Convert.ToInt32(clientSplit[1]) - (15 / 2), Convert.ToInt32(clientSplit[2]) - (15 / 2), 15, 15);
                img.Dispose();
            }

            //AVIONS
            foreach (Aeroport airport in controller.m_scenario.listAreoport)
            {
                foreach (Aeronef avion in airport.m_listAeronef)
                {
                    if (!avion.Dispo)
                    {
                        if (avion.Type == "Passagers")
                        {
                            img = new Bitmap(Properties.Resources.passager);
                            g.DrawImage(img, avion.Localisation.PosX, avion.Localisation.PosY, 25, 25);
                            img.Dispose();
                        }
                    }

                }
            }

            buffer.Render();
            buffer.Dispose();
            g.Dispose();
            GC.Collect();
        }
        
        /// <summary>
        /// Obtient la taille de la carte
        /// </summary>
        /// <returns></returns>
        public int[] obtenirTalleMap()
        {
            int[] temp = new int[2];
            temp[0] = pcbWorldmap.Width;
            temp[1] = pcbWorldmap.Height;
            return temp;
        }
    }
}
