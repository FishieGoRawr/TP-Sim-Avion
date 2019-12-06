using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    class AeroMarchandise : Transport
    {
        float m_capacite;

        public AeroMarchandise(string nom, int vitesse, int entretien, PositionGeo origine, Bitmap img, int charger, int decharger, int change) : base(nom, vitesse, entretien, origine, img, charger, decharger)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_image = img;
            this.m_tempsEmb = charger;
            this.m_tempsDeb = decharger;
            this.m_capacite = change;
        }
    }
}
