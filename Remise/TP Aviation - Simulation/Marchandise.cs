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

        /// <summary>
        /// Constructeur d'un client marchandise
        /// </summary>
        /// <param name="listAreoport">Liste d'areoports du scénario</param>
        /// <param name="origine">Position d'origine de la marchandise</param>
        /// <param name="rand"></param>
        public Marchandise(List<Aeroport> listAreoport, Aeroport origine, Random rand) : base(listAreoport, rand)
        {
            this.m_nom = "Marchandise";
            this.m_destination = randomAreoport(listAreoport, origine, rand);
            this.m_poid = nbPoid(rand);
        }

        /// <summary>
        /// Génère le poids de la marchandise
        /// </summary>
        /// <param name="rand"></param>
        /// <returns>Poids aléatoire entre 1 et 25</returns>
        public double nbPoid(Random rand)
        {
            double poid = 0;
            poid = rand.Next(25);

            return poid;
        }

        /// <summary>
        /// Obtient une aréoport aléatoire dans la liste
        /// </summary>
        /// <param name="listAreoport">Liste d'aréoports</param>
        /// <param name="origine">Origine de l'areoport</param>
        /// <param name="rand"></param>
        /// <returns>Areoport aléatoire</returns>
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

        /// <summary>
        /// Version stirngifier d'un client marchandise
        /// </summary>
        /// <returns>String contenant l'info d'un client marchandise</returns>
        public override string ToString()
        {
            return m_nom + " " + m_destination.m_nom + " " + m_poid;
        }

        /// <summary>
        /// Accesseur du poid du client.
        /// </summary>
        public override double Poid
        {
            get { return m_poid; }
        }

        /// <summary>
        /// Accesseur de la positionGeo du client
        /// </summary>
        public override PositionGeo Destination
        {
            get { return m_destination.Localisation; }
            set { m_destination.Localisation = value; }
        }
    }
}
