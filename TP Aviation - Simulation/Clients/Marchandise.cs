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

        public Marchandise(List<Aeroport> listAreoport, Aeroport origine, Random rand) : base(listAreoport, rand)
        {
            this.m_nom = "Marchandise";
            this.m_destination = randomAreoport(listAreoport, origine, rand);
            this.m_poid = nbPoid(rand);
        }

        public double nbPoid(Random rand)
        {
            double poid = 0;
            poid = rand.Next(25);

            return poid;
        }

        public Aeroport randomAreoport(List<Aeroport> listAreoport, Aeroport origine, Random rand)
        {
            int count = listAreoport.Count();
            bool different = false;
            int destination = -1;

            while (!different)
            {
                destination = rand.Next(count);
                if (listAreoport[destination].Equals(origine))
                    different = true;
                else
                    different = false;
            }

            return listAreoport[destination];
        }

        public override string ToString()
        {
            return m_nom + " " + m_destination.m_nom + " " + m_poid;
        }

        public override double Poid
        {
            get { return m_poid; }
        }

        public override PositionGeo Destination
        {
            get { return m_destination.Localisation; }
            set { m_destination.Localisation = value; }
        }
    }
}
