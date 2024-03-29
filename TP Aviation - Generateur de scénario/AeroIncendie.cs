﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    /// <summary>
    /// Classe enfant d'Aeronef, ajoute un avion incendie
    /// </summary>
    
    public class AeroIncendie : Distance
    {
        [XmlIgnore]
        Bitmap m_image; //Image de l'aeroincendie

        /// <summary>
        /// Constructeur complex AeroIncendie.
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
        /// <param name="type">Type de l'areonef</param>
        public AeroIncendie(string nom, string type, int vitesse, int entretien, PositionGeo origine) : base(nom, type, vitesse, entretien, origine)
        {
            this.m_nom = nom;
            this.m_type = type;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_dispo = true;
            this.m_image = Properties.Resources.incendie;
            this.m_nbAller = 0;
        }

        /// <summary>
        /// Constructeur vide d'aeroincendie.
        /// </summary>
        public AeroIncendie() : base()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            this.m_dispo = true;
            m_origine = new PositionGeo();
            m_image = null;
            m_nbAller = 0;
        }

        /// <summary>
        /// Accesseur pour la propriété NbAller
        /// </summary>
        public int NbAller
        {
            get { return m_nbAller; }
            set { m_nbAller = value; }
        }
    }
}
