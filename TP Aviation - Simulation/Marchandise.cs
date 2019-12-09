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

        public Marchandise(List<Areoport> listAreoport, Areoport origine) : base(listAreoport)
        {
            this.m_nom = "";
            this.m_destination = randomAreoport(listAreoport, origine);
            this.m_poid = nbPoid();
        }

        public double nbPoid()
        {
            double poid = 0;
            Random rand = new Random();
            poid = rand.Next(25);

            return poid;
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
