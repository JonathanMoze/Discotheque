using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                    listRetards.Items.Add(emp.Album);

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
                DateTime DateRet = reader.GetDateTime(3);


                emprunts.Add(new Emprunter()
                {
                    Code_Abonné = codeAbo,
                    Code_Album = codeAlb,
                    Date_Emprunt = DateEmp,
                    Date_Retour = DateRet
                });
            }

            foreach (Emprunter e in retards)
            {
                DateTime dateEmprunt = (DateTime)e.Date_Emprunt;
                DateTimeOffset dateLimite = new DateTimeOffset(dateEmprunt);
                dateLimite = dateLimite.AddMonths(1).AddDays(10);
                if (dateLimite <= DateTime.Today && e.Date_Retour == null)
                {
                    emprunts.Add(e);
                    if (!abos.Contains(e.Abonné))
                    {
                        abos.Add(e.Abonné);
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
