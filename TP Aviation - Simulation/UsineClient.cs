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

        UsineClient()
        {
        }

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

        public Client creerPassager(List<Aeroport> listAreoport, Aeroport origine, Random rand)
        {
            Client newClient = null;

            newClient = new Passager(listAreoport, origine, rand);

            return newClient;
        }

        public Client creerMarchandise(List<Aeroport> listAreoport, Aeroport origine, Random rand)
        {
            Client newClient = null;

            newClient = new Marchandise(listAreoport, origine, rand);

            return newClient;
        }

        public Client creerObservateur(int width, int height, Random rand) 
        {
            Client newClient = null;

            newClient = new Observateur(width, height, rand);

            return newClient;
        }

        public Feu creerFeu(int width, int height, Random rand)
        {
            Feu newFeu = new Feu(width, height, rand);
            return newFeu;
        }

        public Client creerSecours(int width, int height, Random rand)
        {
            Client newClient = null;

            newClient = new Secours(width, height, rand);

            return newClient;
        }
    }
}
