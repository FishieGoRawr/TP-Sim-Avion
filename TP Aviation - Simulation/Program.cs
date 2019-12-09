using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aviation___Simulation
{
    static class Program
    {
        public static GUISimulateur m_gui;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(m_gui = new GUISimulateur());
        }
    }
}
