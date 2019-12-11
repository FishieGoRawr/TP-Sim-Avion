using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    /// <summary>
    /// Rajoute tempsEmb et tempsDeb a un aeronef
    /// </summary>

    public abstract class Transport : Aeronef
    {
        public int m_tempsEmb { get; set; } //Temps d'embarquement
        public int m_tempsDeb { get; set; } //Temps de débarquement

        /// <summary>
        /// Constructeur d'un Transport
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="type">Type de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Position d'origine de l'aeronef</param>
        /// <param name="charger">Temps de chargement de l'aeronef</param>
        /// <param name="decharger">Temps de déchargement de l'aeronef</param>
        public Transport(string nom, string type, int vitesse, int entretien, PositionGeo origine, int charger, int decharger) : base(nom, type, vitesse, entretien, origine)
        {

        }

        /// <summary>
        /// Constructeur vide d'un Transport
        /// </summary>
        public Transport()
        {

        }
    }
}
