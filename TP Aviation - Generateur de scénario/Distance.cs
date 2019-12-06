using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    [XmlInclude(typeof(AeroObservateur))]
    [XmlInclude(typeof(AeroSecours))]
    [XmlInclude(typeof(AeroIncendie))]
    public abstract class Distance : Aeronef
    {
        protected int m_nbAller;

        public Distance(string nom, int vitesse, int entretien, PositionGeo origine) : base(nom, vitesse, entretien, origine)
        {

        }

        public Distance()
        {

        }

    }
}
