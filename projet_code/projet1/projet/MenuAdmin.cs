using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void retardsEmprunts_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runRetards)).Start();
            this.Close();
        }

        private void runRetards()
        {
            Application.Run(new Retards());
        }

        #region Aller à la page démarrage
        private void button4_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runDemarrage)).Start();
            this.Close();
        }
        private void runDemarrage()
        {
            Application.Run(new Demarrage());
        }
        #endregion

        private void aboInactifs_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runListeAbo)).Start();
            this.Close();
        }

        private void runListeAbo()
        {
            Application.Run(new ListeAbonne());
        }
    }
}
