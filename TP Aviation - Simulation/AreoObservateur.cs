using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Simulation
{
    public class AreoObservateur : Distance
    {
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
        public AreoObservateur(string nom, int vitesse, int entretien, PositionGeo origine, int nbAller, int rayon) : base(nom, vitesse, entretien, origine)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_image = Properties.Resources.observateur;
            this.m_nbAller = nbAller;
            this.m_rayon = rayon;
        }

        /// <summary>
        /// Constructeur vide d'AeroObservateur
        /// </summary>
        public AreoObservateur() : base()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_origine = new PositionGeo();
            m_image = null;
            m_nbAller = 0;
            m_rayon = 0;
        }
    }
}
