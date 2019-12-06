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
        String coord;

        public GUIGenerateur()
        {
            InitializeComponent();
            controller = new ControlleurGenerateur();
        }

        public String Coords
        {
            set { coord = value; }
        }

        private void loadCmbTypeCargo()
        {
            cmbTypeAeronef.Items.Add("Passagers");
            cmbTypeAeronef.Items.Add("Marchandises");
            cmbTypeAeronef.Items.Add("Observateurs");
            cmbTypeAeronef.Items.Add("Incendies");
            cmbTypeAeronef.Items.Add("Secours");
        }

        private void clearAeroport()
        {
            txtNomAeroport.Clear();
            txtAchPassager.Clear();
            txtAchMarchandise.Clear();
            txtPosition.Clear();
        }

        private void clearAeronef()
        {

        }

        public void changerValeurPosition(string position)
        {
            txtPosition.Text = position;
        }

        //EVENTS
        private void BtnAjouterAeroport_Click(object sender, EventArgs e)
        {
            string messageErreur = "";
            bool aeroportValide = true;
            int tempPass = 0;
            int tempMarch = 0;

            if (string.IsNullOrEmpty(txtNomAeroport.Text))
            {
                aeroportValide = false;
                messageErreur = "Veuillez entrer un nom pour l'aréoport.";
            }
            else if (string.IsNullOrEmpty(txtAchPassager.Text) || !(int.TryParse(txtAchPassager.Text, out tempPass)))
            {
                aeroportValide = false;
                messageErreur = "Veuillez choisir l'achalandage de passager pour cet aéroport.";
            }
            else if (string.IsNullOrEmpty(txtAchMarchandise.Text) || !(int.TryParse(txtAchMarchandise.Text, out tempMarch)))
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
                areoport = controller.creerAeroport(txtNomAeroport.Text, Convert.ToInt32(txtAchPassager.Text), Convert.ToInt32(txtAchMarchandise.Text), txtPosition.Text);
                lsbAeroports.Items.Add(areoport);
            }
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            GUIPosition guipos = new GUIPosition(this);
            guipos.Show();
        }

        private void BtnAnnulerAeroport_Click(object sender, EventArgs e)
        {
            clearAeroport();
        }

        private void btnAnnulerAeronef_Click(object sender, EventArgs e)
        {
            txtNomAeronef.Clear();
            cmbTypeAeronef.SelectedIndex = -1;
            txtVitesse.Clear();
            txtLoad.Clear();
            txtUnload.Clear();
            txtEntretient.Clear();
        }

        private void GUIGenerateur_Load(object sender, EventArgs e)
        {
            loadCmbTypeCargo();
        }

        private void CmbTypeAeronef_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTypeAeronef.Text == "Passagers")
            {
                lblChange.Text = "Capacité";
                lblChange.Visible = true;

                txtChange.Text = "";
                txtChange.Visible = true;

            }
            else if(cmbTypeAeronef.Text == "Marchandises")
            {
                lblChange.Text = "Capacité";
                lblChange.Visible = true;

                txtChange.Text = "";
                txtChange.Visible = true;
            }
            else if(cmbTypeAeronef.Text == "Observateurs")
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

        private void BtnAjouterAeronef_Click(object sender, EventArgs e)
        {
            String nom;
            String type;
            int vitesse;
            int entretien;
            int charger;
            int decharger;
            int change;
            String aeroports;

            nom = txtNomAeronef.Text;
            type = cmbTypeAeronef.Text;
            vitesse = Int32.Parse(txtVitesse.Text);
            entretien = Int32.Parse(txtEntretient.Text);
            charger = Int32.Parse(txtLoad.Text);
            decharger = Int32.Parse(txtUnload.Text);
            change = Int32.Parse(txtChange.Text);
            aeroports = lsbAeroports.GetItemText(lsbAeroports.SelectedItem);

            string areonef;
            areonef = controller.creerAeronef(nom, type, vitesse, entretien, charger, decharger, change, aeroports);
            lsbAeronefs.Items.Add(areonef);
        }

        private void BtnGenerer_Click(object sender, EventArgs e)
        {
            controller.serializeScenario();
        }

        ///
    }
}
