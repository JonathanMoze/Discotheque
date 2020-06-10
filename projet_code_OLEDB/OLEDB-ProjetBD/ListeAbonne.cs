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
            SupprimerAbo.Enabled = false;
            labelMessage.ForeColor = Color.Red;
            if (listBox1.Items.Count == 0)
            {
                button1.Enabled = false;
                labelMessage.Text = "Il n'y a pas d'abonné inactif.";
            }
        }
        public void InitConnexion()
        {
            // Connexion serveur local
            dbCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            dbCon.Open();
        }

        public void ChargerAbonne()
        {
            #region Chargement des Abonnés
            // récupération de l'ensemble des abonnés
            string sql = "Select distinct Abonné.Code_Abonné, Nom_Abonné, Prénom_Abonné from Abonné";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // on récupère id, nom, prenom   
                int Code_Abonné = reader.GetInt32(0);
                string Nom_Abonne = reader.GetString(1);
                string Prenom_Abonne = reader.GetString(2);

                Abonné j = new Abonné();
                // Ajout dans la ListBox
                j.Code_Abonné = Code_Abonné;
                j.Prénom_Abonné = Prenom_Abonne;
                j.Nom_Abonné = Nom_Abonne;
                listBox2.Items.Add(j);
            }
            reader.Close();
            #endregion
        }

        public void ChargerAbonneinactif()
        {
            #region Chargement des Abonnés inactifs
            // récupération de l'ensemble des abonné inactif
            string sql2 = "Select Distinct Abonné.Code_Abonné, Nom_Abonné, Prénom_Abonné " +
                "from Abonné" +
                " inner join Emprunter on Emprunter.Code_Abonné = Abonné.Code_Abonné" +
                " inner join Album on Album.Code_Album = Emprunter.Code_Album " +
                "Where DATEDIFF(day, Date_Emprunt, GETDATE()) > 365";
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
            }
            catch
            {
                labelMessage.Text = "Erreur !";
            }
        }

        //supprimer toute la liste
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Abonné a in listBox1.Items)
            {
                PopUpMessageNonRendu(a);
            }
            listBox1.Items.Clear();
            ChargerAbonneinactif();
            listBox2.Items.Clear();
            ChargerAbonne();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupprimerAbo.Enabled = true;
            if (listBox1.SelectedItems != null)
            {
                Abonné ab = (Abonné)listBox1.SelectedItem;
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
        }
        private void PopUpMessageNonRendu(Abonné a)
        {
            string nonRetour = "Select Emprunter.Code_Abonné from Emprunter inner join Abonné on Abonné.Code_Abonné = Emprunter.Code_Abonné inner join Album on Album.Code_Album = Emprunter.Code_Album where Emprunter.Date_Retour is null ";
            OleDbCommand cmd = new OleDbCommand(nonRetour, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) == 0)
                {
                    SupprimerUnAbo(a.Code_Abonné);
                    labelMessage.Text = "Supression OK";
                }
                else
                {
                    string message = a.Nom_Abonné + " " + a.Prénom_Abonné + " n'a pas rendu tous ses albums empruntés, voulez vous quand même le supprimer";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show(message, "Erreur", buttons);
                    if (result == DialogResult.Yes)
                    {
                        labelMessage.Text = "Supression OK";
                    }
                }
            }
            reader.Close();
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

