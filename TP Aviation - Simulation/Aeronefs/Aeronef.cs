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
        [XmlIgnore]
        public PositionGeo m_clientDestination { get; set; }

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
            this.m_etat = new Etat(this); ;
        }

        /// <summary>
        /// Appelle le bon état pour faire avancer l'aéronef ou changer l'état
        /// </summary>
        /// <param name="temps">Temps passer dans la simulation en minute</param>
        /// <param name="clients">Liste des clients de l'aéroport auquel l'aéronef appartient</param>
        public void avancerAvion(int temps, List<Client> clients)
        {
        }

        /// <summary>
        /// Ascesseur du type de l'aéronef
        /// </summary>
        public String Type
        {
            get { return m_type; }
        }

        /// <summary>
        /// Ascesseur du booléen de la disponibilité de l'aéronef
        /// </summary>
        public virtual bool Dispo
        {
            get { return m_dispo; }
            set { m_dispo = value; }
        }

        /// <summary>
        /// Ascesseur du temps de maintenance de l'aéronef
        /// </summary>
        public virtual int Entretien
        {
            get { return m_tempsEnt; }
        }

        /// <summary>
        /// Ascesseur de la vitesse de l'aéronef
        /// </summary>
        public virtual int Vitesse
        {
            get { return m_vitesse; }
        }

        /// <summary>
        /// Ascesseur de la localisation actuelle de l'aéronef
        /// </summary>
        public virtual PositionGeo Localisation
        {
            get { return m_localisation; }
            set { m_localisation = value; }
        }

        /// <summary>
        /// Ascesseur de la position d'origine de l'aéronef
        /// </summary>
        public virtual PositionGeo Origine
        {
            get { return m_origine; }
            set { m_origine = value; }
        }

        /// <summary>
        /// Ascesseur de la capacité de l'aéronef 
        /// </summary>
        public virtual int Capacite
        {
            get { return 0; }
        }

        /// <summary>
        /// Ascesseur de la capacité type de l'aéronef
        /// </summary>
        public virtual double DoubleCapacite
        {
            get { return 0; }
        }

        /// <summary>
        /// Ascesseur du temps d'embarquement de l'aéronef
        /// </summary>
        public virtual int Embarquement
        {
            get { return 0; }
        }

        /// <summary>
        /// Ascesseur du temps de debarquement type de l'aéronef
        /// </summary>
        public virtual int Debarquement
        {
            get { return 0; }
        }

        /// <summary>
        /// Ascesseur de l'indice du client que desert l'aéronef actuellement
        /// </summary>
        public virtual int IndexClient
        {
            get { return m_indexClient; }
            set { m_indexClient = value; }
        }
    }
}
