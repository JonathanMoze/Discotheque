using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLEDB_ProjetBD
{
    public partial class Retards : Form
    {
        OleDbConnection dbCon;

        List<Abonné> abos;
        List<Emprunter> emprunts;
        public Retards()
        {
            InitializeComponent();
            dbCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            dbCon.Open();
            abos = new List<Abonné>();
            emprunts = new List<Emprunter>();
            chargeRetards();
            chargeAbo();
        }

        private void listAbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region affichage des informations sur l'abonné choisi


            Abonné a = (Abonné)listAbo.SelectedItem;
            textBoxLogin.Text = a.Login;
            listRetards.Items.Clear();

            foreach (Emprunter emp in emprunts)
            {
                if (emp.Code_Abonné == a.Code_Abonné)
                {
                   String sql = "Select * " +
                      "From Album " +
                      "Where Code_Album = " + emp.Code_Album.ToString();
                   OleDbCommand cmd = new OleDbCommand(sql, dbCon);
                   OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int codeAlb = reader.GetInt32(0);
                        string titre = reader.GetString(1);
                        int annee = reader.GetInt32(2);
                        int codeGenre = reader.GetInt32(3);
                        int codeEditeur = reader.GetInt32(4);

                        Album album = new Album()
                        {
                            Code_Album = codeAlb,
                            Titre_Album = titre,
                            Année_Album = annee,
                            Code_Genre = codeGenre,
                            Code_Editeur = codeEditeur
                        };

                        listRetards.Items.Add(album);
                    }

                    

                }
            }

            #endregion
        }


        public void chargeAbo()
        {
            #region Chargement des abonnés avec un retard dans la listBox


            foreach (Abonné a in abos)
            {
                listAbo.Items.Add(a);
            }

            #endregion
        }


        private void chargeRetards()
        {
            #region chargement des données utiles pour cette page (Emprunts en retard + abonnés concernés)
            List<Emprunter> retards = new List<Emprunter>();
            string sql = "Select *" +
                         "From Emprunter";
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int codeAbo = reader.GetInt32(0);
                int codeAlb = reader.GetInt32(1);
                DateTime DateEmp = reader.GetDateTime(2);
                if (!reader.IsDBNull(3))
                {
                    DateTime DateRet = reader.GetDateTime(3);

                    retards.Add(new Emprunter()
                    {
                        Code_Abonné = codeAbo,
                        Code_Album = codeAlb,
                        Date_Emprunt = DateEmp,
                        Date_Retour = DateRet
                    });
                }
                else
                {
                    retards.Add(new Emprunter()
                    {
                        Code_Abonné = codeAbo,
                        Code_Album = codeAlb,
                        Date_Emprunt = DateEmp
                    });
                }



            }

            foreach (Emprunter e in retards)
            {
                DateTime dateEmprunt = (DateTime)e.Date_Emprunt;
                DateTimeOffset dateLimite = new DateTimeOffset(dateEmprunt);
                dateLimite = dateLimite.AddMonths(1).AddDays(10);
                if (dateLimite <= DateTime.Today && e.Date_Retour == null)
                {
                    emprunts.Add(e);


                    sql = "Select * " +
                             "From Abonné " +
                             "Where Code_Abonné = " + e.Code_Abonné.ToString();

                    cmd = new OleDbCommand(sql, dbCon);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int code = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string prenom = reader.GetString(2);
                        string login = reader.GetString(3);
                        string pass = reader.GetString(4);
                        int pays = reader.GetInt32(5);


                        Abonné a = new Abonné()
                        {
                            Code_Abonné = code,
                            Nom_Abonné = nom,
                            Prénom_Abonné = prenom,
                            Login = login,
                            Password = pass,
                            Code_Pays = pays

                        };
                        bool contient = false;
                        foreach(Abonné abn in abos)
                        {
                            if(abn.Code_Abonné == a.Code_Abonné)
                            {
                                contient = true;
                            }
                        }

                        if (!contient)
                        {
                            abos.Add(a);
                        }
                    }
                }
            }

            #endregion
        }

        #region Bouton retourner au menu
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
