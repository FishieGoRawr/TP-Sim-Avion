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

        public GUIGenerateur()
        {
            InitializeComponent();
            controller = new ControlleurGenerateur();
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
                controller.creerAeroport(txtNomAeroport.Text, Convert.ToInt32(txtAchPassager.Text), Convert.ToInt32(txtAchMarchandise.Text), txtPosition.Text);
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
        ///
    }
}
