using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public abstract class Client
    {
        protected String m_nom;

        public Client()
        {

        }

        public String Nom
        {
            get { return m_nom; }
        }

        public virtual int PosX
        {
            get { return -1; }
        }

        public virtual int PosY
        {
            get { return -1; }
        }
    }
}
