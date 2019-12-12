using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public sealed class UsineClient
    {
        private static UsineClient m_usineClient = null;

        /// <summary>
        /// Constructeur de base d'un usine client
        /// </summary>
        UsineClient()
        {
        }

        /// <summary>
        /// Singleton: Obtient l'instance de l'usineClient
        /// </summary>
        public static UsineClient getUsineClient
        {
            get
            {
                if (m_usineClient == null)
                {
                    m_usineClient = new UsineClient();
                }
                return m_usineClient;
            }
        }

        /// <summary>
        /// Creer clients passager
        /// </summary>
        /// <param name="listAreoport">Liste d'areoport</param>
        /// <param name="origine">Position d'origine de l'areoport</param>
        /// <param name="rand"></param>
        /// <returns></returns>
        public Client creerPassager(List<Aeroport> listAreoport, Aeroport origine, Random rand)
        {
            Client newClient = null;

            newClient = new Passager(listAreoport, origine, rand);

            return newClient;
        }

        /// <summary>
        /// Creer clients marchandise
        /// </summary>
        /// <param name="listAreoport">Liste d'areoport</param>
        /// <param name="origine">Position d'origine de l'areoport</param>
        /// <param name="rand"></param>
        /// <returns></returns>
        public Client creerMarchandise(List<Aeroport> listAreoport, Aeroport origine, Random rand)
        {
            Client newClient = null;

            newClient = new Marchandise(listAreoport, origine, rand);

            return newClient;
        }

        /// <summary>
        /// Creer clients observateur
        /// </summary>
        /// <param name="width">Width de la map</param>
        /// <param name="height">Height de la map</param>
        /// <param name="rand"></param>
        /// <returns></returns>
        public Client creerObservateur(int width, int height, Random rand) 
        {
            Client newClient = null;

            newClient = new Observateur(width, height, rand);

            return newClient;
        }

        /// <summary>
        /// Creer clients incendie
        /// </summary>
        /// <param name="width">Width de la map</param>
        /// <param name="height">Height de la map</param>
        /// <param name="rand"></param>
        /// <returns></returns>
        public Feu creerFeu(int width, int height, Random rand)
        {
            Feu newFeu = new Feu(width, height, rand);
            return newFeu;
        }

        /// <summary>
        /// Creer clients secours
        /// </summary>
        /// <param name="width">Width de la map</param>
        /// <param name="height">Height de la map</param>
        /// <param name="rand"></param>
        /// <returns></returns>
        public Client creerSecours(int width, int height, Random rand)
        {
            Client newClient = null;

            newClient = new Secours(width, height, rand);

            return newClient;
        }
    }
}
