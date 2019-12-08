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

        public Client creerClient(string nom, string type, Areoport destination, int passager)
        {
            Client newClient = null;

            newClient = new Passager(nom, destination);

            return newClient;
        }
    }
}
