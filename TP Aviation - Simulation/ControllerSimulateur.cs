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
            m_simulateurEnMarche = true;

            mainThread = new Thread(new ThreadStart(spin));

            m_horloge.TempsChanged += m_gui.updateTimer;
        }

        //Exemple
        public void deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ControllerSimulateur));
            using (StreamReader rd = new StreamReader("person.xml"))
            {
                ControllerSimulateur p = xs.Deserialize(rd) as ControllerSimulateur;
            }
        }

        public void startSpin()
        {
            if (!mainThread.IsAlive)
                mainThread.Start();

        }

        public void spin()
        {

            while (m_simulateurEnMarche)
            {
                Thread.Sleep(1);
                m_horloge.ajouteMinutes();
            }
        }

        public void updateTimerGUI(int[] temps)
        {

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
