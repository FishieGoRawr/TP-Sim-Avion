using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP_Aviation___Simulation
{
    class ControllerSimulateur
    {
        Scenario m_scenario;
        Horloge m_horloge;

        public ControllerSimulateur()
        {
            this.m_scenario = Scenario.getScenario;
            //this.m_horloge = new Horloge();
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

        public void spin()
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
