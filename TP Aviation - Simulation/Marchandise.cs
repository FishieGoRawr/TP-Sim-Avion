using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Marchandise : TransportClient
    {
        protected double m_poid;

        public Marchandise(string nom, Areoport destination, double poid) : base(nom, destination)
        {
            this.m_nom = nom;
            this.m_destination = destination;
            this.m_poid = poid;
        }
    }
}
