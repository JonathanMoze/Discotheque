namespace projet
{
    partial class Inscription
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
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.pays = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.comboBoxPays = new System.Windows.Forms.ComboBox();
            this.button_inscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(12, 50);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(29, 13);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(15, 86);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(43, 13);
            this.prenom.TabIndex = 1;
            this.prenom.Text = "Prénom";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(18, 128);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(18, 169);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(71, 13);
            this.mdp.TabIndex = 3;
            this.mdp.Text = "Mot de passe";
            // 
            // pays
            // 
            this.pays.AutoSize = true;
            this.pays.Location = new System.Drawing.Point(18, 205);
            this.pays.Name = "pays";
            this.pays.Size = new System.Drawing.Size(30, 13);
            this.pays.TabIndex = 4;
            this.pays.Text = "Pays";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(126, 50);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(126, 86);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(126, 128);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 7;
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(126, 169);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxMDP.TabIndex = 8;
            // 
            // comboBoxPays
            // 
            this.comboBoxPays.FormattingEnabled = true;
            this.comboBoxPays.Location = new System.Drawing.Point(126, 205);
            this.comboBoxPays.Name = "comboBoxPays";
            this.comboBoxPays.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPays.TabIndex = 9;
            // 
            // button_inscription
            // 
            this.button_inscription.Location = new System.Drawing.Point(126, 264);
            this.button_inscription.Name = "button_inscription";
            this.button_inscription.Size = new System.Drawing.Size(109, 31);
            this.button_inscription.TabIndex = 10;
            this.button_inscription.Text = "Inscription";
            this.button_inscription.UseVisualStyleBackColor = true;
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_inscription);
            this.Controls.Add(this.comboBoxPays);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.pays);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Label pays;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.ComboBox comboBoxPays;
        private System.Windows.Forms.Button button_inscription;
    }
}