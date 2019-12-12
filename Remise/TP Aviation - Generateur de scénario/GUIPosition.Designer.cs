namespace TP_Aviation___Generateur_de_scénario
{
    partial class GUIPosition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbWorldmap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWorldmap)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbWorldmap
            // 
            this.pcbWorldmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbWorldmap.Image = global::TP_Aviation___Generateur_de_scénario.Properties.Resources.worldmap_good;
            this.pcbWorldmap.Location = new System.Drawing.Point(-2, -2);
            this.pcbWorldmap.Name = "pcbWorldmap";
            this.pcbWorldmap.Size = new System.Drawing.Size(1500, 768);
            this.pcbWorldmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbWorldmap.TabIndex = 0;
            this.pcbWorldmap.TabStop = false;
            this.pcbWorldmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PcbWorldmap_MouseClick);
            // 
            // GUIPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 766);
            this.Controls.Add(this.pcbWorldmap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUIPosition";
            this.Text = "GUIPosition";
            ((System.ComponentModel.ISupportInitialize)(this.pcbWorldmap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbWorldmap;
    }
}