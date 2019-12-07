using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Scenario
    {
        static Scenario m_scenario;
        public List<Areoport> listAreoport;
        UsineClient usine;

        Scenario()
        {
            listAreoport = new List<Areoport>();
            usine = UsineClient.getUsineClient;
        }

        public static Scenario getScenario
        {
            get
            {
                if (m_scenario == null)
                {
                    m_scenario = new Scenario();
                }
                return m_scenario;
            }
        }
    }
}
