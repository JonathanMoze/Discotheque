using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace OLEDB_ProjetBD
{
    public partial class Inscription : Form
    {
        OleDbConnection dbCon;
        public Inscription()
        {
            InitializeComponent();
            dbCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            dbCon.Open();
            chargerComboBoxPays();
        }

        public void chargerComboBoxPays()
        {
            string sql = "select Pays.Code_Pays, Pays.Nom_Pays from Pays";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int code = reader.GetInt32(0);
                string nom = reader.GetString(1);
                Pays temp = new Pays { Code_Pays = code, Nom_Pays = nom };
                comboBoxPays.Items.Add(temp);
            }
        }

        public void ajouterAbonne()
        {
            #region Ajouter un abonné à la base
            if (tousChampsRemplis())
            {
                if (LoginUnique(textBoxLogin.Text))
                {
                    int code = 0;
                    string sql = "select Pays.Code_Pays from Pays where Nom_Pays= '" + comboBoxPays.SelectedItem.ToString() + " ' ";
                    OleDbCommand cmd = new OleDbCommand(sql, dbCon);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        code = reader.GetInt32(0);
                    }
                    reader.Close();
                    string sql1 = "insert into Abonné (Code_Pays, Nom_Abonné, Prénom_Abonné, Login, Password) values (?,?,?,?,?)";
                    OleDbCommand insert = new OleDbCommand(sql1, dbCon);
                    insert.Parameters.Add("Code_Pays", OleDbType.VarChar).Value = code;
                    insert.Parameters.Add("Nom_Abonné", OleDbType.VarChar).Value = textBoxNom.Text;
                    insert.Parameters.Add("Prénom_Abonné", OleDbType.VarChar).Value = textBoxPrenom.Text;
                    insert.Parameters.Add("Login", OleDbType.VarChar).Value = textBoxLogin.Text;
                    insert.Parameters.Add("Password", OleDbType.VarChar).Value = textBoxMDP.Text;
                    insert.ExecuteNonQuery();
                    labelMessage.Text = "Inscription confirmée";
                    labelMessage.ForeColor = Color.Blue;
                }
            }
            else
            {
                labelMessage.Text = "Veuillez remplir tous les champs";
                labelMessage.ForeColor = Color.Red;
            }
            #endregion
        }

        private bool tousChampsRemplis()
        {
            return textBoxNom.TextLength != 0 && textBoxPrenom.TextLength != 0 && comboBoxPays.SelectedIndex != -1
                && textBoxMDP.TextLength != 0 && textBoxLogin.TextLength != 0;
        }


        private bool LoginUnique(string login)
        {
            #region Vérifier si le login est unique
            bool unique = true;

            string sql = "select Login from Abonné";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                if (!unique)
                {
                    labelMessage.Text = "Le login choisi n'est pas disponible";
                    labelMessage.ForeColor = Color.Red;
                }

            }

            reader.Close();
            return unique;
            #endregion
        }

        private void button_inscription_Click(object sender, EventArgs e)
        {
            ajouterAbonne();
        }


        #region Revenir au menu principal
        /*retourner au menu*/
        private void menu_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runMenu)).Start();
            this.Close();
        }
        private void runMenu()
        {
            Application.Run(new MenuAbonné());
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(runEmprunt)).Start();
            this.Close();
        }

        private void runEmprunt()
        {
            Application.Run(new Emprunt());
        }
    }
}

