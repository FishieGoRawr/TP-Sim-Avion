using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TP_Aviation___Simulation
{
    public delegate void HorlogeEventHandler(int[] tempsHeureMin);

    public class Horloge
    {
        Thread mainThread;
        MethodInvoker invoker;
        
        public event HorlogeEventHandler TempsChanged;

        int m_heures { get; set; }
        int m_minutes { get; set; }

        public Horloge()
        {
            m_heures = 0;
            m_minutes = 0;
        }

        protected virtual void HeureAjoutee()
        {
            int[] temps = new int[2];
            temps[0] = m_heures;
            temps[1] = m_minutes;

            TempsChanged(temps);
        }

        public void ajouteHeure()
        {
            m_heures++;
            HeureAjoutee();
        }

        public void ajouteMinutes()
        {
            if (m_minutes + 5 == 60)
            {
                ajouteHeure();
                m_minutes = 0;
            }
            else
                m_minutes += 5;

            HeureAjoutee();
        }
    }
}
