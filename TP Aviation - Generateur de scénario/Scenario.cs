using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{

    class Scenario
    {
        static Scenario m_scenario;
        public List<Aeroport> listAeroport;
        UsineAeronef usine;

        Scenario()
        {
            listAeroport = new List<Aeroport>();
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

        public Aeroport this[int index]
        {
            get { return listAeroport[index]; }
            set { listAeroport.Add(value); }
        }

        public string ajoutAeroport(string nom, int achalPass, int achalMarch, string position)
        {
            listAeroport.Add(new Aeroport(nom, achalPass, achalMarch, position));

            string areoport = listAeroport.Last().Nom + "   |   (" + listAeroport.Last().Localisation + ")   |   Achanlandage passager: " + listAeroport.Last().AchalPassager + "   |   Achanlandage marchandise: " + listAeroport.Last().AchalMarchandise;
            return areoport;
        }

        public void printAeroport(int index)
        {
            Console.WriteLine("Nom: " + listAeroport[index].Nom);
            Console.WriteLine("AchalPass: " + listAeroport[index].AchalPassager);
            Console.WriteLine("AchalMarch: " + listAeroport[index].AchalMarchandise);
            Console.WriteLine("Position: " + listAeroport[index].Localisation.ToString()); ;
        }

        public string ajouterAeronef(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change, string aeroports)
        {
            PositionGeo origine = null;
            
            int temp = 0;

            for (int i = 0; i < listAeroport.Count; i++)
            {
                if (listAeroport[i].Nom == aeroports)
                {
                    origine = listAeroport[i].Localisation;
                    temp = i;
                }
            }

            string areonef;
            string changement;
            listAeroport[temp][0] = usine.creerAvion(nom, type, vitesse, entretien, charger, decharger, change, origine);

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

            StringBuilder output = new StringBuilder();
            StringWriter writer = new StringWriter(output);

            listAeroport.Add(new Aeroport());

            //listAeroport[0][0] = usine.creerAvion("null", "Passagers", 0, 0, 0, 0, 0, new PositionGeo());
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Aeroport>));
            serializer.Serialize(writer, this.listAeroport);

            Console.WriteLine(output.ToString());
        }
    }

}
