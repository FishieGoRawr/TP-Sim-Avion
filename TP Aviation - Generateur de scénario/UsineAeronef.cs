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

        /// <summary>
        /// Cosntructeur de l'usine
        /// </summary>
        UsineAeronef()
        {
        }

        /// <summary>
        /// Appelle de l'usine par les autres classes, si non initialiser il se crée lui-même
        /// </summary>
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

        /// <summary>
        /// Crée un nouvel aéronef, selon le type reçu et avec bonnes les informations
        /// </summary>
        /// <param name="nom">Nom de l'aéronef</param>
        /// <param name="type">Type de l'aéronef</param>
        /// <param name="vitesse">Vitesse de l'aéronef</param>
        /// <param name="entretien">Temps de maintenance de l'aéronef</param>
        /// <param name="charger">Temps de débarquement de l'aéronef</param>
        /// <param name="decharger">Temps d'embarquement de l'aéronef</param>
        /// <param name="change">Nombre qui représente la capacité ou le rayon de l'aéronef selon le type</param>
        /// <param name="origine">Position d'origine de l'aéronef, qui est la position de l'aéroport</param>
        /// <returns></returns>
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
