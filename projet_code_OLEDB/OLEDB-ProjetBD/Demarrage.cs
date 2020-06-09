using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLEDB_ProjetBD
{
    public partial class Demarrage : Form
    {
        public Demarrage()
        {
            InitializeComponent();
        }

        private void AboBouton_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runMenuAbonné)).Start();
            this.Close();
        }

        private void AdminBouton_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runMenuAdmin)).Start();
            this.Close();
        }

        private void runMenuAbonné()
        {
            Application.Run(new MenuAbonné());
        }

        private void runMenuAdmin()
        {
            Application.Run(new MenuAdmin());
        }

        
    }
}
