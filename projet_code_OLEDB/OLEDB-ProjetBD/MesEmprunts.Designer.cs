namespace OLEDB_ProjetBD
{
    partial class MesEmprunts
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
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.listAlbums = new System.Windows.Forms.ListBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxEmprunt = new System.Windows.Forms.CheckBox();
            this.buttonProlonger = new System.Windows.Forms.Button();
            this.infoAdmin = new System.Windows.Forms.Label();
            this.buttonPrologerAll = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(84, 118);
            this.PassBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(76, 20);
            this.PassBox.TabIndex = 13;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(16, 118);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(53, 13);
            this.PassLabel.TabIndex = 12;
            this.PassLabel.Text = "Password";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(81, 182);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(77, 20);
            this.buttonConnexion.TabIndex = 11;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // listAlbums
            // 
            this.listAlbums.FormattingEnabled = true;
            this.listAlbums.Location = new System.Drawing.Point(274, 81);
            this.listAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listAlbums.Name = "listAlbums";
            this.listAlbums.Size = new System.Drawing.Size(314, 238);
            this.listAlbums.TabIndex = 10;
            this.listAlbums.Click += new System.EventHandler(this.listAlbums_SelectedIndexChanged);
            this.listAlbums.SelectedIndexChanged += new System.EventHandler(this.listAlbums_SelectedIndexChanged);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(84, 83);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(76, 20);
            this.LoginBox.TabIndex = 9;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(26, 83);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Login";
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(226, 26);
            this.Titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(130, 26);
            this.Titre.TabIndex = 7;
            this.Titre.Text = "Mes albums";
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(513, 331);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 14;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Emprunter un album";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxEmprunt
            // 
            this.checkBoxEmprunt.AutoSize = true;
            this.checkBoxEmprunt.Location = new System.Drawing.Point(84, 225);
            this.checkBoxEmprunt.Name = "checkBoxEmprunt";
            this.checkBoxEmprunt.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEmprunt.TabIndex = 19;
            this.checkBoxEmprunt.Text = "En cours";
            this.checkBoxEmprunt.UseVisualStyleBackColor = true;
            this.checkBoxEmprunt.CheckedChanged += new System.EventHandler(this.checkBoxEmprunt_CheckedChanged);
            // 
            // buttonProlonger
            // 
            this.buttonProlonger.Location = new System.Drawing.Point(14, 257);
            this.buttonProlonger.Name = "buttonProlonger";
            this.buttonProlonger.Size = new System.Drawing.Size(77, 23);
            this.buttonProlonger.TabIndex = 18;
            this.buttonProlonger.Text = "Prolonger";
            this.buttonProlonger.UseVisualStyleBackColor = true;
            this.buttonProlonger.Click += new System.EventHandler(this.buttonProlonger_Click);
            // 
            // infoAdmin
            // 
            this.infoAdmin.AutoSize = true;
            this.infoAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoAdmin.Location = new System.Drawing.Point(11, 9);
            this.infoAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoAdmin.Name = "infoAdmin";
            this.infoAdmin.Size = new System.Drawing.Size(84, 13);
            this.infoAdmin.TabIndex = 20;
            this.infoAdmin.Text = "Session Abonné";
            // 
            // buttonPrologerAll
            // 
            this.buttonPrologerAll.Location = new System.Drawing.Point(136, 257);
            this.buttonPrologerAll.Name = "buttonPrologerAll";
            this.buttonPrologerAll.Size = new System.Drawing.Size(94, 23);
            this.buttonPrologerAll.TabIndex = 21;
            this.buttonPrologerAll.Text = "Prolonger tout";
            this.buttonPrologerAll.UseVisualStyleBackColor = true;
            this.buttonPrologerAll.Click += new System.EventHandler(this.buttonPrologerAll_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(16, 296);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(10, 13);
            this.labelMessage.TabIndex = 22;
            this.labelMessage.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titre album ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date d\'emprunt :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(362, 63);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(16, 13);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "   ";
            // 
            // MesEmprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonPrologerAll);
            this.Controls.Add(this.infoAdmin);
            this.Controls.Add(this.checkBoxEmprunt);
            this.Controls.Add(this.buttonProlonger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.listAlbums);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.Titre);
            this.Name = "MesEmprunts";
            this.Text = "MesEmprunts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.ListBox listAlbums;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxEmprunt;
        private System.Windows.Forms.Button buttonProlonger;
        private System.Windows.Forms.Label infoAdmin;
        private System.Windows.Forms.Button buttonPrologerAll;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDate;
    }
}