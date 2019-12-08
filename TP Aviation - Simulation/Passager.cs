using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Passager : TransportClient
    {
        protected int m_quantite;

        public Passager(string nom, Areoport destination) : base(nom, destination)
        {
            this.m_nom = nom;
            this.m_destination = destination;

        }

        public int nbPassager() 
        {
            int quantite = 0;
            return quantite;
        }
    }
}
