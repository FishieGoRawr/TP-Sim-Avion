using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aviation___Generateur_de_scénario
{
    public class ControlleurGenerateur
    {
        Scenario scenario;

        public ControlleurGenerateur()
        {
            scenario = Scenario.getScenario;
        }

        public string creerAeroport(string nom, int achalPass, int achalMarch, TextBox position)
        {
            string areoport;
            areoport = scenario.ajoutAeroport(nom, achalPass, achalMarch, position);

            return areoport;
        }

        public string creerAeronef(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change, string aeroports)
        {
            string areonef;
            areonef = scenario.ajouterAeronef(nom, type, vitesse, entretien, charger, decharger, change, aeroports);
            return areonef;
        }

        public void serializeScenario()
        {
            scenario.SerializeScenario();
        }

        public void deserializeScenario()
        {
            scenario.DeserializeScenario();
        }
    }
}
