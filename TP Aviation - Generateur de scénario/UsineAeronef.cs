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

        public Aeronef creerAvion(string nom, string type, int vitesse, int entretien, int charger, int decharger, int change)
        {
            Aeronef newAeronef;

            newAeronef = new AeroPassager();
            newAeronef = new AeroMarchandise();
            newAeronef = new AeroObservateur();
            newAeronef = new AeroIncendie();
            newAeronef = new AeroSecours();

            return newAeronef;
        }
    }
}
