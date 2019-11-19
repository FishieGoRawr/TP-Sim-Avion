using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{
    public class ControlleurGenerateur
    {
        Scenario scenario;

        public ControlleurGenerateur()
        {
            scenario = new Scenario();
        }

        public void creerAeroport(string nom, int achalPass, int achalMarch, string position)
        {
            scenario.ajoutAeroport(nom, achalPass, achalMarch, position);
        }

        public void creerAeronef(Aeroport aeroport)
        {

        }
    }
}
