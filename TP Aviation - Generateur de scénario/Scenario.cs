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
        static Scenario m_scenario;
        public List<Areoport> listAreoport;
        UsineAeronef usine;

        Scenario()
        {
            listAreoport = new List<Areoport>();
            usine = UsineAeronef.getUsineAeronef;
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

        public Areoport this[int index]
        {
            get { return listAreoport[index]; }
            set { listAreoport.Add(value); }
        }

        public string ajoutAeroport(string nom, int achalPass, int achalMarch, TextBox position)
        {
            listAreoport.Add(new Areoport(nom, achalPass, achalMarch, position));

            string areoport = listAreoport.Last().m_nom + "   |   (" + listAreoport.Last().m_localisation + ")   |   Achanlandage passager: " + listAreoport.Last().m_achalPassager + "   |   Achanlandage marchandise: " + listAreoport.Last().m_achalMarchandise;
            return areoport;
        }

        public void printAeroport(int index)
        {
            Console.WriteLine("Nom: " + listAreoport[index].m_nom);
            Console.WriteLine("AchalPass: " + listAreoport[index].m_achalPassager);
            Console.WriteLine("AchalMarch: " + listAreoport[index].m_achalMarchandise);
            Console.WriteLine("Position: " + listAreoport[index].m_localisation.ToString()); ;
        }

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

        public void SerializeScenario()
        {
            Stream stream;
            SaveFileDialog sfg = new SaveFileDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Areoport>));

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

        public void DeserializeScenario()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @".\Scénarios\";
            ofd.Filter = "XML File (*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Areoport>));
                using (StreamReader rd = new StreamReader(ofd.FileName))
                {
                    
                    List<Areoport> listTest = xs.Deserialize(rd) as List<Areoport> ;
                }
            }
        }
    }
}
