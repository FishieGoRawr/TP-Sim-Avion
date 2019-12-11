using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{
    /// <summary>
    /// L'usine permet la création d'aeronefs
    /// </summary>

    public sealed class UsineAeronef
    {
        private static UsineAeronef m_usineAeronef = null; //Singleton de l'usine

        /// <summary>
        /// Constructeur vide de l'usine
        /// </summary>
        UsineAeronef()
        {
        }

        /// <summary>
        /// Crée un nouvel usine si non existant, sinon, retourne l'instance de l'usine
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
        /// Crée un aeronef avec les parametres voulu.
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="type">Type de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretient de l'aeronef</param>
        /// <param name="charger">Temps de chargement de l'aeronef</param>
        /// <param name="decharger">Temps de déchargement de l'aeronef</param>
        /// <param name="change">Parametre qui change selon le type (Capacité, rayon)</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
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
