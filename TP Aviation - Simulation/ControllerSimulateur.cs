using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP_Aviation___Simulation
{
    public class ControllerSimulateur
    {
        Scenario m_scenario;
        Horloge m_horloge;
        GUISimulateur m_gui;
        bool m_simulateurEnMarche;
        Thread mainThread;

        public ControllerSimulateur(GUISimulateur p_gui)
        {
            m_scenario = Scenario.getScenario;
            m_horloge = new Horloge();
            m_gui = p_gui;
            m_simulateurEnMarche = false;

            mainThread = new Thread(new ThreadStart(spin));

            m_horloge.TempsChanged += m_gui.updateTimer;
        }

        //Exemple
        public void deserialize()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            XmlSerializer xs = new XmlSerializer(typeof(List<Areoport>));

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader rd = new StreamReader(ofd.FileName))
                {
                    List<Areoport> listTest = xs.Deserialize(rd) as List<Areoport>;
                }
            }

        }

        public void startSpin()
        {
            if (mainThread.IsAlive)
            {
                if (m_simulateurEnMarche)
                {
                    mainThread.Suspend();
                    m_simulateurEnMarche = false;
                }
                else
                {
                    mainThread.Resume();
                    m_simulateurEnMarche = true;
                }
            }
            else
            {
                mainThread.Start();
                m_simulateurEnMarche = true;
            }
        }

        public void spin()
        {
            while (m_simulateurEnMarche)
            {
                Thread.Sleep(1);
                m_horloge.ajouteMinutes();
            }
        }

        public void genererPassager()
        {
            m_scenario.ajouterPassager();
        }

        public void genererMarchandise()
        {
            m_scenario.ajouterMarchandise();
        }

        public void genererObservateur(int width, int height)
        {
            m_scenario.ajouterObservateur(width, height);
        }

        public void genererFeu(int width, int height)
        {
            m_scenario.ajouterFeu(width, height);
        }

        public void genererSecours(int width, int height)
        {
            m_scenario.ajouterSecours(width, height);
        }
    }
}
