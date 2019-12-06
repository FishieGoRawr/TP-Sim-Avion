using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    [XmlInclude(typeof(Distance))]
    [XmlInclude(typeof(Transport))]
    public class Aeronef
    {
        protected String m_nom;
        protected int m_vitesse;
        protected int m_tempsEnt;
        protected PositionGeo m_localisation;
        protected PositionGeo m_origine;

        public Aeronef(string nom, int vitesse, int entretien, PositionGeo origine)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_localisation = null;
            this.m_origine = origine;
        }

        public Aeronef()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_localisation = new PositionGeo();
            m_origine = new PositionGeo();
        }

        public void creerAvion(string type)
        {
            
        }

        public void creerAvion(int dequoi, int dequoi2)
        {

        }
    }

    //Aeronef newAeronef;
    //        switch (type)
    //        {
    //            case "Passagers":
    //                newAeronef = new AeroPassager();
    //                break;
    //            case "Marchandises":
    //                break;
    //            case "Observateurs":
    //                break;
    //            case "Incendies":
    //                break;
    //            case "Secours":
    //                break;
    //            default:
    //                break;
    //        }
}
