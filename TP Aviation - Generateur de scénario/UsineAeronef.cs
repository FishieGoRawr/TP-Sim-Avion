using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Generateur_de_scénario
{
    public sealed class UsineAeronef
    {
        private static UsineAeronef m_usineAeronef = null;

        UsineAeronef()
        {
        }

        public static UsineAeronef getUsineAeronef
        {
            get
            {
                if (m_usineAeronef == null)
                {
                    m_usineAeronef = new UsineAeronef();
                }
                return m_usineAeronef;
            }
        }

        public Aeronef creerAvion(string type)
        {
            Aeronef newAeronef = new Aeronef(type);
            return newAeronef;
        }
    }
}
