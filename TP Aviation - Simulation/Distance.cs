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
        public bool m_dispo;

        public Distance(string nom, string type, int vitesse, int entretien, PositionGeo origine) : base(nom, type, vitesse, entretien, origine)
        {

        }

        public Distance()
        {

        }

        public override bool Dispo
        {
            get { return m_dispo; }
        }
    }
}
