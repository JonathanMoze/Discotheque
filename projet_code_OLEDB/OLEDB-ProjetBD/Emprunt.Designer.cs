namespace OLEDB_ProjetBD
{
    partial class Emprunt
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.titreAlbum = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.empruntOK = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.infoAdmin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Emprunter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titreAlbum
            // 
            this.titreAlbum.AutoSize = true;
            this.titreAlbum.Location = new System.Drawing.Point(360, 178);
            this.titreAlbum.Name = "titreAlbum";
            this.titreAlbum.Size = new System.Drawing.Size(13, 13);
            this.titreAlbum.TabIndex = 2;
            this.titreAlbum.Text = "  ";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(363, 132);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 3;
            // 
            // empruntOK
            // 
            this.empruntOK.AutoSize = true;
            this.empruntOK.Location = new System.Drawing.Point(463, 347);
            this.empruntOK.Name = "empruntOK";
            this.empruntOK.Size = new System.Drawing.Size(0, 13);
            this.empruntOK.TabIndex = 5;
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(518, 337);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 6;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rechercher un album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Emprunter un album";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(318, 211);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(274, 13);
            this.labelMessage.TabIndex = 12;
            this.labelMessage.Text = "Veuillez entrer votre login et choisir un album dans la liste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = " ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Voir mes emprunts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "S\'inscrire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ou";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Afficher";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "les albums disponibles uniquement";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(321, 312);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(13, 13);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "  ";
            // 
            // Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.infoAdmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.empruntOK);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.titreAlbum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Emprunt";
            this.Text = "Emprunter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titreAlbum;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label empruntOK;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infoAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDate;
    }
}