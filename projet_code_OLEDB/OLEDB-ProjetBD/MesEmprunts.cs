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
    public partial class MesEmprunts : Form
    {
        Abonné abn;

        OleDbConnection dbCon;
        public MesEmprunts()
        {
            InitializeComponent();
            abn = new Abonné();
            buttonProlonger.Enabled = checkBoxEmprunt.Checked && listAlbums.SelectedItem != null;
            buttonPrologerAll.Enabled = checkBoxEmprunt.Checked;
            checkBoxEmprunt.Enabled = abn == null;

            dbCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            dbCon.Open();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {

            try
            {
                if (LoginBox.Text != null && PassBox.Text != null)
                {
                    string sql = "Select *" +
                                 "From Abonné" +
                                 "Where Login = '" + LoginBox.Text + "' and Password = '" + PassBox.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(sql, dbCon);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int code = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string prenom = reader.GetString(2);
                        string login = reader.GetString(3);
                        string pass = reader.GetString(4);
                        int pays = reader.GetInt32(5);


                        abn = new Abonné()
                        {
                            Code_Abonné = code,
                            Nom_Abonné = nom,
                            Prénom_Abonné = prenom,
                            Login = login,
                            Password = pass,
                            Code_Pays = pays
                        };
                    }

                }

                chargerListeAlbum();
                checkBoxEmprunt.Enabled = abn != null;
            }
            catch
            {
                labelMessage.Text = "Erreur ! Login ou Mot de Passe invalide";
                labelMessage.ForeColor = Color.Red;
            }
        }
        #region Revenir au menu principal

        void chargerListeAlbum()
        {
            listAlbums.Items.Clear();
            List<Emprunter> emprunts = new List<Emprunter>();
            string sql = "Select *" +
                         "From Emprunter" +
                         "Where Code_Abonné = '" + abn.Code_Abonné + "'";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int codeAbo = reader.GetInt32(0);
                int codeAlb = reader.GetInt32(1);
                DateTime dateEmprunt = reader.GetDateTime(2);
                DateTime dateRetour = reader.GetDateTime(3);

                emprunts.Add(new Emprunter()
                {
                    Code_Abonné = codeAbo,
                    Code_Album = codeAlb,
                    Date_Emprunt = dateEmprunt,
                    Date_Retour = dateRetour
                });
            }



            foreach (Emprunter emp in emprunts)
            {
                Album album = new Album();
                sql = "Select *" +
                        "From Album" +
                        "Where Code_Album = '" + emp.Code_Album + "'";
                cmd = new OleDbCommand(sql, dbCon);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int codeAlb = reader.GetInt32(0);
                    string titre = reader.GetString(1);
                    int annee = reader.GetInt32(2);
                    int codeGenre = reader.GetInt32(3);
                    int codeEditeur = reader.GetInt32(4);
                    string asin = reader.GetString(6);

                    album = new Album()
                    {
                        Code_Album = codeAlb,
                        Titre_Album = titre,
                        Année_Album = annee,
                        Code_Genre = codeGenre,
                        Code_Editeur = codeEditeur,
                        ASIN = asin
                    };
                }

                if (checkBoxEmprunt.Checked && emp.Date_Retour == null)
                {
                    listAlbums.Items.Add(album);
                }
                else if (!checkBoxEmprunt.Checked)
                {
                    listAlbums.Items.Add(album);
                }

            }
        }
        /*Bouton retourner au menu*/
        private void menu_Click(object sender, EventArgs e)
        {
            #region Retourner au menu principal 
            new System.Threading.Thread(new System.Threading.ThreadStart(runMenu)).Start();
            this.Close();
            #endregion
        }
        private void runMenu()
        {
            Application.Run(new MenuAbonné());
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

        private void buttonProlonger_Click(object sender, EventArgs e)
        {
            List<Emprunter> emprunts = new List<Emprunter>();
            string sql = "Select *" +
                         "From Emprunter" +
                         "Where Code_Abonné = '" + abn.Code_Abonné + "'";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int codeAbo = reader.GetInt32(0);
                int codeAlb = reader.GetInt32(1);
                DateTime dateEmprunt = reader.GetDateTime(2);
                DateTime dateRetour = reader.GetDateTime(3);

                emprunts.Add(new Emprunter()
                {
                    Code_Abonné = codeAbo,
                    Code_Album = codeAlb,
                    Date_Emprunt = dateEmprunt,
                    Date_Retour = dateRetour
                });
            }

            Emprunter emprunt = new Emprunter();
            foreach (Emprunter emp in emprunts)
            {
                if (emp.Code_Album == listAlbums.SelectedItem.GetHashCode())
                {
                    emprunt = emp;
                }
            }
            emprunt.Date_Emprunt = System.DateTime.Now;
            /*musiqueSQL.Emprunter.AddOrUpdate(emprunt);*/

            String update = "Update Emprunter" +
                            "Set Date_Emprunt = '" + System.DateTime.Now + "' " +
                            "where Code_Abonné = '" + emprunt.Code_Abonné + "' and Code_Album = '" + emprunt.Code_Album + "'";
            cmd = new OleDbCommand(update, dbCon);


            try
            {
                cmd.ExecuteNonQuery();
                labelMessage.Text = "Prolongation effectuée";
                labelMessage.ForeColor = Color.Red;
                labelDate.Text = "La date a été mise à jour";
                labelDate.ForeColor = Color.Red;
            }
            catch
            {
                labelMessage.Text = "Erreur";
                labelMessage.ForeColor = Color.Red;
            }
        }

        private void checkBoxEmprunt_CheckedChanged(object sender, EventArgs e)
        {
            listAlbums.Items.Clear();
            if (LoginBox.Text != null && PassBox.Text != null)
            {
                string sql = "Select *" +
                                 "From Abonné" +
                                 "Where Login = '" + LoginBox.Text + "' and Password = '" + PassBox.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sql, dbCon);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int code = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string login = reader.GetString(3);
                    string pass = reader.GetString(4);
                    int pays = reader.GetInt32(5);


                    abn = new Abonné()
                    {
                        Code_Abonné = code,
                        Nom_Abonné = nom,
                        Prénom_Abonné = prenom,
                        Login = login,
                        Password = pass,
                        Code_Pays = pays
                    };
                }

            }
            buttonProlonger.Enabled = checkBoxEmprunt.Checked && listAlbums.SelectedItem != null;
            buttonPrologerAll.Enabled = checkBoxEmprunt.Checked;
            chargerListeAlbum();

        }

        private void listAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonProlonger.Enabled = listAlbums.SelectedItem != null;

            List<Emprunter> emprunts = new List<Emprunter>();
            string sql = "Select *" +
                         "From Emprunter" +
                         "Where Code_Abonné = '" + abn.Code_Abonné + "'";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int codeAbo = reader.GetInt32(0);
                int codeAlb = reader.GetInt32(1);
                DateTime dateEmprunt = reader.GetDateTime(2);
                DateTime dateRetour = reader.GetDateTime(3);

                emprunts.Add(new Emprunter()
                {
                    Code_Abonné = codeAbo,
                    Code_Album = codeAlb,
                    Date_Emprunt = dateEmprunt,
                    Date_Retour = dateRetour
                });
            }

            foreach (Emprunter emp in emprunts)
            {
                if (listAlbums.SelectedItem != null)
                {
                    labelDate.Text = " " + emp.Date_Emprunt;
                    labelDate.ForeColor = Color.Blue;
                }
            }
        }

        private void buttonPrologerAll_Click(object sender, EventArgs e)
        {
            List<Emprunter> emprunts = new List<Emprunter>();
            string sql = "Select *" +
                         "From Emprunter" +
                         "Where Code_Abonné = '" + abn.Code_Abonné + "'";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int codeAbo = reader.GetInt32(0);
                int codeAlb = reader.GetInt32(1);
                DateTime dateEmprunt = reader.GetDateTime(2);
                DateTime dateRetour = reader.GetDateTime(3);

                emprunts.Add(new Emprunter()
                {
                    Code_Abonné = codeAbo,
                    Code_Album = codeAlb,
                    Date_Emprunt = dateEmprunt,
                    Date_Retour = dateRetour
                });
            }

            List<Emprunter> list = new List<Emprunter>();
            foreach (Emprunter emp in emprunts)
            {
                if (emp.Date_Retour == null)
                {
                    list.Add(emp);
                }
            }
            foreach (Emprunter emp in list)
            {
                String update = "Update Emprunter" +
                            "Set Date_Emprunt = '" + System.DateTime.Now + "' "+
                            "where Code_Abonné = '" + emp.Code_Abonné + "' and Code_Album = '" + emp.Code_Album + "'";
                cmd = new OleDbCommand(update, dbCon);

                try
                {
                    cmd.ExecuteNonQuery();
                    labelMessage.Text = "Prolongations effectuées";
                    labelMessage.ForeColor = Color.Red;
                    labelDate.Text = "Toutes les dates ont été mises à jour";
                    labelDate.ForeColor = Color.Red;

                }
                catch
                {
                    labelMessage.Text = "Erreur";
                    labelMessage.ForeColor = Color.Red;
                }
            }
        }
    }
}
