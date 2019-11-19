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
            this.cmbTypeCargo = new System.Windows.Forms.ComboBox();
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
            this.grpAeroports.Location = new System.Drawing.Point(8, 23);
            this.grpAeroports.Margin = new System.Windows.Forms.Padding(2);
            this.grpAeroports.Name = "grpAeroports";
            this.grpAeroports.Padding = new System.Windows.Forms.Padding(2);
            this.grpAeroports.Size = new System.Drawing.Size(713, 226);
            this.grpAeroports.TabIndex = 0;
            this.grpAeroports.TabStop = false;
            this.grpAeroports.Text = "Aéroports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(438, 153);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(137, 20);
            this.txtPosition.TabIndex = 11;
            // 
            // btnAnnulerAeroport
            // 
            this.btnAnnulerAeroport.Location = new System.Drawing.Point(7, 201);
            this.btnAnnulerAeroport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulerAeroport.Name = "btnAnnulerAeroport";
            this.btnAnnulerAeroport.Size = new System.Drawing.Size(701, 20);
            this.btnAnnulerAeroport.TabIndex = 10;
            this.btnAnnulerAeroport.Text = "Annuler";
            this.btnAnnulerAeroport.UseVisualStyleBackColor = true;
            this.btnAnnulerAeroport.Click += new System.EventHandler(this.BtnAnnulerAeroport_Click);
            // 
            // btnAjouterAeroport
            // 
            this.btnAjouterAeroport.Location = new System.Drawing.Point(7, 177);
            this.btnAjouterAeroport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterAeroport.Name = "btnAjouterAeroport";
            this.btnAjouterAeroport.Size = new System.Drawing.Size(701, 20);
            this.btnAjouterAeroport.TabIndex = 9;
            this.btnAjouterAeroport.Text = "Ajouter";
            this.btnAjouterAeroport.UseVisualStyleBackColor = true;
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(579, 152);
            this.btnPosition.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(122, 22);
            this.btnPosition.TabIndex = 8;
            this.btnPosition.Text = "Choisir position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // txtNomAeroport
            // 
            this.txtNomAeroport.Location = new System.Drawing.Point(20, 153);
            this.txtNomAeroport.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomAeroport.Name = "txtNomAeroport";
            this.txtNomAeroport.Size = new System.Drawing.Size(119, 20);
            this.txtNomAeroport.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Achalandage (Marchandise)";
            // 
            // txtAchMarchandise
            // 
            this.txtAchMarchandise.Location = new System.Drawing.Point(284, 153);
            this.txtAchMarchandise.Margin = new System.Windows.Forms.Padding(2);
            this.txtAchMarchandise.Name = "txtAchMarchandise";
            this.txtAchMarchandise.Size = new System.Drawing.Size(137, 20);
            this.txtAchMarchandise.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Achalandage (Passager)";
            // 
            // txtAchPassager
            // 
            this.txtAchPassager.Location = new System.Drawing.Point(151, 153);
            this.txtAchPassager.Margin = new System.Windows.Forms.Padding(2);
            this.txtAchPassager.Name = "txtAchPassager";
            this.txtAchPassager.Size = new System.Drawing.Size(119, 20);
            this.txtAchPassager.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // lsbAeroports
            // 
            this.lsbAeroports.FormattingEnabled = true;
            this.lsbAeroports.Location = new System.Drawing.Point(4, 16);
            this.lsbAeroports.Margin = new System.Windows.Forms.Padding(2);
            this.lsbAeroports.Name = "lsbAeroports";
            this.lsbAeroports.Size = new System.Drawing.Size(706, 121);
            this.lsbAeroports.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.scénarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
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
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerLeScénarioToolStripMenuItem
            // 
            this.enregistrerLeScénarioToolStripMenuItem.Name = "enregistrerLeScénarioToolStripMenuItem";
            this.enregistrerLeScénarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.enregistrerLeScénarioToolStripMenuItem.Text = "Ouvrir...";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous...,";
            // 
            // scénarioToolStripMenuItem
            // 
            this.scénarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effacerToolStripMenuItem});
            this.scénarioToolStripMenuItem.Name = "scénarioToolStripMenuItem";
            this.scénarioToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.scénarioToolStripMenuItem.Text = "Scénario";
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
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
            this.grpAeronefs.Controls.Add(this.cmbTypeCargo);
            this.grpAeronefs.Controls.Add(this.btnAnnulerAeronef);
            this.grpAeronefs.Controls.Add(this.button5);
            this.grpAeronefs.Controls.Add(this.txtNomAeronef);
            this.grpAeronefs.Controls.Add(this.label5);
            this.grpAeronefs.Controls.Add(this.label6);
            this.grpAeronefs.Controls.Add(this.lsbAeronefs);
            this.grpAeronefs.Location = new System.Drawing.Point(8, 263);
            this.grpAeronefs.Margin = new System.Windows.Forms.Padding(2);
            this.grpAeronefs.Name = "grpAeronefs";
            this.grpAeronefs.Padding = new System.Windows.Forms.Padding(2);
            this.grpAeronefs.Size = new System.Drawing.Size(713, 226);
            this.grpAeronefs.TabIndex = 11;
            this.grpAeronefs.TabStop = false;
            this.grpAeronefs.Text = "Aéronefs";
            // 
            // txtEntretient
            // 
            this.txtEntretient.Location = new System.Drawing.Point(571, 153);
            this.txtEntretient.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntretient.Name = "txtEntretient";
            this.txtEntretient.Size = new System.Drawing.Size(66, 20);
            this.txtEntretient.TabIndex = 21;
            // 
            // txtUnload
            // 
            this.txtUnload.Location = new System.Drawing.Point(495, 153);
            this.txtUnload.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnload.Name = "txtUnload";
            this.txtUnload.Size = new System.Drawing.Size(66, 20);
            this.txtUnload.TabIndex = 20;
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(420, 153);
            this.txtLoad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(66, 20);
            this.txtLoad.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Load";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Unload";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Entretient";
            // 
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(345, 153);
            this.txtVitesse.Margin = new System.Windows.Forms.Padding(2);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(66, 20);
            this.txtVitesse.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vitesse";
            // 
            // cmbTypeCargo
            // 
            this.cmbTypeCargo.FormattingEnabled = true;
            this.cmbTypeCargo.Location = new System.Drawing.Point(213, 152);
            this.cmbTypeCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypeCargo.Name = "cmbTypeCargo";
            this.cmbTypeCargo.Size = new System.Drawing.Size(119, 21);
            this.cmbTypeCargo.TabIndex = 11;
            // 
            // btnAnnulerAeronef
            // 
            this.btnAnnulerAeronef.Location = new System.Drawing.Point(7, 201);
            this.btnAnnulerAeronef.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulerAeronef.Name = "btnAnnulerAeronef";
            this.btnAnnulerAeronef.Size = new System.Drawing.Size(701, 20);
            this.btnAnnulerAeronef.TabIndex = 10;
            this.btnAnnulerAeronef.Text = "Annuler";
            this.btnAnnulerAeronef.UseVisualStyleBackColor = true;
            this.btnAnnulerAeronef.Click += new System.EventHandler(this.btnAnnulerAeronef_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 177);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(701, 20);
            this.button5.TabIndex = 9;
            this.button5.Text = "Ajouter";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtNomAeronef
            // 
            this.txtNomAeronef.Location = new System.Drawing.Point(83, 153);
            this.txtNomAeronef.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomAeronef.Name = "txtNomAeronef";
            this.txtNomAeronef.Size = new System.Drawing.Size(119, 20);
            this.txtNomAeronef.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nom";
            // 
            // lsbAeronefs
            // 
            this.lsbAeronefs.FormattingEnabled = true;
            this.lsbAeronefs.Location = new System.Drawing.Point(4, 16);
            this.lsbAeronefs.Margin = new System.Windows.Forms.Padding(2);
            this.lsbAeronefs.Name = "lsbAeronefs";
            this.lsbAeronefs.Size = new System.Drawing.Size(706, 121);
            this.lsbAeronefs.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 493);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(701, 20);
            this.button6.TabIndex = 22;
            this.button6.Text = "Générer le scénario";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // GUIGenerateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 519);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.grpAeronefs);
            this.Controls.Add(this.grpAeroports);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox cmbTypeCargo;
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

