using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Generateur_de_scénario
{
    public class Aeronef
    {
        protected String m_nom;
        protected int m_vitesse;
        protected int m_tempsEnt;
        protected PositionGeo m_localisation;
        protected PositionGeo m_origine;
        protected Bitmap m_image;

        public Aeronef(string nom, int vitesse, int entretien, PositionGeo origine, Bitmap img)
        {
            this.m_nom = nom;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_localisation = null;
            this.m_origine = origine;
            this.m_image = img;
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
