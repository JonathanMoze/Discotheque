namespace projet
{
    partial class Demarrage
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
            this.TitreAppli = new System.Windows.Forms.Label();
            this.bienvenue = new System.Windows.Forms.Label();
            this.AboBouton = new System.Windows.Forms.Button();
            this.AdminBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitreAppli
            // 
            this.TitreAppli.AutoSize = true;
            this.TitreAppli.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAppli.Location = new System.Drawing.Point(186, 26);
            this.TitreAppli.Name = "TitreAppli";
            this.TitreAppli.Size = new System.Drawing.Size(390, 44);
            this.TitreAppli.TabIndex = 0;
            this.TitreAppli.Text = "Discothèque En Ligne";
            // 
            // bienvenue
            // 
            this.bienvenue.AutoSize = true;
            this.bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenue.Location = new System.Drawing.Point(304, 91);
            this.bienvenue.Name = "bienvenue";
            this.bienvenue.Size = new System.Drawing.Size(151, 32);
            this.bienvenue.TabIndex = 1;
            this.bienvenue.Text = "Bienvenue";
            // 
            // AboBouton
            // 
            this.AboBouton.Location = new System.Drawing.Point(223, 184);
            this.AboBouton.Name = "AboBouton";
            this.AboBouton.Size = new System.Drawing.Size(311, 40);
            this.AboBouton.TabIndex = 2;
            this.AboBouton.Text = "Je suis Abonné";
            this.AboBouton.UseVisualStyleBackColor = true;
            this.AboBouton.Click += new System.EventHandler(this.AboBouton_Click);
            // 
            // AdminBouton
            // 
            this.AdminBouton.Location = new System.Drawing.Point(223, 255);
            this.AdminBouton.Name = "AdminBouton";
            this.AdminBouton.Size = new System.Drawing.Size(311, 40);
            this.AdminBouton.TabIndex = 3;
            this.AdminBouton.Text = "Je suis Administrateur";
            this.AdminBouton.UseVisualStyleBackColor = true;
            this.AdminBouton.Click += new System.EventHandler(this.AdminBouton_Click);
            // 
            // Demarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminBouton);
            this.Controls.Add(this.AboBouton);
            this.Controls.Add(this.bienvenue);
            this.Controls.Add(this.TitreAppli);
            this.Name = "Demarrage";
            this.Text = "Demarrage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreAppli;
        private System.Windows.Forms.Label bienvenue;
        private System.Windows.Forms.Button AboBouton;
        private System.Windows.Forms.Button AdminBouton;
    }
}