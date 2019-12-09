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

        public Passager(List<Areoport> listAreoport, Areoport origine) : base(listAreoport)
        {
            this.m_nom = "Passager";
            this.m_destination = randomAreoport(listAreoport, origine);
            this.m_quantite = nbPassager();
        }

        public int nbPassager() 
        {
            int quantite = 0;
            Random rand = new Random();
            quantite = rand.Next(25);

            return quantite;
        }

        public Areoport randomAreoport(List<Areoport> listAreoport, Areoport origine)
        {
            int count = listAreoport.Count();
            bool different = false;

            Random rand = new Random();

            while (different)
            {
                int destiation = rand.Next(count);
                if (listAreoport[destiation].Equals(origine))
                    different = false;
                else
                    different = true;
            }

            return listAreoport[count];
        }
    }
}
