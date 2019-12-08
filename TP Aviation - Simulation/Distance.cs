using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class Distance : Aeronef
    {
        public int m_nbAller;

        public Distance(string nom, int vitesse, int entretien, PositionGeo origine) : base(nom, vitesse, entretien, origine)
        {

        }

        public Distance()
        {

        }

    }
}
