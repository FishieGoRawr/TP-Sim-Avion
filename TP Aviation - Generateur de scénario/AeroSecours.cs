using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    class AeroSecours : Distance
    {
        Bitmap m_image;
        public AeroSecours(string nom, int vitesse, int entretien, PositionGeo origine, int nbAller) : base(nom, vitesse, entretien, origine)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_image = null;
            this.m_nbAller = nbAller;
        }
    }
}
