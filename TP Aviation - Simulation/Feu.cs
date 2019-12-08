using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Feu : DistanceClient
    {
        protected int m_intensite;

        public Feu(string nom, PositionGeo destination, int intensite) : base(nom, destination)
        {
            this.m_nom = nom;
            this.m_destination = destination;
            this.m_intensite = intensite;
        }
    }
}
