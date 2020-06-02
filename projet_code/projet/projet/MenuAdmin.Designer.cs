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
            this.SuspendLayout();
            // 
            // infoAdmin
            // 
            this.infoAdmin.AutoSize = true;
            this.infoAdmin.Location = new System.Drawing.Point(12, 9);
            this.infoAdmin.Name = "infoAdmin";
            this.infoAdmin.Size = new System.Drawing.Size(153, 17);
            this.infoAdmin.TabIndex = 0;
            this.infoAdmin.Text = "Session Administrateur";
            // 
            // aboInactifs
            // 
            this.aboInactifs.Location = new System.Drawing.Point(238, 139);
            this.aboInactifs.Name = "aboInactifs";
            this.aboInactifs.Size = new System.Drawing.Size(285, 46);
            this.aboInactifs.TabIndex = 1;
            this.aboInactifs.Text = "Gérer les abonnés inactifs";
            this.aboInactifs.UseVisualStyleBackColor = true;
            // 
            // retardsEmprunts
            // 
            this.retardsEmprunts.Location = new System.Drawing.Point(238, 230);
            this.retardsEmprunts.Name = "retardsEmprunts";
            this.retardsEmprunts.Size = new System.Drawing.Size(285, 46);
            this.retardsEmprunts.TabIndex = 2;
            this.retardsEmprunts.Text = "Gérer les emprunts non rapportés";
            this.retardsEmprunts.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retardsEmprunts);
            this.Controls.Add(this.aboInactifs);
            this.Controls.Add(this.infoAdmin);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoAdmin;
        private System.Windows.Forms.Button aboInactifs;
        private System.Windows.Forms.Button retardsEmprunts;
    }
}