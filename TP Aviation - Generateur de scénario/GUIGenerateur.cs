using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aviation___Generateur_de_scénario
{
    public partial class GUIGenerateur : Form
    {
        ControlleurGenerateur controller;

        /// <summary>
        /// Constructeur de base du GUI principal. Initie la donnée membre 'controller'.
        /// </summary>
        public GUIGenerateur()
        {
            InitializeComponent();
            controller = new ControlleurGenerateur();
        }

        /// <summary>
        /// Gestionnaire d'event au Load du formulaire.
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">Event</param>
        private void GUIGenerateur_Load(object sender, EventArgs e)
        {
            loadCmbTypeCargo();
        }

        /// <summary>
        /// Gestionnaire d'event pour un click sur le bouton "Ajouter un aréoport".
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">Event</param>
        private void BtnAjouterAeroport_Click(object sender, EventArgs e)
        {
            string messageErreur = "";
            bool aeroportValide = true;

            if (string.IsNullOrEmpty(txtNomAeroport.Text))
            {
                aeroportValide = false;
                messageErreur = "Veuillez entrer un nom pour l'aréoport.";
            }
            else if (string.IsNullOrEmpty(txtAchPassager.Text))
            {
                aeroportValide = false;
                messageErreur = "Veuillez choisir l'achalandage de passager pour cet aéroport.";
            }
            else if (string.IsNullOrEmpty(txtAchMarchandise.Text))
            {
                aeroportValide = false;
                messageErreur = "Veuillez choisir l'achalandage de marchandise pour cet aéroport.";
            }
            else if (string.IsNullOrEmpty(txtPosition.Text))
            {
                aeroportValide = false;
                messageErreur = "Veuillez choisir un emplacement pour cet aéroport.";
            }

            if (!aeroportValide)
                MessageBox.Show(messageErreur);
            else
            {
                string areoport;
                areoport = controller.creerAeroport(txtNomAeroport.Text, Convert.ToInt32(txtAchPassager.Text), Convert.ToInt32(txtAchMarchandise.Text), txtPosition);
                lsbAeroports.Items.Add(areoport);
            }
            clearAeroport();
        }

        /// <summary>
        /// Gestionnaire d'event pour un click sur le bouton "Position" (Montre la carte du monde).
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">event</param>
        private void BtnPosition_Click(object sender, EventArgs e)
        {
            GUIPosition guipos = new GUIPosition(this);
            guipos.Show();
        }

        /// <summary>
        /// Gestionnaire d'event pour un click sur le bouton "Annulé aréoport" (Annule la création).
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">Event</param>
        private void BtnAnnulerAeroport_Click(object sender, EventArgs e)
        {
            clearAeroport();
        }

        /// <summary>
        /// Gestionnaire d'event pour un click sur le bouton "Annulé aéronef" (Annule la création).
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">Event</param>
        private void btnAnnulerAeronef_Click(object sender, EventArgs e)
        {
            txtNomAeronef.Clear();
            cmbTypeAeronef.SelectedIndex = -1;
            txtVitesse.Clear();
            txtLoad.Clear();
            txtUnload.Clear();
            txtEntretient.Clear();
        }

        /// <summary>
        /// Gestionnaire d'event pour un click sur le combobox "Type aéronef" (Active/change le label/textbox pour la capacité, etc...).
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">Event</param>
        private void CmbTypeAeronef_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeAeronef.Text == "Passagers")
            {
                lblChange.Text = "Capacité";
                lblChange.Visible = true;

                txtChange.Text = "";
                txtChange.Visible = true;

            }
            else if (cmbTypeAeronef.Text == "Marchandises")
            {
                lblChange.Text = "Capacité";
                lblChange.Visible = true;

                txtChange.Text = "";
                txtChange.Visible = true;
            }
            else if (cmbTypeAeronef.Text == "Observateurs")
            {
                lblChange.Text = "Rayon";
                lblChange.Visible = true;

                txtChange.Text = "";
                txtChange.Visible = true;
            }
            else
            {
                lblChange.Visible = false;
                txtChange.Visible = false;
            }
        }

        /// <summary>
        /// Gestionnaire d'event pour un click sur le bouton "Ajouté aeronef".
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">Event</param>
        private void BtnAjouterAeronef_Click(object sender, EventArgs e)
        {
            bool areonefValide = true;
            string messageErreur = "";

            String nom;
            String type;
            int vitesse = 0;
            int entretien = 0;
            int charger = 0;
            int decharger = 0;
            int change = 0;
            String aeroports;

            if (lsbAeroports.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(txtNomAeronef.Text))
                {
                    areonefValide = false;
                    messageErreur = "Veuillez entrer un nom pour l'aréonef.";
                }
                else if (string.IsNullOrEmpty(txtVitesse.Text) || !(int.TryParse(txtVitesse.Text, out vitesse)))
                {
                    areonefValide = false;
                    messageErreur = "Veuillez entrer une vitesse pour l'aréonef.";
                }
                else if (string.IsNullOrEmpty(txtEntretient.Text) || !(int.TryParse(txtEntretient.Text, out entretien)))
                {
                    areonefValide = false;
                    messageErreur = "Veuillez entrer un temps d'entretien pour l'aréonef.";
                }
                else if (string.IsNullOrEmpty(txtLoad.Text) || !(int.TryParse(txtLoad.Text, out charger)))
                {
                    areonefValide = false;
                    messageErreur = "Veuillez entrer un temps de chargement pour l'aréonef.";
                }
                else if (string.IsNullOrEmpty(txtUnload.Text) || !(int.TryParse(txtUnload.Text, out decharger)))
                {
                    areonefValide = false;
                    messageErreur = "Veuillez entrer un temps de déchargement pour l'aréonef.";
                }

                //Si toutes les conditions ne sont pas remplies, affiche un message d'erreur
                if (!areonefValide)
                    MessageBox.Show(messageErreur);
                else
                {
                    nom = txtNomAeronef.Text;
                    type = cmbTypeAeronef.Text;
                    aeroports = lsbAeroports.SelectedItem.ToString();

                    string[] nomAreoport = aeroports.Split(' ');

                    string areonef;
                    areonef = controller.creerAeronef(nom, type, vitesse, entretien, charger, decharger, change, nomAreoport[0]);
                    lsbAeronefs.Items.Add(areonef);
                    clearAeronef();
                }
            }
            else
                MessageBox.Show("Vous devez sélectionner un aréoport pour pouvoir y ajouté un avion.");
        }

        /// <summary>
        /// Gestionnaire d'event pour un click sur le bouton "Générer scénario" (Active/change le label/textbox pour la capacité, etc...).
        /// </summary>
        /// <param name="sender">Source de l'event</param>
        /// <param name="e">Event</param>
        private void BtnGenerer_Click(object sender, EventArgs e)
        {
            if (lsbAeroports.Items.Count == 0)
                MessageBox.Show("Vous devez au moin avoir un aréoport pour créer un scénario.");
            else if (lsbAeronefs.Items.Count == 0)
                MessageBox.Show("Vous devez au moin avoir un aéronef quelquonque pour créer un scénario.");
            else
                controller.serializeScenario();
        }

        /// <summary>
        /// Fournit le combobox avec les types d'avions possibles
        /// </summary>
        private void loadCmbTypeCargo()
        {
            cmbTypeAeronef.Items.Add("Passagers");
            cmbTypeAeronef.Items.Add("Marchandises");
            cmbTypeAeronef.Items.Add("Observateurs");
            cmbTypeAeronef.Items.Add("Incendies");
            cmbTypeAeronef.Items.Add("Secours");
        }

        /// <summary>
        /// S'occupe de clear les textbox pour la saisie de donnée au niveau de l'aréoport.
        /// </summary>
        private void clearAeroport()
        {
            txtNomAeroport.Clear();
            txtAchPassager.Clear();
            txtAchMarchandise.Clear();
            txtPosition.Clear();
        }

        /// <summary>
        /// S'occupe de clear les textbox pour la saisie de donnée au niveau de l'aeronef.
        /// </summary>
        private void clearAeronef()
        {
            txtNomAeronef.Text = "";
            txtVitesse.Text = "";
            txtEntretient.Text = "";
            txtLoad.Text = "";
            txtUnload.Text = "";
            txtChange.Text = "";
            cmbTypeAeronef.Text = "";
        }

        /// <summary>
        /// S'occupe de récupéré la position du GUIposition.
        /// </summary>
        /// <param name="position">Retourne un string de la position sous format degrée/minute.</param>
        /// <param name="posX">Position en X sur la carte.</param>
        /// <param name="posY">Position en Y sur la carte.</param>
        public void changerValeurPosition(string position, int posX, int posY)
        {
            txtPosition.Text = position;
            txtPosition.Tag = String.Concat(posX, ' ', posY);
        }
    }
}
