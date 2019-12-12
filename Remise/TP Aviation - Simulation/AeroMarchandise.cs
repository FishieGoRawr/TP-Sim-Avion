using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Simulation
{
    public class AeroMarchandise : Transport
    {
        float m_capacite { get; set; }
        Bitmap m_image;

        /// <summary>
        /// Constructeur complex d'AeroMarchandise
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
        /// <param name="charger">Temps de chargement de l'aeronefe</param>
        /// <param name="decharger">Temps de déchargement de l'aeronef</param>
        /// <param name="change">Capacité de l'aeronef</param>
        public AeroMarchandise(string nom, string type, int vitesse, int entretien, PositionGeo origine, int charger, int decharger, int change) : base(nom, type, vitesse, entretien, origine, charger, decharger)
        {
            this.m_nom = nom;
            this.m_type = type;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_origine = origine;
            this.m_tempsEmb = charger;
            this.m_tempsDeb = decharger;
            this.m_capacite = change;
            this.m_indexClient = -1;
            m_clientDestination = new PositionGeo();
        }

        /// <summary>
        /// Constructeur vide d'AeroMarchandise
        /// </summary>
        public AeroMarchandise() : base()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_origine = new PositionGeo();
            m_tempsEmb = 0;
            m_tempsDeb = 0;
            m_capacite = 0;
            m_image = null;
            this.m_indexClient = -1;
            m_clientDestination = new PositionGeo();
        }

        /// <summary>
        /// Ascesseur de la capacité des aéronefs de types marchandises
        /// </summary>
        public override double DoubleCapacite
        {
            get { return m_capacite; }
        }

        /// <summary>
        /// Ascesseur du temps d'embarquement des aéronefs de types marchandises et passagers
        /// </summary>
        public override int Embarquement
        {
            get { return m_tempsEmb; }
        }

        /// <summary>
        /// Ascesseur du temps d'embarquement des aéronefs de types marchandises et passagers
        /// </summary>
        public override int Debarquement
        {
            get { return m_tempsDeb; }
        }
    }
}
