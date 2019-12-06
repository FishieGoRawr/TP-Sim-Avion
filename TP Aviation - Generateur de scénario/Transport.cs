using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    public abstract class Transport : Aeronef
    {
        protected int m_tempsEmb;
        protected int m_tempsDeb;

        public Transport(string nom, int vitesse, int entretien, PositionGeo origine, Bitmap img, int charger, int decharger) : base(nom, vitesse, entretien, origine, img)
        {

        }
    }
}
