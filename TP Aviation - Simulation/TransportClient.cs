using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class TransportClient : Client
    {
        protected Areoport m_destination;

        public TransportClient(string nom, Areoport destination) : base(nom)
        {
            this.m_destination = destination;
        }
    }
}
