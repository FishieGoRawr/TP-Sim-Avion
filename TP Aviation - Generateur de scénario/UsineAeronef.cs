using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{
    public sealed class UsineAeronef
    {
        private static UsineAeronef m_usineAeronef = null;

        UsineAeronef()
        {
        }

        public static UsineAeronef getUsineAeronef
        {
            get
            {
                if (m_usineAeronef == null)
                {
                    m_usineAeronef = new UsineAeronef();
                }
                return m_usineAeronef;
            }
        }

        public Aeronef creerAvion(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change, PositionGeo origine)
        {
            Aeronef newAeronef = null;
            switch (type)
            {
                case "Passagers" :
                    newAeronef = new AeroPassager(nom, type, vitesse, entretien, origine, charger, decharger, change);
                    break;
                case "Marchandises" :
                    newAeronef = new AeroMarchandise(nom, type, vitesse, entretien, origine, charger, decharger, change);
                    break;
                case "Observateurs" :
                    newAeronef = new AeroObservateur(nom, type, vitesse, entretien, origine, 1, change);
                    break;
                case "Incendies" :
                    newAeronef = new AeroIncendie(nom, type, vitesse, entretien, origine);
                    break;
                case "Secours" :
                    newAeronef = new AeroSecours(nom, type, vitesse, entretien, origine, 1);
                    break;
                default:
                    break;
            }

            return newAeronef;
        }
    }
}
