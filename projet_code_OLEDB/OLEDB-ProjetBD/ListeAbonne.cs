using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLEDB_ProjetBD
{
    public partial class ListeAbonne : Form
    {
        OleDbConnection dbCon;

        public ListeAbonne()
        {
            InitializeComponent();
            InitConnexion();
            ChargerAbonne();
            ChargerAbonneinactif();
            YaTilAbonnésInactifs();
            SupprimerAbo.Enabled = false;
            labelMessage.ForeColor = Color.Red;
           
        }
        public void InitConnexion()
        {
            #region Connexion serveur local
            dbCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            dbCon.Open();
            #endregion
        }
        public void YaTilAbonnésInactifs()
        {
            if (listBox1.Items.Count == 0)
            {
                button1.Enabled = false;
                AboIn.Text = "Il n'y a pas d'abonné inactif.";
                AboIn.ForeColor = Color.Blue;
            }
            else
            {
                button1.Enabled = true;
                AboIn.Text = " ";
            }
        }

        public void ChargerAbonne()
        {
            #region Chargement des Abonnés
            // récupération de l'ensemble des abonnés
            string sql = "Select distinct Abonné.Code_Abonné, Nom_Abonné, Prénom_Abonné " +
                "from Abonné" +
                " Order By Nom_Abonné";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // on récupère id, nom, prenom   
                int Code_Abonné = reader.GetInt32(0);
                string Nom_Abonne = reader.GetString(1);
                string Prenom_Abonne = reader.GetString(2);

                Abonné j = new Abonné();
                string nom = "Sans nom";
                if (Nom_Abonne != null)
                {
                    string[] v = System.Text.RegularExpressions.Regex.Split(Nom_Abonne, "  ");
                    nom = v[0];
                }
                string prenom = "Sans nom";
                if (Prenom_Abonne != null)
                {
                    string[] v = System.Text.RegularExpressions.Regex.Split(Prenom_Abonne, "  ");
                    prenom = v[0];
                }
               
                // Ajout dans la ListBox
                j.Code_Abonné = Code_Abonné;
                j.Prénom_Abonné = prenom;
                j.Nom_Abonné = nom;
                if (dateEmpruntPlusRecente(j).ToString() == "01/01/0001 00:00:00")
                {
                    listBox2.Items.Add(j + " - Pas d'emprunt");
                }
                else
                {                    
                    listBox2.Items.Add(j + " - " + dateEmpruntPlusRecente(j));
                }
                
            }
            reader.Close();
            #endregion
        }

        private DateTime dateEmpruntPlusRecente (Abonné a)
        {
            #region Trouver la date la plus récente
            DateTime dateARenvoyer = new DateTime();
            string dateDernierEmprunt = " Select Date_emprunt " +
                "from Emprunter" +
                " inner join Album on Album.Code_Album = Emprunter.Code_Album" +
                " inner join Abonné on Abonné.Code_Abonné = Emprunter.Code_Abonné" +
                " where Emprunter.Code_Abonné = " + a.Code_Abonné
                + " Order By Date_Emprunt";
            OleDbCommand cmd = new OleDbCommand(dateDernierEmprunt, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dateARenvoyer = reader.GetDateTime(0);
            }
            return dateARenvoyer;
            #endregion
        }

        public void ChargerAbonneinactif()
        {
            #region Chargement des Abonnés inactifs
            YaTilAbonnésInactifs();
            // récupération de l'ensemble des abonné inactif
            string sql2 = "Select Distinct Abonné.Code_Abonné, Nom_Abonné, Prénom_Abonné " +
                "from Abonné" +
                " inner join Emprunter on Emprunter.Code_Abonné = Abonné.Code_Abonné" +
                " inner join Album on Album.Code_Album = Emprunter.Code_Album " +
                "Where DATEDIFF(day, Date_Emprunt, GETDATE()) > 365 ";
            OleDbCommand cmd = new OleDbCommand(sql2, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // on récupère nom et prénom
                int Code_Abonné = reader.GetInt32(0);
                string Nom_Abonne = reader.GetString(1);
                string Prenom_Abonne = reader.GetString(2);
                Abonné a = new Abonné();
                // Ajout dans la ListBox
                a.Code_Abonné = Code_Abonné;
                a.Prénom_Abonné = Prenom_Abonne;
                a.Nom_Abonné = Nom_Abonne;

                listBox1.Items.Add(a);
            }
            reader.Close();
            #endregion
        }

        private void SupprimerAbo_Click(object sender, EventArgs e)
        {
            #region Supprimer un Abonné
            if (listBox1.SelectedItem != null)
            {
                // récupération Abonné  sélectionné
                Abonné a = (Abonné)listBox1.SelectedItem;
                PopUpMessageNonRendu(a);
                listBox1.Items.Clear();
                ChargerAbonneinactif();
                listBox2.Items.Clear();
                ChargerAbonne();
            }
            else
            {
                labelMessage.Text = "Erreur ! ";
            }
            #endregion
        }

        private void SupprimerUnAbo(int CodeAbo)
        {
            #region Supprimer l'abonné qui a le même code abonné
            int id = CodeAbo;
            string deleteEmprunt = "delete from Emprunter where Emprunter.Code_Abonné = " + id.ToString();
            string deleteAbo = "delete from Abonné where Abonné.Code_Abonné = " + id.ToString();
            try
            {
                OleDbCommand cmdEm = new OleDbCommand(deleteEmprunt, dbCon);
                cmdEm.ExecuteNonQuery();
                OleDbCommand cmdAbo = new OleDbCommand(deleteAbo, dbCon);
                cmdAbo.ExecuteNonQuery();
                labelDate.Text = " ";
                SupprimerAbo.Enabled = false;
                
            }
            catch
            {
                labelMessage.Text = "Erreur !";
            }
            #endregion
        }

        //supprimer toute la liste
        private void button1_Click(object sender, EventArgs e)
        {
            #region Supprimer toute la liste des Abonnés inactifs
            foreach (Abonné a in listBox1.Items)
            {
                PopUpMessageNonRendu(a);
            }
            listBox1.Items.Clear();
            ChargerAbonneinactif();
            listBox2.Items.Clear();
            ChargerAbonne();
            #endregion
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Sélectionner un abonné dans la liste des inactifs
            SupprimerAbo.Enabled = true;
            Abonné ab = (Abonné)listBox1.SelectedItem;
            if (listBox1.SelectedItems != null && ab != null)
            {
                string date = "select Date_Emprunt " +
                    "from Emprunter " +
                    "inner join Abonné on Abonné.Code_Abonné = Emprunter.Code_Abonné" +
                    " inner join Album on Album.Code_Album = Emprunter.Code_Album " +
                    " where Abonné.Code_Abonné like " + ab.Code_Abonné;
                OleDbCommand cmd = new OleDbCommand(date, dbCon);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    labelDate.Text = " Dernier emprunt le " + reader.GetDateTime(0).ToString();
                    labelDate.ForeColor = Color.Blue;
                }
                reader.Close();   
            }
            #endregion
        }
        private void PopUpMessageNonRendu(Abonné a)
        {
            #region Pop up qui d'affiche si un abonné qu'on veut supprimer, n'a pas rendu son album
            string nonRetour = "Select Emprunter.Code_Abonné " +
                "from Emprunter " +
                "inner join Abonné on Abonné.Code_Abonné = Emprunter.Code_Abonné " +
                "inner join Album on Album.Code_Album = Emprunter.Code_Album " +
                "where Emprunter.Date_Retour is null and DATEDIFF(day, Date_Emprunt, GETDATE()) > 365 ";
            OleDbCommand cmd = new OleDbCommand(nonRetour, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) != 0)
                {
                    string message = a.Nom_Abonné + " " + a.Prénom_Abonné + " n'a pas rendu tous ses albums empruntés, voulez vous quand même le supprimer";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show(message, "Erreur", buttons);
                    if (result == DialogResult.Yes)
                    {
                        SupprimerUnAbo(a.Code_Abonné);
                        labelMessage.Text = "Supression OK";
                    }                    
                }
                else
                {
                    SupprimerUnAbo(a.Code_Abonné);
                    labelMessage.Text = "Supression OK";
                }
            }
            reader.Close();
            #endregion
        }

        # region Bouton retourner au menu
        private void menu_Click(object sender, EventArgs e)
        {
            #region Retourner au menu principal 
            new System.Threading.Thread(new System.Threading.ThreadStart(runMenuAdmin)).Start();
            this.Close();
            #endregion
        }
        private void runMenuAdmin()
        {
            Application.Run(new MenuAdmin());
        }
        #endregion
        
    }
}

