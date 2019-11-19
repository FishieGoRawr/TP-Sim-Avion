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
        public GUIGenerateur()
        {
            InitializeComponent();
        }

        private void GUIGenerateur_Load(object sender, EventArgs e)
        {
            loadCmbTypeCargo();
        }

        private void loadCmbTypeCargo()
        {
            cmbTypeCargo.Items.Add("Passagers");
            cmbTypeCargo.Items.Add("Marchandises");
        }

        private void BtnAnnulerAeroport_Click(object sender, EventArgs e)
        {
            txtNomAeroport.Clear();
            txtAchPassager.Clear();
            txtAchMarchandise.Clear();
        }

        private void btnAnnulerAeronef_Click(object sender, EventArgs e)
        {
            txtNomAeronef.Clear();
            cmbTypeCargo.SelectedIndex = -1;
            txtVitesse.Clear();
            txtLoad.Clear();
            txtUnload.Clear();
            txtEntretient.Clear();
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            GUIPosition guipos = new GUIPosition(this);
            guipos.Show();
        }

        public void changerValeurPosition(string position)
        {
            txtPosition.Text = position;
        }
    }
}
