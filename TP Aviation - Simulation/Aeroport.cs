﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Simulation
{
    public class Aeroport
    {
        public string m_nom { get; set; }
        public PositionGeo m_localisation { get ; set; }
        public List<Aeronef> m_listAeronef { get; set; }
        public List<Client> m_listClient;
        public int m_achalPassager { get; set; }
        public int m_achalMarchandise { get; set; }
        public Bitmap m_image;

        public Aeroport(string p_nom, int p_achalMarchandise, int p_achalPassager)
        {
            m_listAeronef = new List<Aeronef>();
            m_listClient = new List<Client>();
            m_nom = p_nom;
            m_achalPassager = p_achalPassager;
            m_achalMarchandise = p_achalMarchandise;
            m_localisation = new PositionGeo();
            m_image = Properties.Resources.airport;
        }

        public Aeroport()
        {
            m_nom = "null";
            m_localisation = new PositionGeo();
            m_listAeronef = new List<Aeronef>();
            m_achalPassager = 0;
            m_achalMarchandise = 0;
        }

        public void bougerAvion(int temps)
        {
            foreach (var aeronef in m_listAeronef)
            {
                aeronef.avancerAvion(temps, m_listClient);
            }
        }

        public PositionGeo Localisation
        {
            get { return m_localisation; }
        }
    }
}