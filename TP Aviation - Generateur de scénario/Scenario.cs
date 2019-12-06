using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{

    public sealed class Scenario
    {
        static Scenario m_scenario;
        List<Aeroport> listAeroport;

        Scenario()
        {
            listAeroport = new List<Aeroport>();
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

            string areoport = listAeroport.Last().Nom + "   |   " + listAeroport.Last().Localisation + "   |   Achanlandage passager: " + listAeroport.Last().AchalPassager + "   |   Achanlandage marchandise: " + listAeroport.Last().AchalMarchandise;
            return areoport;
        }

        public void printAeroport(int index)
        {
            Console.WriteLine("Nom: " + listAeroport[index].Nom);
            Console.WriteLine("AchalPass: " + listAeroport[index].AchalPassager);
            Console.WriteLine("AchalMarch: " + listAeroport[index].AchalMarchandise);
            Console.WriteLine("Position: " + listAeroport[index].Localisation.ToString()); ;
        }

        public void ajouterAeronef(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change, string aeroports)
        {
            PositionGeo origine = null;
            UsineAeronef usine = UsineAeronef.getUsineAeronef;
            int temp = 0;

            for (int i = 0; i < listAeroport.Count; i++)
            {
                if (listAeroport[i].Nom == aeroports)
                {
                    origine = listAeroport[i].Localisation;
                    temp = i;
                }
            }

            listAeroport[temp][0] = usine.creerAvion(nom, type, vitesse, entretien, charger, decharger, change, origine);
        }
    }

}
