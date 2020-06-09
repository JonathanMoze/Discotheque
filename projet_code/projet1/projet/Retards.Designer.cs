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
            this.login = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.emprunt = new System.Windows.Forms.Label();
            this.listRetards = new System.Windows.Forms.ListBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoAdmin
            // 
            this.infoAdmin.AutoSize = true;
            this.infoAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoAdmin.Location = new System.Drawing.Point(9, 7);
            this.infoAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoAdmin.Name = "infoAdmin";
            this.infoAdmin.Size = new System.Drawing.Size(113, 13);
            this.infoAdmin.TabIndex = 1;
            this.infoAdmin.Text = "Session Administrateur";
            // 
            // titreRetards
            // 
            this.titreRetards.AutoSize = true;
            this.titreRetards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreRetards.Location = new System.Drawing.Point(45, 41);
            this.titreRetards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titreRetards.Name = "titreRetards";
            this.titreRetards.Size = new System.Drawing.Size(529, 18);
            this.titreRetards.TabIndex = 2;
            this.titreRetards.Text = "Liste des abonnés ayant un retard de plus de 10 jours sur le retour d\'un emprunt";
            // 
            // listAbo
            // 
            this.listAbo.FormattingEnabled = true;
            this.listAbo.Location = new System.Drawing.Point(31, 114);
            this.listAbo.Margin = new System.Windows.Forms.Padding(2);
            this.listAbo.Name = "listAbo";
            this.listAbo.Size = new System.Drawing.Size(193, 199);
            this.listAbo.TabIndex = 3;
            this.listAbo.SelectedIndexChanged += new System.EventHandler(this.listAbo_SelectedIndexChanged);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(273, 111);
            this.login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(336, 108);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(111, 20);
            this.textBoxLogin.TabIndex = 6;
            // 
            // emprunt
            // 
            this.emprunt.AutoSize = true;
            this.emprunt.Location = new System.Drawing.Point(302, 184);
            this.emprunt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(102, 13);
            this.emprunt.TabIndex = 8;
            this.emprunt.Text = "Emprunts en retard :";
            // 
            // listRetards
            // 
            this.listRetards.FormattingEnabled = true;
            this.listRetards.Location = new System.Drawing.Point(305, 212);
            this.listRetards.Margin = new System.Windows.Forms.Padding(2);
            this.listRetards.Name = "listRetards";
            this.listRetards.Size = new System.Drawing.Size(197, 108);
            this.listRetards.TabIndex = 9;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(31, 95);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(68, 13);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Nom Prénom";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.menu_Click);
            // 
            // Retards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.listRetards);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.login);
            this.Controls.Add(this.listAbo);
            this.Controls.Add(this.titreRetards);
            this.Controls.Add(this.infoAdmin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Retards";
            this.Text = "Retards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoAdmin;
        private System.Windows.Forms.Label titreRetards;
        private System.Windows.Forms.ListBox listAbo;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label emprunt;
        private System.Windows.Forms.ListBox listRetards;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button button2;
    }
}