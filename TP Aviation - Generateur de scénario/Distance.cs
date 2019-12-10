using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    public abstract class Distance : Aeronef
    {
        public int m_nbAller { get; set; }
        public bool m_dispo { get; set; }

        /// <summary>
        /// Constructuer de la classe parente des aeronefs de secours, observation et incendie
        /// </summary>
        /// <param name="nom">Nom du futur aeronef</param>
        /// <param name="type">Type du futur aeronef</param>
        /// <param name="vitesse">Vitesse du futur aeronef</param>
        /// <param name="entretien">Temps d'entretien du futur aeronef</param>
        /// <param name="origine">Position de l'aeroport auquel appartiendra le futur aeronef</param>
        public Distance(string nom, string type, int vitesse, int entretien, PositionGeo origine) : base(nom, type, vitesse, entretien, origine)
        {

        }

        /// <summary>
        /// Constructeur vide de la classe abstraite Distance
        /// </summary>
        public Distance()
        {

        }

    }
}
