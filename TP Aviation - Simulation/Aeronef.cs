using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public class Aeronef
    {
        public String m_nom { get; set; }
        public String m_type { get; set; }
        public int m_vitesse { get; set; }
        public int m_tempsEnt { get; set; }
        public PositionGeo m_localisation { get; set; }
        public PositionGeo m_origine { get; set; }

        /// <summary>
        /// Constructeur d'aeronef.
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
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

        public String Type
        {
            get { return m_type; }
        }

        public virtual bool Dispo
        {
            get { return false; }
        }
    }
}
