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

        /// <summary>
        /// Constructeur d'un client passager
        /// </summary>
        /// <param name="listAreoport">Liste d'aréoports</param>
        /// <param name="origine">point d'origine du client</param>
        /// <param name="rand"></param>
        public Passager(List<Aeroport> listAreoport, Aeroport origine, Random rand) : base(listAreoport, rand)
        {
            this.m_nom = "Passager";
            this.m_destination = randomAreoport(listAreoport, origine, rand);
            this.m_quantite = nbPassager(rand);
        }

        /// <summary>
        /// Génère un nombre aléatoire de passager
        /// </summary>
        /// <param name="rand"></param>
        /// <returns>Retourne un nombre aléatoire de passagers</returns>
        public int nbPassager(Random rand) 
        {
            int quantite = 0;
            
            quantite = rand.Next(25);

            return quantite;
        }

        /// <summary>
        /// Trouve un aréoport aléatoire pour y generer des passagers
        /// </summary>
        /// <param name="listAreoport">liste d'areoports</param>
        /// <param name="origine">point d'origine d'un areoport</param>
        /// <param name="rand"></param>
        /// <returns>Aréoport aléatoire</returns>
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

        /// <summary>
        /// Version stringifier d'un passager
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return m_nom + " " + m_destination.m_nom + " " + m_quantite;
        }
        
        /// <summary>
        /// Accecsseur pour la quantité de passager
        /// </summary>
        public override int Quantite
        {
            get { return m_quantite; }
        }

        /// <summary>
        /// Accesseur pour la position geo du passager
        /// </summary>
        public override PositionGeo Destination
        {
            get { return m_destination.Localisation; }
            set { m_destination.Localisation = value; }
        }
    }
}
