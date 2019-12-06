using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    public class AeroObservateur : Distance
    {
        public Bitmap m_image { get; set; }
        public int m_rayon { get; set; }

        public AeroObservateur(string nom, int vitesse, int entretien, PositionGeo origine, int nbAller, int rayon) : base(nom, vitesse, entretien, origine)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_image = null;
            this.m_nbAller = nbAller;
            this.m_rayon = rayon;
        }

        public AeroObservateur() : base()
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
