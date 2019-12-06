using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    public abstract class Distance : Aeronef
    {
        protected int m_nbAller;

        public Distance(string nom, int vitesse, int entretien, PositionGeo origine) : base(nom, vitesse, entretien, origine)
        {

        }
    }
}
