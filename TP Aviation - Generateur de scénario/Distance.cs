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
        public int m_nbAller { get; set; }
        public bool m_dispo { get; set; }

        public Distance(string nom, string type, int vitesse, int entretien, PositionGeo origine) : base(nom, type, vitesse, entretien, origine)
        {

        }

        public Distance()
        {

        }

    }
}
