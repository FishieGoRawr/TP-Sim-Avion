using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    public class AeroPassager : Transport
    {
        int m_capacite { get; set; }
        [XmlIgnore]
        Bitmap m_image;

        /// <summary>
        /// Constructeur d'AeroPassager
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
        /// <param name="charger">Temps pour charger l'aeronef</param>
        /// <param name="decharger">Temps pour decharger l'aeronef</param>
        /// <param name="change">Capacité de passager de l'aeronef</param>
        /// <param name="type">Type de l'areonef</param>
        public AeroPassager(string nom, string type, int vitesse, int entretien, PositionGeo origine, int charger, int decharger, int change) : base(nom, type, vitesse, entretien, origine, charger, decharger)
        {

            this.m_nom = nom;
            this.m_type = type;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_tempsEmb = charger;
            this.m_tempsDeb = decharger;
            this.m_capacite = change;
            this.m_image = Properties.Resources.passager;
        }

        /// <summary>
        /// Constructeur vide pour AeroPassager
        /// </summary>
        public AeroPassager() : base()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_origine = new PositionGeo();
            m_tempsEmb = 0;
            m_tempsDeb = 0;
            m_capacite = 0;
            m_image = null;
        }
    }
}
