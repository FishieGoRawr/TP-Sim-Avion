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
    /// Classe parent de tout les types d'avions
    /// </summary>

    [XmlInclude(typeof(AeroPassager))]
    [XmlInclude(typeof(AeroMarchandise))]
    [XmlInclude(typeof(AeroObservateur))]
    [XmlInclude(typeof(AeroSecours))]
    [XmlInclude(typeof(AeroIncendie))]
    public class Aeronef
    {
        public String m_nom { get; set; } //Nom de l'aeronef
        public String m_type { get; set; } //Type de l'aeronef
        public int m_vitesse { get; set; } //Vitesse de l'aeronef
        public int m_tempsEnt { get; set; } //Temps d'entretient de l'aeronef
        public PositionGeo m_localisation { get; set; } //Localisation d'origine de l'aeronef
        public PositionGeo m_origine { get; set; } //Localisation d'origine de l'aeronef

        /// <summary>
        /// Constructeur d'aeronef.
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
        /// <param name="type">Type de l'areonef</param>
        public Aeronef(string nom, string type, int vitesse, int entretien, PositionGeo origine)
        {
            this.m_nom = nom;
            this.m_type = type;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_localisation = null;
            this.m_origine = origine;
        }

        /// <summary>
        /// Constructeur vide d'aeronef.
        /// </summary>
        public Aeronef()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_localisation = new PositionGeo();
            m_origine = new PositionGeo();
        }
    }
}
