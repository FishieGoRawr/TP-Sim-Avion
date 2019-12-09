using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Observateur : DistanceClient

    {
        int m_rayon;

        public Observateur(string nom, PositionGeo destination) : base(nom, destination)
        {
            this.m_nom = nom;
            this.m_destination = destination;
            this.m_rayon = 20;
        }
    }
}
