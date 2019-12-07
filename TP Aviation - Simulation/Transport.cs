using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class Transport : Aeronef
    {
        protected int m_tempsEmb;
        protected int m_tempsDeb;

        public Transport(string nom, int vitesse, int entretien, PositionGeo origine, int charger, int decharger) : base(nom, vitesse, entretien, origine)
        {

        }

        public Transport()
        {

        }
    }
}
