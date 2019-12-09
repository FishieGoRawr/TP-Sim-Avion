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
        static System.Windows.Forms.Timer m_horloge;

        public GUISimulateur()
        {
            InitializeComponent();
            m_horloge = new System.Windows.Forms.Timer();

            m_horloge.Tick += new EventHandler(updateTimer);
            m_horloge.Interval = 1;
            m_horloge.Start();
            //controller = new ControllerSimulateur();
        }

        private static void updateTimer(object sender, EventArgs e)
        {
            string[] horloge = Program.m_gui.lblHorloge.Text.Split(':');
            int heures = Convert.ToInt32(horloge[0]);
            int secondes = Convert.ToInt32(horloge[1]);

            if (secondes + 15 >= 60)
            {
                heures++;
                secondes = 0;
            }
            else
                secondes += 15;

            if (heures <= 9)
            {
                if (secondes == 0)
                    Program.m_gui.lblHorloge.Text = ($"0{heures} : 0{secondes}");
                else
                    Program.m_gui.lblHorloge.Text = ($"0{heures} : {secondes}");
            }
            else
            {
                if (secondes == 0)
                    Program.m_gui.lblHorloge.Text = ($"{heures} : 0{secondes}");
                else
                    Program.m_gui.lblHorloge.Text = ($"{heures} : {secondes}");
            }               
            

            Console.Clear();
            Console.WriteLine("{0}:{1}", heures, secondes);
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
