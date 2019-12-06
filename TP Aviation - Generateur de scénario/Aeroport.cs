using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{
    public class Aeroport
    {
        string m_nom;
        PositionGeo m_localisation;
        List<Aeronef> m_listAeronef;
        int m_achalPassager;
        int m_achalMarchandise;

        public Aeroport(string p_nom, int p_achalMarchandise, int p_achalPassager, string p_positionGeo)
        {
            m_listAeronef = new List<Aeronef>();
            m_nom = p_nom;
            m_achalPassager = p_achalPassager;
            m_achalMarchandise = p_achalMarchandise;
            m_localisation = new PositionGeo(p_positionGeo);
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
