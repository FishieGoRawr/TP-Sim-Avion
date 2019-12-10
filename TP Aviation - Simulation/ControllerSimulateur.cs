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
        GUISimulateur m_gui;

        public ControllerSimulateur(GUISimulateur p_gui)
        {
            m_scenario = Scenario.getScenario;
            m_gui = p_gui;
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
                    m_scenario.Liste = xs.Deserialize(rd) as List<Areoport>;
                }
            }

        }

        public void changerStatusSpin()
        {
            m_scenario.changerStatusSpin();
        }

        public void abonnerOnHeureChanged(HorlogeEventHandler handler)
        {
            m_scenario.abonnerOnHeureChanged(handler);
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
