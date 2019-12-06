﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{
    public class Aeroport
    {
        public string m_nom { get; set; }
        public PositionGeo m_localisation { get; set; }
        public List<Aeronef> m_listAeronef { get; set; }
        public int m_achalPassager { get; set; }
        public int m_achalMarchandise { get; set; }

        public Aeroport(string p_nom, int p_achalMarchandise, int p_achalPassager, string p_positionGeo)
        {
            m_listAeronef = new List<Aeronef>();
            m_nom = p_nom;
            m_achalPassager = p_achalPassager;
            m_achalMarchandise = p_achalMarchandise;
            m_localisation = new PositionGeo(p_positionGeo);
        }

        public Aeroport()
        {
            m_nom = "null";
            m_localisation = new PositionGeo(0,0);
            m_listAeronef = new List<Aeronef>();
            m_achalPassager = 0;
            m_achalMarchandise = 0;
        }

        public string Nom
        {
            get { return m_nom; }
        }

        public PositionGeo Localisation
        {
            get { return m_localisation; }
        }

        public int AchalPassager
        {
            get { return m_achalPassager; }
        }

        public int AchalMarchandise
        {
            get { return m_achalMarchandise; }
        }

        public Aeronef this[int index]
        {
            get { return m_listAeronef[index]; }
            set { m_listAeronef.Add(value); }
        }
    }
}
