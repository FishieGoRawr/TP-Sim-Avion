using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TP_Aviation___Simulation
{
    public delegate void HorlogeEventHandler(string temps);

    public class Horloge
    {
        Thread mainThread;
        MethodInvoker invoker;

        public event HorlogeEventHandler TempsChanged;

        public int m_heures { get; set; }
        public int m_minutes { get; set; }

        public Horloge()
        {
            m_heures = 0;
            m_minutes = 0;
        }

        protected virtual void HeureAjoutee()
        {
            TempsChanged(this.ToString());
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

        public override string ToString()
        {
            string temps = "";

            if (m_heures < 10)
            {
                if (m_minutes < 10)
                    temps = $"0{m_heures} : 0{m_minutes}";
                else
                    temps = $"0{m_heures} : {m_minutes}";
            }
            else
            {
                if (m_minutes < 10)
                    temps = $"{m_heures} : 0{m_minutes}";
                else
                    temps = $"{m_heures} : {m_minutes}";
            }

            return temps;
        }
    }
}
