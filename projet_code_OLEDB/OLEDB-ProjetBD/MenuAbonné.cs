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
    public partial class MenuAbonné : Form
    {
        public MenuAbonné()
        {
            InitializeComponent();           
        }
        #region Aller à la page inscription
        //Bouton pour aller à la page pour inscrire un abonné
        private void button2_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runInscription)).Start();
            this.Close();
        }
        private void runInscription()
        {
            Application.Run(new Inscription());
        }
        #endregion

        #region Aller à la page emprunter
        //Bouton pour aller à la page pour emprunter un album
        private void button1_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runEmprunt)).Start();
            this.Close();
        }
        private void runEmprunt()
        {
            Application.Run(new Emprunt());
        }
        #endregion

        #region Aller à la page MesEmrpunts
        //Bouton pour aller à la page pour voir les albums empruntés
        private void button3_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runMesEmprunts)).Start();
            this.Close();
        }
        private void runMesEmprunts()
        {
            Application.Run(new MesEmprunts());
        }
        #endregion

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
    }
}
