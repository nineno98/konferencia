namespace konferencia_GUI
{
    partial class Form1
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
            this.jobbnyil = new System.Windows.Forms.Button();
            this.ballnyil = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.pictureBoxKolto = new System.Windows.Forms.PictureBox();
            this.panelErtekeles = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).BeginInit();
            this.SuspendLayout();
            // 
            // jobbnyil
            // 
            this.jobbnyil.BackgroundImage = global::konferencia_GUI.Properties.Resources.jobb;
            this.jobbnyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobbnyil.Location = new System.Drawing.Point(161, 218);
            this.jobbnyil.Name = "jobbnyil";
            this.jobbnyil.Size = new System.Drawing.Size(75, 70);
            this.jobbnyil.TabIndex = 1;
            this.jobbnyil.UseVisualStyleBackColor = true;
            this.jobbnyil.Click += new System.EventHandler(this.jobbnyil_Click);
            // 
            // ballnyil
            // 
            this.ballnyil.BackgroundImage = global::konferencia_GUI.Properties.Resources.bal;
            this.ballnyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ballnyil.Location = new System.Drawing.Point(33, 218);
            this.ballnyil.Name = "ballnyil";
            this.ballnyil.Size = new System.Drawing.Size(74, 70);
            this.ballnyil.TabIndex = 2;
            this.ballnyil.UseVisualStyleBackColor = true;
            this.ballnyil.Click += new System.EventHandler(this.ballnyil_Click);
            // 
            // mentes
            // 
            this.mentes.BackgroundImage = global::konferencia_GUI.Properties.Resources.ment;
            this.mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mentes.Location = new System.Drawing.Point(104, 318);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(65, 64);
            this.mentes.TabIndex = 3;
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // pictureBoxKolto
            // 
            this.pictureBoxKolto.Location = new System.Drawing.Point(88, 48);
            this.pictureBoxKolto.Name = "pictureBoxKolto";
            this.pictureBoxKolto.Size = new System.Drawing.Size(118, 141);
            this.pictureBoxKolto.TabIndex = 4;
            this.pictureBoxKolto.TabStop = false;
            // 
            // panelErtekeles
            // 
            this.panelErtekeles.Location = new System.Drawing.Point(299, 61);
            this.panelErtekeles.Name = "panelErtekeles";
            this.panelErtekeles.Size = new System.Drawing.Size(431, 331);
            this.panelErtekeles.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelErtekeles);
            this.Controls.Add(this.pictureBoxKolto);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.ballnyil);
            this.Controls.Add(this.jobbnyil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button jobbnyil;
        private System.Windows.Forms.Button ballnyil;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.PictureBox pictureBoxKolto;
        private System.Windows.Forms.Panel panelErtekeles;
    }
}

