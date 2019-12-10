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

        public Passager(List<Areoport> listAreoport, Areoport origine, Random rand) : base(listAreoport, rand)
        {
            this.m_nom = "Passager";
            this.m_destination = randomAreoport(listAreoport, origine, rand);
            this.m_quantite = nbPassager(rand);
        }

        public int nbPassager(Random rand) 
        {
            int quantite = 0;
            
            quantite = rand.Next(25);

            return quantite;
        }

        public Areoport randomAreoport(List<Areoport> listAreoport, Areoport origine, Random rand)
        {
            int count = listAreoport.Count();
            bool different = false;
            int destination = -1;

            while (!different)
            {
                destination = rand.Next(0, count);
                if (listAreoport[destination].Equals(origine))
                    different = true;
                else
                    different = false;
            }

            return listAreoport[destination];
        }

        public override string ToString()
        {
            return m_nom + " " + m_destination.m_nom + " " + m_quantite;
        }
    }
}
