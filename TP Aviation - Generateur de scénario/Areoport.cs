using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP_Aviation___Generateur_de_scénario
{
    public class Areoport
    {
        public string m_nom { get; set; }
        public PositionGeo m_localisation { get; set; }
        public List<Aeronef> m_listAeronef { get; set; }
        public int m_achalPassager { get; set; }
        public int m_achalMarchandise { get; set; }
        [XmlIgnore]
        public Bitmap m_image;

        /// <summary>
        /// Constructeur d'Aeroport
        /// </summary>
        /// <param name="p_nom">Nom de l'aeroport</param>
        /// <param name="p_achalMarchandise">Nombre représentant l'achalandage des marchandises de l'aeroport</param>
        /// <param name="p_achalPassager">Nombre représentant l'achalandage des passagers de l'aeroport</param>
        /// <param name="p_positionGeo">Position géographique de l'aeroport</param>
        public Areoport(string p_nom, int p_achalMarchandise, int p_achalPassager, TextBox p_positionGeo)
        {
            m_listAeronef = new List<Aeronef>();
            m_nom = p_nom;
            m_achalPassager = p_achalPassager;
            m_achalMarchandise = p_achalMarchandise;
            m_localisation = new PositionGeo(p_positionGeo);
            m_image = Properties.Resources.airport; 
        }

        /// <summary>
        /// Constructeur vide d'Aeroport
        /// </summary>
        public Areoport()
        {
            m_nom = "null";
            m_localisation = new PositionGeo();
            m_listAeronef = new List<Aeronef>();
            m_achalPassager = 0;
            m_achalMarchandise = 0;
        }

        /// <summary>
        /// Retourne l'aeroport situé a l'index demander
        /// </summary>
        /// <param name="index">Position dans la liste de l'aeroport</param>
        /// <returns></returns>
        public Aeronef this[int index]
        {
            get { return m_listAeronef[index]; }
            set { m_listAeronef.Add(value); }
        }
    }
}
