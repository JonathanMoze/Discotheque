namespace projet
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
            this.buttonProlonger = new System.Windows.Forms.Button();
            this.checkBoxEmprunt = new System.Windows.Forms.CheckBox();
            this.buttonPrologerAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(86, 186);
            this.PassBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(76, 20);
            this.PassBox.TabIndex = 13;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(18, 186);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(53, 13);
            this.PassLabel.TabIndex = 12;
            this.PassLabel.Text = "Password";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(86, 270);
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
            this.listAlbums.Location = new System.Drawing.Point(275, 76);
            this.listAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listAlbums.Name = "listAlbums";
            this.listAlbums.Size = new System.Drawing.Size(276, 316);
            this.listAlbums.TabIndex = 10;
            this.listAlbums.SelectedIndexChanged += new System.EventHandler(this.listAlbums_SelectedIndexChanged);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(86, 151);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(76, 20);
            this.LoginBox.TabIndex = 9;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(28, 151);
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
            this.menu.Location = new System.Drawing.Point(21, 415);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 14;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Emprunter un album";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProlonger
            // 
            this.buttonProlonger.Location = new System.Drawing.Point(86, 295);
            this.buttonProlonger.Name = "buttonProlonger";
            this.buttonProlonger.Size = new System.Drawing.Size(77, 23);
            this.buttonProlonger.TabIndex = 16;
            this.buttonProlonger.Text = "Prolonger";
            this.buttonProlonger.UseVisualStyleBackColor = true;
            this.buttonProlonger.Click += new System.EventHandler(this.buttonProlonger_Click);
            // 
            // checkBoxEmprunt
            // 
            this.checkBoxEmprunt.AutoSize = true;
            this.checkBoxEmprunt.Location = new System.Drawing.Point(275, 415);
            this.checkBoxEmprunt.Name = "checkBoxEmprunt";
            this.checkBoxEmprunt.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEmprunt.TabIndex = 17;
            this.checkBoxEmprunt.Text = "En cours";
            this.checkBoxEmprunt.UseVisualStyleBackColor = true;
            this.checkBoxEmprunt.CheckedChanged += new System.EventHandler(this.checkBoxEmprunt_CheckedChanged);
            // 
            // buttonPrologerAll
            // 
            this.buttonPrologerAll.Location = new System.Drawing.Point(86, 324);
            this.buttonPrologerAll.Name = "buttonPrologerAll";
            this.buttonPrologerAll.Size = new System.Drawing.Size(77, 35);
            this.buttonPrologerAll.TabIndex = 18;
            this.buttonPrologerAll.Text = "Prolonger tout";
            this.buttonPrologerAll.UseVisualStyleBackColor = true;
            this.buttonPrologerAll.Click += new System.EventHandler(this.buttonPrologerAll_Click);
            // 
            // MesEmprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.buttonPrologerAll);
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
        private System.Windows.Forms.Button buttonProlonger;
        private System.Windows.Forms.CheckBox checkBoxEmprunt;
        private System.Windows.Forms.Button buttonPrologerAll;
    }
}