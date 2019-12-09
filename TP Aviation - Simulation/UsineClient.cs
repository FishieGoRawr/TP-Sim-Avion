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

        public Client creerClient(string nom, Areoport destination, int passager)
        {
            Client newClient = null;

            newClient = new Passager(nom, destination);

            return newClient;
        }

        public Client creerClient(string nom, Areoport destination, double poid)
        {
            Client newClient = null;

            newClient = new Marchandise(nom, destination, poid);

            return newClient;
        }

        public Client creerClient(string nom, PositionGeo destination)
        {
            Client newClient = null;

            newClient = new Observateur(nom, destination);

            return newClient;
        }

        public Client creerClient(string nom, PositionGeo position, int intensite)
        {
            Client newClient = null;

            newClient = new Feu(nom, position, intensite);

            return newClient;
        }

        public Client creerClient(string nom, PositionGeo position)
        {
            Client newClient = null;

            newClient = new Secours(nom, position);

            return newClient;
        }
    }
}
