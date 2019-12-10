using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    public class AeroObservateur : Distance
    {
        [XmlIgnore]
        Bitmap m_image;
        int m_rayon { get; set; }

        /// <summary>
        /// Constructeur complex d'AeroObservateur
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
        /// <param name="nbAller">Nombre d'aller que l'aeronef fait</param>
        /// <param name="rayon">Rayon d'un tour complet de l'aeronef</param>
        /// <param name="type">Type de l'areonef</param>
        public AeroObservateur(string nom, string type, int vitesse, int entretien, PositionGeo origine, int nbAller, int rayon) : base(nom, type, vitesse, entretien, origine)
        {
            this.m_nom = nom;
            this.m_type = type;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_dispo = true;
            this.m_image = Properties.Resources.observateur;
            this.m_nbAller = nbAller;
            this.m_rayon = rayon;
        }

        /// <summary>
        /// Constructeur vide d'AeroObservateur
        /// </summary>
        public AeroObservateur() : base()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_dispo = true;
            m_origine = new PositionGeo();
            m_image = null;
            m_nbAller = 0;
            m_rayon = 0;
        }
    }
}
