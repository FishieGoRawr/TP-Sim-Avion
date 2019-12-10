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


        public void ajouterPassager()
        {
            foreach (var areoport in listAreoport)
            {
                usine.creerPassager(listAreoport, areoport);
            }
        }

        public void ajouterMarchandise()
        {
            foreach (var areoport in listAreoport)
            {
                usine.creerMarchandise(listAreoport, areoport);
            }
        }

        public void ajouterObservateur(int width, int height)
        {
            usine.creerObservateur(width, height);
        }

        public void ajouterFeu(int width, int height)
        {
            Random nbFeu = new Random();
            for (int i = 0; i < nbFeu.Next(1, 4); i++)
            {
                usine.creerFeu(width, height);
            }
        }

        public void ajouterSecours(int width, int height)
        {
            Random nbSecours = new Random();
            for (int i = 0; i < nbSecours.Next(1, 3); i++)
            {
                usine.creerSecours(width, height);
            }
        }
    }
}
