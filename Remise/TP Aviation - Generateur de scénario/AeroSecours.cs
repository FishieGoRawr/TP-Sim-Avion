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
    /// Classe enfant d'Aeronef, ajoute un avion secours
    /// </summary>
    public class AeroSecours : Distance
    {
        [XmlIgnore]
        Bitmap m_image; //Image de l'aeronef

        /// <summary>
        ///  Constructeur d'Aeronef de secours
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="type">Type de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Origine de l'aeronef</param>
        /// <param name="nbAller">Nombre d'aller retour que l'aeronef doit effectuer</param>
        public AeroSecours(string nom, string type, int vitesse, int entretien, PositionGeo origine, int nbAller) : base(nom, type, vitesse, entretien, origine)
        {
            this.m_nom = nom;
            this.m_type = type;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_dispo = true;
            this.m_origine = origine;
            this.m_image = m_image = Properties.Resources.chopper;
            this.m_nbAller = nbAller;
        }

        /// <summary>
        /// Constructeur vide d'AeroSecours
        /// </summary>
        public AeroSecours() : base()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_dispo = true;
            m_origine = new PositionGeo();
            m_image = null;
            m_nbAller = 0;
        }
    }
}
