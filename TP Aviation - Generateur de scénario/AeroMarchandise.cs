﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    public class AeroMarchandise : Transport
    {
        float m_capacite;
        [XmlIgnore]
        Bitmap m_image;

        public AeroMarchandise(string nom, int vitesse, int entretien, PositionGeo origine, int charger, int decharger, int change) : base(nom, vitesse, entretien, origine, charger, decharger)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_tempsEmb = charger;
            this.m_tempsDeb = decharger;
            this.m_capacite = change;
            this.m_image = Properties.Resources.marchandise;
        }

        public AeroMarchandise() : base()
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
