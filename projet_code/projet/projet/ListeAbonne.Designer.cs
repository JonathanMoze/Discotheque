namespace projet
{
    partial class ListeAbonne
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.infoAdmin = new System.Windows.Forms.Label();
            this.titreRetards = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SupprimerAbo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(451, 259);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(13, 13);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "  ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Supprimer tous les anciens abonnés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 108);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.menu_Click);
            // 
            // infoAdmin
            // 
            this.infoAdmin.AutoSize = true;
            this.infoAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoAdmin.Location = new System.Drawing.Point(11, 9);
            this.infoAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoAdmin.Name = "infoAdmin";
            this.infoAdmin.Size = new System.Drawing.Size(113, 13);
            this.infoAdmin.TabIndex = 9;
            this.infoAdmin.Text = "Session Administrateur";
            // 
            // titreRetards
            // 
            this.titreRetards.AutoSize = true;
            this.titreRetards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreRetards.Location = new System.Drawing.Point(211, 27);
            this.titreRetards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titreRetards.Name = "titreRetards";
            this.titreRetards.Size = new System.Drawing.Size(178, 18);
            this.titreRetards.TabIndex = 10;
            this.titreRetards.Text = "Liste des abonnés inactifs";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(335, 119);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(10, 13);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sélectionnez un abonné pour voir sa dernière date d\'emprunt";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(15, 259);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(374, 95);
            this.listBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Abonnés inactifs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tous les abonnés";
            // 
            // SupprimerAbo
            // 
            this.SupprimerAbo.Location = new System.Drawing.Point(356, 170);
            this.SupprimerAbo.Name = "SupprimerAbo";
            this.SupprimerAbo.Size = new System.Drawing.Size(186, 30);
            this.SupprimerAbo.TabIndex = 16;
            this.SupprimerAbo.Text = "Supprimer l\'abonné";
            this.SupprimerAbo.UseVisualStyleBackColor = true;
            this.SupprimerAbo.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListeAbonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SupprimerAbo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.titreRetards);
            this.Controls.Add(this.infoAdmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "ListeAbonne";
            this.Text = "ListeAbonne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label infoAdmin;
        private System.Windows.Forms.Label titreRetards;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SupprimerAbo;
    }
}