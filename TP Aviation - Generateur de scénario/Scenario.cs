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
    public class Scenario
    {
        static Scenario m_scenario; //Singleton scénario
        public List<Aeroport> listAreoport; //Liste d'areoport du scénario
        UsineAeronef usine; //Usine pour créer des aeronefs

        /// <summary>
        /// Constructeur d'un scénario
        /// </summary>
        Scenario()
        {
            listAreoport = new List<Aeroport>();
            usine = UsineAeronef.getUsineAeronef;
        }

        /// <summary>
        /// Constructeur vide d'un scénario
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
        /// Ascesseur de l'aréoport a l'indice dans la liste d'aréoports
        /// </summary>
        /// <param name="index">Indice dans la liste</param>
        /// <returns></returns>
        public Aeroport this[int index]
        {
            get { return listAreoport[index]; }
            set { listAreoport.Add(value); }
        }

        /// <summary>
        /// Ajoute un aéroport au scnénario
        /// </summary>
        /// <param name="nom">Nom de l'aéroport</param>
        /// <param name="achalPass">Indice d'achalandage de passagers de l'aéroport</param>
        /// <param name="achalMarch">Indice d'achalandage de marchandises de l'aéroport</param>
        /// <param name="position">Posiition géographique de l'aéroport</param>
        /// <returns></returns>
        public string ajoutAeroport(string nom, int achalPass, int achalMarch, TextBox position)
        {
            listAreoport.Add(new Aeroport(nom, achalPass, achalMarch, position));

            string areoport = listAreoport.Last().m_nom + "   |   (" + listAreoport.Last().m_localisation + ")   |   Achanlandage passager: " + listAreoport.Last().m_achalPassager + "   |   Achanlandage marchandise: " + listAreoport.Last().m_achalMarchandise;
            return areoport;
        }

        /// <summary>
        /// Ajoute un aéronef dans l'aéroport sélectionner
        /// </summary>
        /// <param name="nom">Nom de l'aéronef</param>
        /// <param name="type">Type de l'aéronef</param>
        /// <param name="vitesse">Vitesse de l'aéronef</param>
        /// <param name="entretien">Temps de maintenance de l'aéronef</param>
        /// <param name="charger">Temps d'embarquement de l'aéronef</param>
        /// <param name="decharger">Temps de débarquement de l'aéronef</param>
        /// <param name="change">Nombre qui représente la capacité ou le rayon de l'aéronef selon le type</param>
        /// <param name="aeroports">Nom de l'aéroport de l'aéronef</param>
        /// <returns>Retourne l'aéronef avec ses informations sous forme de texte</returns>
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


            //Transforme l'aéronef sous forme de texte
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
        /// Sérialise le scénario dans le fichier
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

        /// <summary>
        /// Désérialise un scnénario à partir d'un fichier sélectionner
        /// </summary>
        public void DeserializeScenario()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @".\Scénarios\";
            ofd.Filter = "XML File (*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Aeroport>));
                using (StreamReader rd = new StreamReader(ofd.FileName))
                {                    
                    List<Aeroport> listTest = xs.Deserialize(rd) as List<Aeroport> ;
                }
            }
        }
    }
}
