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

        public Passager(List<Aeroport> listAreoport, Aeroport origine, Random rand) : base(listAreoport, rand)
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

        public Aeroport randomAreoport(List<Aeroport> listAreoport, Aeroport origine, Random rand)
        {
            int count = listAreoport.Count();
            bool different = false;
            int destination = -1;

            while (!different)
            {
                destination = rand.Next(count);
                if (listAreoport[destination].Equals(origine))
                    different = false;
                else
                    different = true;
            }

            return listAreoport[destination];
        }

        public override string ToString()
        {
            return m_nom + " " + m_destination.m_nom + " " + m_quantite;
        }

        public override int Quantite
        {
            get { return m_quantite; }
        }

        public override PositionGeo Destination
        {
            get { return m_destination.Localisation; }
            set { m_destination.Localisation = value; }
        }
    }
}
