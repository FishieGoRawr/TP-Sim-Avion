using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class État
    {
        protected int etat = 0;
        protected Aeronef m_aeronef;

        public État(Aeronef aeronef)
        {
            
        }

        public virtual int Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        public virtual void avancer(Aeronef aeronef, int tempsPasse)
        {

        }
    }
}
