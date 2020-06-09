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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.pays = new System.Windows.Forms.Label();
            this.comboBoxPays = new System.Windows.Forms.ComboBox();
            this.button_inscription = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.emprunt = new System.Windows.Forms.Button();
            this.infoAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(285, 75);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(191, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(285, 108);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(191, 20);
            this.textBoxPrenom.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(285, 141);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(191, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(285, 175);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(191, 20);
            this.textBoxMDP.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(139, 75);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(29, 13);
            this.nom.TabIndex = 4;
            this.nom.Text = "Nom";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(139, 108);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(43, 13);
            this.prenom.TabIndex = 5;
            this.prenom.Text = "Prénom";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(139, 141);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(139, 182);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(71, 13);
            this.mdp.TabIndex = 7;
            this.mdp.Text = "Mot de passe";
            // 
            // pays
            // 
            this.pays.AutoSize = true;
            this.pays.Location = new System.Drawing.Point(139, 218);
            this.pays.Name = "pays";
            this.pays.Size = new System.Drawing.Size(30, 13);
            this.pays.TabIndex = 8;
            this.pays.Text = "Pays";
            // 
            // comboBoxPays
            // 
            this.comboBoxPays.FormattingEnabled = true;
            this.comboBoxPays.Location = new System.Drawing.Point(285, 210);
            this.comboBoxPays.Name = "comboBoxPays";
            this.comboBoxPays.Size = new System.Drawing.Size(191, 21);
            this.comboBoxPays.TabIndex = 10;
            // 
            // button_inscription
            // 
            this.button_inscription.Location = new System.Drawing.Point(239, 297);
            this.button_inscription.Name = "button_inscription";
            this.button_inscription.Size = new System.Drawing.Size(109, 31);
            this.button_inscription.TabIndex = 11;
            this.button_inscription.Text = "Inscription";
            this.button_inscription.UseVisualStyleBackColor = true;
            this.button_inscription.Click += new System.EventHandler(this.button_inscription_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(513, 331);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 12;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(246, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inscription";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(203, 265);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(198, 13);
            this.labelMessage.TabIndex = 14;
            this.labelMessage.Text = "Veuillez remplir les informations ci-dessus";
            // 
            // emprunt
            // 
            this.emprunt.Location = new System.Drawing.Point(12, 331);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(109, 23);
            this.emprunt.TabIndex = 15;
            this.emprunt.Text = "Emprunter un album";
            this.emprunt.UseVisualStyleBackColor = true;
            this.emprunt.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoAdmin
            // 
            this.infoAdmin.AutoSize = true;
            this.infoAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoAdmin.Location = new System.Drawing.Point(11, 9);
            this.infoAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoAdmin.Name = "infoAdmin";
            this.infoAdmin.Size = new System.Drawing.Size(84, 13);
            this.infoAdmin.TabIndex = 21;
            this.infoAdmin.Text = "Session Abonné";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.infoAdmin);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.button_inscription);
            this.Controls.Add(this.comboBoxPays);
            this.Controls.Add(this.pays);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Label pays;
        private System.Windows.Forms.ComboBox comboBoxPays;
        private System.Windows.Forms.Button button_inscription;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button emprunt;
        private System.Windows.Forms.Label infoAdmin;
    }
}