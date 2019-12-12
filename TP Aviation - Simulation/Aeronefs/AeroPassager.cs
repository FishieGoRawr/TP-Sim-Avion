using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Aviation___Simulation
{
    public class AeroPassager : Transport
    {
        int m_capacite { get; set; }
        Bitmap m_image;

        /// <summary>
        /// Constructeur d'AeroPassager
        /// </summary>
        /// <param name="nom">Nom de l'aeronef</param>
        /// <param name="vitesse">Vitesse de l'aeronef</param>
        /// <param name="entretien">Temps d'entretien de l'aeronef</param>
        /// <param name="origine">Point d'origine de l'aeronef</param>
        /// <param name="charger">Temps pour charger l'aeronef</param>
        /// <param name="decharger">Temps pour decharger l'aeronef</param>
        /// <param name="change">Capacité de passager de l'aeronef</param>
        /// <param name="type">Type de l'areonef</param>
        public AeroPassager(string nom, string type, int vitesse, int entretien, PositionGeo origine, int charger, int decharger, int change) : base(nom, type, vitesse, entretien, origine, charger, decharger)
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
            this.m_etat = new Etat(this);
            m_clientDestination = new PositionGeo();
        }

        /// <summary>
        /// Constructeur vide pour AeroPassager
        /// </summary>
        public AeroPassager() : base()
        {
            m_nom = "null";
            m_type = "typeNull";
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

        public override void avancerAvion(int temps, List<Client> clients)
        {
            switch (m_etat.Index)
            {
                case 1:
                    if (m_etat.GetType() != typeof(Attente))
                        m_etat = new Attente(this);
                    break;
                case 2:
                    if (m_etat.GetType() != typeof(Embarquement))
                        m_etat = new Embarquement(this);
                    break;
                case 3:
                    if (m_etat.GetType() != typeof(Aller))
                        m_etat = new Aller(this);
                    break;
                case 4:
                    if (m_etat.GetType() != typeof(AllerRetour))
                        m_etat = new AllerRetour(this);
                    break;
                case 5:
                    if (m_etat.GetType() != typeof(Observation))
                        m_etat = new Observation(this);
                    break;
                case 6:
                    if (m_etat.GetType() != typeof(Débarquement))
                        m_etat = new Débarquement(this);
                    break;
                case 7:
                    if (m_etat.GetType() != typeof(Maintenance))
                        m_etat = new Maintenance(this);
                    break;
                default:
                    break;
            }

            m_etat.avancer(temps, clients);
        }

        /// <summary>
        /// Ascesseur de la capacité de l'aéronef
        /// </summary>
        public override int Capacite
        {
            get { return m_capacite; }
        }

        /// <summary>
        /// Ascesseur du temps de d'embarquement type de l'aéronef
        /// </summary>
        public override int Embarquement
        {
            get { return m_tempsEmb; }
        }

        /// <summary>
        /// Ascesseur du temps de debarquement type de l'aéronef
        /// </summary>
        public override int Debarquement
        {
            get { return m_tempsDeb; }
        }
    }
}
