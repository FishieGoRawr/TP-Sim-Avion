using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Secours : DistanceClient
    {
        public Secours(string nom, PositionGeo destination) : base(nom, destination)
        {
            this.m_nom = nom;
            this.m_destination = destination;
        }
    }
}
