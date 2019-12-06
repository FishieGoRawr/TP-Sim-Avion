using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{

    public sealed class Scenario
    {
        List<Aeroport> listAeroport;

        Scenario()
        {
            listAeroport = new List<Aeroport>();
        }

        public Aeroport this[int index]
        {
            get { return listAeroport[index]; }
            set { listAeroport.Add(value); }
        }

        public void ajoutAeroport(string nom, int achalPass, int achalMarch, string position)
        {
            listAeroport.Add(new Aeroport(nom, achalPass, achalMarch, position));
            printAeroport(0);
        }

        public void printAeroport(int index)
        {
            Console.WriteLine("Nom: " + listAeroport[index].Nom);
            Console.WriteLine("AchalPass: " + listAeroport[index].AchalPassager);
            Console.WriteLine("AchalMarch: " + listAeroport[index].AchalMarchandise);
            Console.WriteLine("Position: " + listAeroport[index].Localisation.ToString()); ;
        }

        public void ajouterAeronef(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change)
        {
            UsineAeronef usine = UsineAeronef.getUsineAeronef;
            usine.creerAvion(nom, type, vitesse, entretien, charger, decharger, change);
        }
    }

}
