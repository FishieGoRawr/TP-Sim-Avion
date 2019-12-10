namespace TP_Aviation___Simulation
{
    partial class GUISimulateur
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
            this.pcbWorldmap = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChargerScenario = new System.Windows.Forms.Button();
            this.lsbAreoport = new System.Windows.Forms.ListBox();
            this.lsbClient = new System.Windows.Forms.ListBox();
            this.lsbAvion = new System.Windows.Forms.ListBox();
            this.lblAreoport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHorloge = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWorldmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbWorldmap
            // 
            this.pcbWorldmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbWorldmap.Image = global::TP_Aviation___Simulation.Properties.Resources.worldmap_good;
            this.pcbWorldmap.Location = new System.Drawing.Point(12, 386);
            this.pcbWorldmap.Name = "pcbWorldmap";
            this.pcbWorldmap.Size = new System.Drawing.Size(1500, 768);
            this.pcbWorldmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbWorldmap.TabIndex = 1;
            this.pcbWorldmap.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1216, 11);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(296, 69);
            this.trackBar1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(918, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(296, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Démarrer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnChargerScenario
            // 
            this.btnChargerScenario.Location = new System.Drawing.Point(12, 11);
            this.btnChargerScenario.Name = "btnChargerScenario";
            this.btnChargerScenario.Size = new System.Drawing.Size(896, 35);
            this.btnChargerScenario.TabIndex = 5;
            this.btnChargerScenario.Text = "Télécharger un scénario";
            this.btnChargerScenario.UseVisualStyleBackColor = true;
            this.btnChargerScenario.Click += new System.EventHandler(this.BtnChargerScenario_Click);
            // 
            // lsbAreoport
            // 
            this.lsbAreoport.FormattingEnabled = true;
            this.lsbAreoport.ItemHeight = 20;
            this.lsbAreoport.Location = new System.Drawing.Point(12, 91);
            this.lsbAreoport.Name = "lsbAreoport";
            this.lsbAreoport.Size = new System.Drawing.Size(262, 264);
            this.lsbAreoport.TabIndex = 6;
            // 
            // lsbClient
            // 
            this.lsbClient.FormattingEnabled = true;
            this.lsbClient.ItemHeight = 20;
            this.lsbClient.Location = new System.Drawing.Point(297, 91);
            this.lsbClient.Name = "lsbClient";
            this.lsbClient.Size = new System.Drawing.Size(552, 264);
            this.lsbClient.TabIndex = 7;
            // 
            // lsbAvion
            // 
            this.lsbAvion.FormattingEnabled = true;
            this.lsbAvion.ItemHeight = 20;
            this.lsbAvion.Location = new System.Drawing.Point(872, 91);
            this.lsbAvion.Name = "lsbAvion";
            this.lsbAvion.Size = new System.Drawing.Size(640, 264);
            this.lsbAvion.TabIndex = 8;
            // 
            // lblAreoport
            // 
            this.lblAreoport.AutoSize = true;
            this.lblAreoport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAreoport.Location = new System.Drawing.Point(7, 59);
            this.lblAreoport.Name = "lblAreoport";
            this.lblAreoport.Size = new System.Drawing.Size(118, 29);
            this.lblAreoport.TabIndex = 9;
            this.lblAreoport.Text = "Aréoports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(292, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(867, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Avions";
            // 
            // lblHorloge
            // 
            this.lblHorloge.AutoSize = true;
            this.lblHorloge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHorloge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorloge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHorloge.Font = new System.Drawing.Font("MS PGothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorloge.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHorloge.Location = new System.Drawing.Point(685, 1160);
            this.lblHorloge.Name = "lblHorloge";
            this.lblHorloge.Padding = new System.Windows.Forms.Padding(20, 9, 20, 9);
            this.lblHorloge.Size = new System.Drawing.Size(230, 76);
            this.lblHorloge.TabIndex = 12;
            this.lblHorloge.Text = "00 : 00";
            this.lblHorloge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(1434, 361);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(45, 19);
            this.btnTest.TabIndex = 13;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // GUISimulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 1245);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblHorloge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAreoport);
            this.Controls.Add(this.lsbAvion);
            this.Controls.Add(this.lsbClient);
            this.Controls.Add(this.lsbAreoport);
            this.Controls.Add(this.btnChargerScenario);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pcbWorldmap);
            this.Name = "GUISimulateur";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbWorldmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbWorldmap;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChargerScenario;
        private System.Windows.Forms.ListBox lsbAreoport;
        private System.Windows.Forms.ListBox lsbClient;
        private System.Windows.Forms.ListBox lsbAvion;
        private System.Windows.Forms.Label lblAreoport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHorloge;
        private System.Windows.Forms.Button btnTest;
    }
}

