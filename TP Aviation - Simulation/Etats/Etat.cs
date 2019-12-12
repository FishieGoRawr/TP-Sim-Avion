using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public class Etat
    {
        protected int etat = 1;
        protected Aeronef m_aeronef;

        public Etat(Aeronef aeronef)
        {
            m_aeronef = aeronef;
        }

        public virtual int Index
        {
            get { return etat; }
            set { etat = value; }
        }

        public virtual void avancer(int tempsPasse, List<Client> clients)
        {

        }
    }
}
