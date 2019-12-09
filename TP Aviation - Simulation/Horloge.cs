using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TP_Aviation___Simulation
{
    public class Horloge
    {
        System.Windows.Forms.Timer m_horloge;

        public Horloge()
        {
             
            m_horloge = new System.Windows.Forms.Timer();
            m_horloge.Interval = 15000;
            m_horloge.Tick += sendUpdatedTimeToGUI;
            m_horloge.Enabled = true;
            m_horloge.Start();
        }

        public void sendUpdatedTimeToGUI(object senders, EventArgs e)
        {
            Console.WriteLine(m_horloge.ToString());
        }

        public void convertirHorloge()
        {

        }

        public void changerVitesse()
        {

        }
    }
}
