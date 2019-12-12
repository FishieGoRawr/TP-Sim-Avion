using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    public abstract class Transport : Aeronef
    {
        public int m_tempsEmb { get; set; }
        public int m_tempsDeb { get; set; }

        /// <summary>
        /// Constructeur de la classe abstraite d'avions de transports (Passager, Marchandise)
        /// </summary>
        ///<param name = "nom" >Nom de l'aéronef</param>
        /// <param name="type">Type de l'aéronef</param>
        /// <param name="vitesse">Vitesse de l'aéronef</param>
        /// <param name="origine">Position d'origine de l'aéronef, qui est la position de l'aéroport</param>
        /// <param name="entretien">Temps de maintenance de l'aéronef</param>
        /// <param name="charger">Temps d'embarquement de l'aéronef</param>
        /// <param name="decharger">Temps de débarquement de l'aéronef</param>
        public Transport(string nom, string type, int vitesse, int entretien, PositionGeo origine, int charger, int decharger) : base(nom, type, vitesse, entretien, origine)
        {

        }

        /// <summary>
        /// Constructeur vide de la classe abstraite d'avions de transports (Passager, Marchandise)
        /// </summary>
        public Transport()
        {

        }
    }
}
