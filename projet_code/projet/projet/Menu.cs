﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
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


    }
}
