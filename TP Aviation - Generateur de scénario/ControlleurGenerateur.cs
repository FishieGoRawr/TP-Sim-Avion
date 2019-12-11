using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aviation___Generateur_de_scénario
{
    /// <summary>
    /// Controlleur du générateur, permet de creer des areoports, ajouté des avions au areoports, serialiser le scenario, etc...
    /// </summary>
    
    public class ControlleurGenerateur
    {
        Scenario scenario; //Scénario à modifier

        /// <summary>
        /// Constructeur du controlleur de générateur
        /// </summary>
        public ControlleurGenerateur()
        {
            scenario = Scenario.getScenario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="achalPass"></param>
        /// <param name="achalMarch"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public string creerAeroport(string nom, int achalPass, int achalMarch, TextBox position)
        {
            string areoport;
            areoport = scenario.ajoutAeroport(nom, achalPass, achalMarch, position);

            return areoport;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="type"></param>
        /// <param name="vitesse"></param>
        /// <param name="entretien"></param>
        /// <param name="charger"></param>
        /// <param name="decharger"></param>
        /// <param name="change"></param>
        /// <param name="aeroports"></param>
        /// <returns>Retourne l'aeronef creer</returns>
        public string creerAeronef(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change, string aeroports)
        {
            string areonef;
            areonef = scenario.ajouterAeronef(nom, type, vitesse, entretien, charger, decharger, change, aeroports);
            return areonef;
        }

        /// <summary>
        /// Enregistre le scenario dans un fichier
        /// </summary>
        public void serializeScenario()
        {
            scenario.SerializeScenario();
        }

        /// <summary>
        /// Génére un scénario selon le fichier choisi
        /// </summary>
        public void deserializeScenario()
        {
            scenario.DeserializeScenario();
        }
    }
}
