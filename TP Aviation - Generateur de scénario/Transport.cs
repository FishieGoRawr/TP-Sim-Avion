using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    [XmlInclude(typeof(AeroPassager))]
    [XmlInclude(typeof(AeroMarchandise))]
    public abstract class Transport : Aeronef
    {
        public int m_tempsEmb { get; set; }
        public int m_tempsDeb { get; set; }

        public Transport(string nom, int vitesse, int entretien, PositionGeo origine, int charger, int decharger) : base(nom, vitesse, entretien, origine)
        {

        }

        public Transport()
        {

        }
    }
}
