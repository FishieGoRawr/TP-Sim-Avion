using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP_Aviation___Simulation
{
    [XmlInclude(typeof(AeroPassager))]
    [XmlInclude(typeof(AeroMarchandise))]
    [XmlInclude(typeof(AeroObservateur))]
    [XmlInclude(typeof(AeroSecours))]
    [XmlInclude(typeof(AeroIncendie))]
    public class Aeronef
    {
        public String m_nom { get; set; }
        public String m_type { get; set; }
        public int m_vitesse { get; set; }
        public int m_tempsEnt { get; set; }
        public PositionGeo m_localisation { get; set; }
        public PositionGeo m_origine { get; set; }
        [XmlIgnore]
        public bool m_dispo { get; set; }
        [XmlIgnore]
        public Etat m_etat { get; set; }
        [XmlIgnore]
        public int m_indexClient { get; set; }

        /// <summary>
        /// Constructeur d'aeronef.
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
        public Aeronef(string nom, string type, int vitesse, int entretien, PositionGeo origine)
        {
            this.m_nom = nom;
            this.m_type = type;
            this.m_vitesse = vitesse;
            this.m_tempsEnt = entretien;
            this.m_localisation = null;
            this.m_origine = origine;
            this.m_dispo = true;
            this.m_etat = new Etat(this);
            this.m_indexClient = -1;
        }

        /// <summary>
        /// Constructeur vide d'aeronef.
        /// </summary>
        public Aeronef()
        {
            m_nom = "null";
            m_vitesse = 0;
            m_tempsEnt = 0;
            m_localisation = new PositionGeo();
            m_origine = new PositionGeo();
            this.m_dispo = true;
            this.m_indexClient = -1;
            this.m_etat = null;
        }

        public void avancerAvion(int temps, List<Client> clients)
        {
            switch (m_etat.Index)
            {
                case 1:
                    m_etat = new Attente(this);
                    break;
                case 2:
                    m_etat = new Embarquement(this);
                    break;
                case 3:
                    m_etat = new Aller(this);
                    break;
                case 4:
                    m_etat = new AllerRetour(this);
                    break;
                case 5:
                    m_etat = new Observation(this);
                    break;
                case 6:
                    m_etat = new Débarquement(this);
                    break;
                case 7:
                    m_etat = new Maintenance(this);
                    break;
                default:
                    break;
            }

            m_etat.avancer(temps, clients);
        }

        public String Type
        {
            get { return m_type; }
        }

        public virtual bool Dispo
        {
            get { return m_dispo; }
            set { m_dispo = value; }
        }

        public virtual int Entretien
        {
            get { return m_tempsEnt; }
        }

        public virtual int Vitesse
        {
            get { return m_vitesse; }
        }

        public virtual PositionGeo Localisation
        {
            get { return m_localisation; }
        }

        public virtual PositionGeo Origine
        {
            get { return m_origine; }
            set { m_origine = value; }
        }

        public virtual int Capacite
        {
            get { return 0; }
        }

        public virtual double DoubleCapacite
        {
            get { return 0; }
        }

        public virtual int Embarquement
        {
            get { return 0; }
        }

        public virtual int Debarquement
        {
            get { return 0; }
        }

        public virtual int IndexClient
        {
            get { return m_indexClient; }
            set { m_indexClient = value; }
        }
    }
}
