namespace TP_Aviation___Generateur_de_scénario
{
    partial class GUIGenerateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAeroports = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnAnnulerAeroport = new System.Windows.Forms.Button();
            this.btnAjouterAeroport = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.txtNomAeroport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAchMarchandise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAchPassager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbAeroports = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLeScénarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scénarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAeronefs = new System.Windows.Forms.GroupBox();
            this.txtEntretient = new System.Windows.Forms.TextBox();
            this.txtUnload = new System.Windows.Forms.TextBox();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTypeAeronef = new System.Windows.Forms.ComboBox();
            this.btnAnnulerAeronef = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNomAeronef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsbAeronefs = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.grpAeroports.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpAeronefs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAeroports
            // 
            this.grpAeroports.Controls.Add(this.label4);
            this.grpAeroports.Controls.Add(this.txtPosition);
            this.grpAeroports.Controls.Add(this.btnAnnulerAeroport);
            this.grpAeroports.Controls.Add(this.btnAjouterAeroport);
            this.grpAeroports.Controls.Add(this.btnPosition);
            this.grpAeroports.Controls.Add(this.txtNomAeroport);
            this.grpAeroports.Controls.Add(this.label3);
            this.grpAeroports.Controls.Add(this.txtAchMarchandise);
            this.grpAeroports.Controls.Add(this.label2);
            this.grpAeroports.Controls.Add(this.txtAchPassager);
            this.grpAeroports.Controls.Add(this.label1);
            this.grpAeroports.Controls.Add(this.lsbAeroports);
            this.grpAeroports.Location = new System.Drawing.Point(12, 35);
            this.grpAeroports.Name = "grpAeroports";
            this.grpAeroports.Size = new System.Drawing.Size(1070, 348);
            this.grpAeroports.TabIndex = 0;
            this.grpAeroports.TabStop = false;
            this.grpAeroports.Text = "Aéroports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(657, 235);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(204, 26);
            this.txtPosition.TabIndex = 11;
            // 
            // btnAnnulerAeroport
            // 
            this.btnAnnulerAeroport.Location = new System.Drawing.Point(10, 309);
            this.btnAnnulerAeroport.Name = "btnAnnulerAeroport";
            this.btnAnnulerAeroport.Size = new System.Drawing.Size(1052, 31);
            this.btnAnnulerAeroport.TabIndex = 10;
            this.btnAnnulerAeroport.Text = "Annuler";
            this.btnAnnulerAeroport.UseVisualStyleBackColor = true;
            this.btnAnnulerAeroport.Click += new System.EventHandler(this.BtnAnnulerAeroport_Click);
            // 
            // btnAjouterAeroport
            // 
            this.btnAjouterAeroport.Location = new System.Drawing.Point(10, 272);
            this.btnAjouterAeroport.Name = "btnAjouterAeroport";
            this.btnAjouterAeroport.Size = new System.Drawing.Size(1052, 31);
            this.btnAjouterAeroport.TabIndex = 9;
            this.btnAjouterAeroport.Text = "Ajouter";
            this.btnAjouterAeroport.UseVisualStyleBackColor = true;
            this.btnAjouterAeroport.Click += new System.EventHandler(this.BtnAjouterAeroport_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(868, 234);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(183, 34);
            this.btnPosition.TabIndex = 8;
            this.btnPosition.Text = "Choisir position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // txtNomAeroport
            // 
            this.txtNomAeroport.Location = new System.Drawing.Point(30, 235);
            this.txtNomAeroport.Name = "txtNomAeroport";
            this.txtNomAeroport.Size = new System.Drawing.Size(176, 26);
            this.txtNomAeroport.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Achalandage (Marchandise)";
            // 
            // txtAchMarchandise
            // 
            this.txtAchMarchandise.Location = new System.Drawing.Point(426, 235);
            this.txtAchMarchandise.Name = "txtAchMarchandise";
            this.txtAchMarchandise.Size = new System.Drawing.Size(204, 26);
            this.txtAchMarchandise.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Achalandage (Passager)";
            // 
            // txtAchPassager
            // 
            this.txtAchPassager.Location = new System.Drawing.Point(226, 235);
            this.txtAchPassager.Name = "txtAchPassager";
            this.txtAchPassager.Size = new System.Drawing.Size(176, 26);
            this.txtAchPassager.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // lsbAeroports
            // 
            this.lsbAeroports.FormattingEnabled = true;
            this.lsbAeroports.ItemHeight = 20;
            this.lsbAeroports.Location = new System.Drawing.Point(6, 25);
            this.lsbAeroports.Name = "lsbAeroports";
            this.lsbAeroports.Size = new System.Drawing.Size(1057, 184);
            this.lsbAeroports.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.scénarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerLeScénarioToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerLeScénarioToolStripMenuItem
            // 
            this.enregistrerLeScénarioToolStripMenuItem.Name = "enregistrerLeScénarioToolStripMenuItem";
            this.enregistrerLeScénarioToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.enregistrerLeScénarioToolStripMenuItem.Text = "Ouvrir...";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous...";
            // 
            // scénarioToolStripMenuItem
            // 
            this.scénarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effacerToolStripMenuItem});
            this.scénarioToolStripMenuItem.Name = "scénarioToolStripMenuItem";
            this.scénarioToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.scénarioToolStripMenuItem.Text = "Scénario";
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.effacerToolStripMenuItem.Text = "Effacer";
            // 
            // grpAeronefs
            // 
            this.grpAeronefs.Controls.Add(this.txtEntretient);
            this.grpAeronefs.Controls.Add(this.txtUnload);
            this.grpAeronefs.Controls.Add(this.txtLoad);
            this.grpAeronefs.Controls.Add(this.label10);
            this.grpAeronefs.Controls.Add(this.label9);
            this.grpAeronefs.Controls.Add(this.label8);
            this.grpAeronefs.Controls.Add(this.txtVitesse);
            this.grpAeronefs.Controls.Add(this.label7);
            this.grpAeronefs.Controls.Add(this.cmbTypeAeronef);
            this.grpAeronefs.Controls.Add(this.btnAnnulerAeronef);
            this.grpAeronefs.Controls.Add(this.button5);
            this.grpAeronefs.Controls.Add(this.txtNomAeronef);
            this.grpAeronefs.Controls.Add(this.label5);
            this.grpAeronefs.Controls.Add(this.label6);
            this.grpAeronefs.Controls.Add(this.lsbAeronefs);
            this.grpAeronefs.Location = new System.Drawing.Point(12, 405);
            this.grpAeronefs.Name = "grpAeronefs";
            this.grpAeronefs.Size = new System.Drawing.Size(1070, 348);
            this.grpAeronefs.TabIndex = 11;
            this.grpAeronefs.TabStop = false;
            this.grpAeronefs.Text = "Aéronefs";
            // 
            // txtEntretient
            // 
            this.txtEntretient.Location = new System.Drawing.Point(856, 235);
            this.txtEntretient.Name = "txtEntretient";
            this.txtEntretient.Size = new System.Drawing.Size(97, 26);
            this.txtEntretient.TabIndex = 21;
            // 
            // txtUnload
            // 
            this.txtUnload.Location = new System.Drawing.Point(742, 235);
            this.txtUnload.Name = "txtUnload";
            this.txtUnload.Size = new System.Drawing.Size(97, 26);
            this.txtUnload.TabIndex = 20;
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(630, 235);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(97, 26);
            this.txtLoad.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Load";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(740, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Unload";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Entretient";
            // 
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(518, 235);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(97, 26);
            this.txtVitesse.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vitesse";
            // 
            // cmbTypeAeronef
            // 
            this.cmbTypeAeronef.FormattingEnabled = true;
            this.cmbTypeAeronef.Location = new System.Drawing.Point(320, 234);
            this.cmbTypeAeronef.Name = "cmbTypeAeronef";
            this.cmbTypeAeronef.Size = new System.Drawing.Size(176, 28);
            this.cmbTypeAeronef.TabIndex = 11;
            // 
            // btnAnnulerAeronef
            // 
            this.btnAnnulerAeronef.Location = new System.Drawing.Point(10, 309);
            this.btnAnnulerAeronef.Name = "btnAnnulerAeronef";
            this.btnAnnulerAeronef.Size = new System.Drawing.Size(1052, 31);
            this.btnAnnulerAeronef.TabIndex = 10;
            this.btnAnnulerAeronef.Text = "Annuler";
            this.btnAnnulerAeronef.UseVisualStyleBackColor = true;
            this.btnAnnulerAeronef.Click += new System.EventHandler(this.btnAnnulerAeronef_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(1052, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Ajouter";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtNomAeronef
            // 
            this.txtNomAeronef.Location = new System.Drawing.Point(124, 235);
            this.txtNomAeronef.Name = "txtNomAeronef";
            this.txtNomAeronef.Size = new System.Drawing.Size(176, 26);
            this.txtNomAeronef.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nom";
            // 
            // lsbAeronefs
            // 
            this.lsbAeronefs.FormattingEnabled = true;
            this.lsbAeronefs.ItemHeight = 20;
            this.lsbAeronefs.Location = new System.Drawing.Point(6, 25);
            this.lsbAeronefs.Name = "lsbAeronefs";
            this.lsbAeronefs.Size = new System.Drawing.Size(1057, 184);
            this.lsbAeronefs.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 758);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1052, 31);
            this.button6.TabIndex = 22;
            this.button6.Text = "Générer le scénario";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // GUIGenerateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 798);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.grpAeronefs);
            this.Controls.Add(this.grpAeroports);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUIGenerateur";
            this.Text = "Générateur de scénarios";
            this.Load += new System.EventHandler(this.GUIGenerateur_Load);
            this.grpAeroports.ResumeLayout(false);
            this.grpAeroports.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAeronefs.ResumeLayout(false);
            this.grpAeronefs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAeroports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerLeScénarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scénarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToolStripMenuItem;
        private System.Windows.Forms.Button btnAnnulerAeroport;
        private System.Windows.Forms.Button btnAjouterAeroport;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.TextBox txtNomAeroport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAchMarchandise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAchPassager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbAeroports;
        private System.Windows.Forms.GroupBox grpAeronefs;
        private System.Windows.Forms.TextBox txtEntretient;
        private System.Windows.Forms.TextBox txtUnload;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVitesse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTypeAeronef;
        private System.Windows.Forms.Button btnAnnulerAeronef;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNomAeronef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lsbAeronefs;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosition;
    }
}

