namespace projet
{
    partial class Retards
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
            this.infoAdmin = new System.Windows.Forms.Label();
            this.titreRetards = new System.Windows.Forms.Label();
            this.listAbo = new System.Windows.Forms.ListBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.emprunt = new System.Windows.Forms.Label();
            this.listRetards = new System.Windows.Forms.ListBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoAdmin
            // 
            this.infoAdmin.AutoSize = true;
            this.infoAdmin.Location = new System.Drawing.Point(12, 9);
            this.infoAdmin.Name = "infoAdmin";
            this.infoAdmin.Size = new System.Drawing.Size(153, 17);
            this.infoAdmin.TabIndex = 1;
            this.infoAdmin.Text = "Session Administrateur";
            // 
            // titreRetards
            // 
            this.titreRetards.AutoSize = true;
            this.titreRetards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreRetards.Location = new System.Drawing.Point(60, 51);
            this.titreRetards.Name = "titreRetards";
            this.titreRetards.Size = new System.Drawing.Size(679, 24);
            this.titreRetards.TabIndex = 2;
            this.titreRetards.Text = "Liste des abonnés ayant un retard de plus de 10 jours sur le retour d\'un emprunt";
            // 
            // listAbo
            // 
            this.listAbo.FormattingEnabled = true;
            this.listAbo.ItemHeight = 16;
            this.listAbo.Location = new System.Drawing.Point(41, 140);
            this.listAbo.Name = "listAbo";
            this.listAbo.Size = new System.Drawing.Size(256, 244);
            this.listAbo.TabIndex = 3;
            this.listAbo.SelectedIndexChanged += new System.EventHandler(this.listAbo_SelectedIndexChanged);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(364, 137);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(37, 17);
            this.nom.TabIndex = 4;
            this.nom.Text = "Nom";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(576, 137);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(57, 17);
            this.prenom.TabIndex = 5;
            this.prenom.Text = "Prénom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(407, 134);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(639, 134);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenom.TabIndex = 7;
            // 
            // emprunt
            // 
            this.emprunt.AutoSize = true;
            this.emprunt.Location = new System.Drawing.Point(495, 218);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(138, 17);
            this.emprunt.TabIndex = 8;
            this.emprunt.Text = "Emprunts en retard :";
            // 
            // listRetards
            // 
            this.listRetards.FormattingEnabled = true;
            this.listRetards.ItemHeight = 16;
            this.listRetards.Location = new System.Drawing.Point(457, 261);
            this.listRetards.Name = "listRetards";
            this.listRetards.Size = new System.Drawing.Size(211, 132);
            this.listRetards.TabIndex = 9;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(41, 117);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(137, 17);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Login des abonnés :";
            // 
            // Retards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.listRetards);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.listAbo);
            this.Controls.Add(this.titreRetards);
            this.Controls.Add(this.infoAdmin);
            this.Name = "Retards";
            this.Text = "Retards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoAdmin;
        private System.Windows.Forms.Label titreRetards;
        private System.Windows.Forms.ListBox listAbo;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label emprunt;
        private System.Windows.Forms.ListBox listRetards;
        private System.Windows.Forms.Label loginLabel;
    }
}