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
            this.Titre = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.listAlbums = new System.Windows.Forms.ListBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(310, 20);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(167, 32);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Mes albums";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(45, 173);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(43, 17);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(122, 173);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 22);
            this.LoginBox.TabIndex = 2;
            // 
            // listAlbums
            // 
            this.listAlbums.FormattingEnabled = true;
            this.listAlbums.ItemHeight = 16;
            this.listAlbums.Location = new System.Drawing.Point(374, 112);
            this.listAlbums.Name = "listAlbums";
            this.listAlbums.Size = new System.Drawing.Size(366, 388);
            this.listAlbums.TabIndex = 3;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(119, 295);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(103, 25);
            this.buttonConnexion.TabIndex = 4;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(32, 217);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(69, 17);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(122, 217);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 22);
            this.PassBox.TabIndex = 6;
            // 
            // MesEmprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 562);
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

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.ListBox listAlbums;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassBox;
    }
}