using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    /// <summary>
    /// Contient une liste d'aréoports, qui eux meme contiennent une liste d'aeronefs.
    /// </summary>

    public class Scenario
    {
        static Scenario m_scenario; //Singleton scénario
        public List<Aeroport> listAreoport; //Liste d'areoport du scénario
        UsineAeronef usine; //Usine pour créer des aeronefs

        /// <summary>
        /// Constructeur d'un scénario. Intinie la liste d'aréoports et set l'usine a aeronefs
        /// </summary>
        Scenario()
        {
            listAreoport = new List<Aeroport>();
            usine = UsineAeronef.getUsineAeronef;
        }

        /// <summary>
        /// Singleton: Retourne l'usine, la crée si non initiée.
        /// </summary>
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

        /// <summary>
        /// Accesseur de la liste d'areoports
        /// </summary>
        /// <param name="index">Index de l'areoport qu'on veut.</param>
        /// <returns>Retourne l'areoport passé en index.</returns>
        public Aeroport this[int index]
        {
            get { return listAreoport[index]; }
            set { listAreoport.Add(value); }
        }

        /// <summary>
        /// Ajoute un aréoport a la liste.
        /// </summary>
        /// <param name="nom">Nom de l'aréoport</param>
        /// <param name="achalPass">Achalandage de passager de l'areoport</param>
        /// <param name="achalMarch">Achalandage de marchandise de l'areoport</param>
        /// <param name="position">La propriété Text contient une string de la pos DegreeMin, la propriété Tag contient la pos X et Y.</param>
        /// <returns></returns>
        public string ajoutAeroport(string nom, int achalPass, int achalMarch, TextBox position)
        {
            listAreoport.Add(new Aeroport(nom, achalPass, achalMarch, position));

            string areoport = listAreoport.Last().m_nom + "   |   (" + listAreoport.Last().m_localisation + ")   |   Achanlandage passager: " + listAreoport.Last().m_achalPassager + "   |   Achanlandage marchandise: " + listAreoport.Last().m_achalMarchandise;
            return areoport;
        }

        /// <summary>
        /// Ajoute un aeronef a l'areoport spécifié
        /// </summary>
        /// <param name="nom">Nom de l'avion</param>
        /// <param name="type">Type de l'avion</param>
        /// <param name="vitesse">Vitesse de l'avion</param>
        /// <param name="entretien">Temps d'entretien de l'avion</param>
        /// <param name="charger">Temps de chargement de l'avion</param>
        /// <param name="decharger">Temps de déchargement de l'avion</param>
        /// <param name="change">Parametre changant selon le type de l'avion (Capacité, rayon)</param>
        /// <param name="aeroports"></param>
        /// <returns></returns>
        public string ajouterAeronef(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change, string aeroports)
        {
            PositionGeo origine = null;

            int temp = 0;

            for (int i = 0; i < listAreoport.Count; i++)
            {
                if (listAreoport[i].m_nom == aeroports)
                {
                    origine = listAreoport[i].m_localisation;
                    temp = i;
                }
            }

            string areonef;
            string changement;
            listAreoport[temp][0] = usine.creerAvion(nom, type, vitesse, entretien, charger, decharger, change, origine);

            if ((type == "Passagers") | (type == "Marchandises"))
            {
                changement = "Capacité";
            }
            else
                changement = "Rayon";

            areonef = nom + "   |   (" + type + ")   |   Vitesse: " + vitesse + "   |   Temps d'entretien: " + entretien + "   |   Temps chargement: " + charger + "   |   Temps déchargement: " + decharger + "   |   " + changement + ": " + change;
            return areonef;
        }

        /// <summary>
        /// Permet la sérialisation XML du scénario
        /// </summary>
        public void SerializeScenario()
        {
            Stream stream;
            SaveFileDialog sfg = new SaveFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Aeroport>));

            sfg.InitialDirectory = @".\Scénarios\";
            sfg.Filter = "XML File (*.xml)|*.xml";

            if (sfg.ShowDialog() == DialogResult.OK)
            {
                if ((stream = sfg.OpenFile()) != null)
                {
                    serializer.Serialize(stream, this.listAreoport);
                    stream.Close();
                }
            }
        }
    }
}
