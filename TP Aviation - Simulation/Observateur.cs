using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Observateur : DistanceClient

    {
        protected int m_rayon;

        public Observateur(string nom, PositionGeo destination, int rayon) : base(nom, destination)
        {
            this.m_nom = nom;
            this.m_destination = destination;
            this.m_rayon = rayon;
        }
    }
}
