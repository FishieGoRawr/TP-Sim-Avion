using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class Transport : Aeronef
    {
        public int m_tempsEmb;
        public int m_tempsDeb;

        public Transport(string nom, string type, int vitesse, int entretien, PositionGeo origine, int charger, int decharger) : base(nom, type, vitesse, entretien, origine)
        {

        }

        public Transport()
        {

        }

        public override void avancerAvion(int temps, List<Client> clients)
        {
        }

        public override int Embarquement
        {
            get { return m_tempsEmb; }
        }

        public override int Debarquement
        {
            get { return m_tempsDeb; }
        }
    }
}
