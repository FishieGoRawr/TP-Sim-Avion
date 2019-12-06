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
            scenario = Scenario.getScenario;
        }

        public string creerAeroport(string nom, int achalPass, int achalMarch, string position)
        {
            string areoport;
            areoport = scenario.ajoutAeroport(nom, achalPass, achalMarch, position);

            return areoport;
        }

        public void creerAeronef(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change, string aeroports)
        {
            scenario.ajouterAeronef(nom, type, vitesse, entretien, charger, decharger, change, aeroports);
        }
    }
}
