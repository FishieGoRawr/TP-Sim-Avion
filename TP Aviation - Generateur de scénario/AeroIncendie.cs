using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    public class AeroIncendie : Distance
    {
        Bitmap m_image;

        public AeroIncendie(string nom, int vitesse, int entretien, PositionGeo origine) : base(nom, vitesse, entretien, origine)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_image = null;
            this.m_nbAller = 0;
        }

        public AeroIncendie() : base()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_origine = new PositionGeo();
            m_image = null;
            m_nbAller = 0;
        }

        public int NbAller
        {
            get { return m_nbAller; }
            set { m_nbAller = value; }
        }
    }
}
