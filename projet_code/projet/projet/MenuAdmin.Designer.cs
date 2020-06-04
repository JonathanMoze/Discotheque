namespace projet
{
    partial class MenuAdmin
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
            this.aboInactifs = new System.Windows.Forms.Button();
            this.retardsEmprunts = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.infoAdmin.TabIndex = 0;
            this.infoAdmin.Text = "Session Administrateur";
            // 
            // aboInactifs
            // 
            this.aboInactifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aboInactifs.Location = new System.Drawing.Point(157, 113);
            this.aboInactifs.Margin = new System.Windows.Forms.Padding(2);
            this.aboInactifs.Name = "aboInactifs";
            this.aboInactifs.Size = new System.Drawing.Size(265, 37);
            this.aboInactifs.TabIndex = 1;
            this.aboInactifs.Text = "Gérer les abonnés inactifs";
            this.aboInactifs.UseVisualStyleBackColor = true;
            this.aboInactifs.Click += new System.EventHandler(this.aboInactifs_Click);
            // 
            // retardsEmprunts
            // 
            this.retardsEmprunts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.retardsEmprunts.Location = new System.Drawing.Point(157, 188);
            this.retardsEmprunts.Margin = new System.Windows.Forms.Padding(2);
            this.retardsEmprunts.Name = "retardsEmprunts";
            this.retardsEmprunts.Size = new System.Drawing.Size(265, 37);
            this.retardsEmprunts.TabIndex = 2;
            this.retardsEmprunts.Text = "Gérer les emprunts non rapportés";
            this.retardsEmprunts.UseVisualStyleBackColor = true;
            this.retardsEmprunts.Click += new System.EventHandler(this.retardsEmprunts_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.button4.Location = new System.Drawing.Point(234, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 22);
            this.button4.TabIndex = 5;
            this.button4.Text = "Page précédente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.retardsEmprunts);
            this.Controls.Add(this.aboInactifs);
            this.Controls.Add(this.infoAdmin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoAdmin;
        private System.Windows.Forms.Button aboInactifs;
        private System.Windows.Forms.Button retardsEmprunts;
        private System.Windows.Forms.Button button4;
    }
}