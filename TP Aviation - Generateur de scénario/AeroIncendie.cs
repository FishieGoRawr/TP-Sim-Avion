using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    class AeroIncendie : Distance
    {
        public AeroIncendie(string nom, int vitesse, int entretien, PositionGeo origine, Bitmap img, int nbAller) : base(nom, vitesse, entretien, origine, img, nbAller)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_image = img;
            this.m_nbAller = nbAller;
        }
    }
}
