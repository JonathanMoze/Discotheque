using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class ListeAbonne : Form
    {
        MusiqueSQLEntities musiqueBase;
        Abonné abn;
        Dictionary<int, DateTime> PersEmpr;

        public ListeAbonne()
        {
            InitializeComponent();
            musiqueBase = new MusiqueSQLEntities();
            PersEmpr = new Dictionary<int, DateTime>();

            ChargerAboInactifs();
            labelDate.Text = "";
            ChargerAbo();
        }
        //Charger les abonnés inactifs dans la listBox
        private void ChargerAboInactifs()
        {
            #region Les abonnés qui dont le dernier emprunt date d'il y a un an
            var abonIn = (from a in musiqueBase.Abonné
                               join em in musiqueBase.Emprunter on a.Code_Abonné equals em.Code_Abonné
                               where DbFunctions.AddYears(em.Date_Emprunt.Value, 1).Value.CompareTo(DateTime.Now) < 0
                               select a).Distinct().ToList();
            #endregion
            #region Les emprunts
            var emprunts = (from e in musiqueBase.Emprunter
                            orderby e.Code_Abonné
                            select e).Distinct().ToList();
            #endregion
            
            #region les ajouter dans la listbox1
            foreach (Abonné a in abonIn)
            {
                DateTime dateEmprunt = default;
                //Chercher la date la plus récente
                foreach (Emprunter e in emprunts)
                {
                    if (a.Code_Abonné == e.Code_Abonné && DateTime.Compare(dateEmprunt, (DateTime)e.Date_Emprunt) < 0)
                    {
                        dateEmprunt = (DateTime)e.Date_Emprunt;
                    }
                }
                // afficher les abonnés inactifs

                 listBox1.Items.Add(a);
                if (listBox1.SelectedItems != null)
                {
                    labelDate.Text = " " + dateEmprunt;
                }
            }
            #endregion
        }
        private void ChargerAbo()
        {
            // on récupère tous les albums
            var abonnés = (from a in musiqueBase.Abonné
                           orderby a.Nom_Abonné
                           select a).ToList();

            var emprunts = (from e in musiqueBase.Emprunter
                            orderby e.Code_Abonné
                            select e).ToList();
            // on initialise la listbox
            listBox2.Items.Clear();
            // création des objets locaux et remplissage de la listbox
            foreach (Abonné a in abonnés)
            {
                string nom, prenom;
                DateTime dateEmprunt = default;
                //Chercher la date la plus récente
                foreach (Emprunter e in emprunts)
                {
                    if (a.Code_Abonné == e.Code_Abonné && DateTime.Compare(dateEmprunt, (DateTime)e.Date_Emprunt) < 0)
                    {
                        dateEmprunt = (DateTime)e.Date_Emprunt;
                    }
                }
                PersEmpr[a.Code_Abonné] = dateEmprunt;
                // Mettre un nom sans espaces 
                nom = nomAbonné(a);
                prenom = prenomAbonné(a);
                //Ajout dans la listBox selon la présence de date
                if (dateEmprunt == default)
                {
                    listBox2.Items.Add(nom + " " + prenom + "    -    N'a pas encore fait d'emprunt");
                }
                else listBox2.Items.Add(nom + " " + prenom + "    -    " + dateEmprunt.ToString());
            }

        }

        private string nomAbonné(Abonné a)
        {
            string nom = "Sans nom";
            if (a.Nom_Abonné != null)
            {
                string[] v = System.Text.RegularExpressions.Regex.Split(a.Nom_Abonné, "  ");
                nom = v[0];
            }
            return nom;
        }

        private string prenomAbonné(Abonné a)
        {
            string nom = "Sans prénom";
            if (a.Prénom_Abonné != null)
            {
                string[] v = System.Text.RegularExpressions.Regex.Split(a.Prénom_Abonné, "  ");
                nom = v[0];
            }
            return nom;
        }

        //Supprimer la liste 
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Abonné a in listBox1.Items)
            {
                var nonRetourner = musiqueBase.Emprunter.Where(em => em.Date_Retour == null && em.Code_Abonné == a.Code_Abonné).Count();
                int compte = (int)nonRetourner;
                if (compte == 0) musiqueBase.Abonné.Remove(a);
                else
                {
                    string message = nomAbonné(a) + " " + prenomAbonné(a) + " n'a pas rendu tous ses albums empruntés, voulez vous quand même le supprimer";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show(message, "Erreur", buttons);
                    if (result == DialogResult.Yes)
                    {
                        musiqueBase.Abonné.Remove(a);
                    }
                }
            }
            try
            {
                musiqueBase.SaveChanges();
                labelMessage.Text = "Abonnés inactifs supprimés";
                labelMessage.ForeColor = Color.Red;
            }
            catch
            {
                labelMessage.Text = "Echec !";
                labelMessage.ForeColor = Color.Red;
            }

            labelDate.Text = "   ";
            listBox1.Items.Clear();
            ChargerAboInactifs();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var abonIn = (from a in musiqueBase.Abonné
                          join em in musiqueBase.Emprunter on a.Code_Abonné equals em.Code_Abonné
                          where DbFunctions.AddYears(em.Date_Emprunt.Value, 1).Value.CompareTo(DateTime.Now) < 0
                          select a).Distinct().ToList();
            #region Les emprunts
            var emprunts = (from em in musiqueBase.Emprunter
                            orderby em.Code_Abonné
                            select em).Distinct().ToList();
            #endregion
            DateTime dateEmprunt = default;
            foreach (Abonné a in abonIn)
            {
                //Chercher la date la plus récente
                foreach (Emprunter em in emprunts)
                {
                    if (a.Code_Abonné == em.Code_Abonné && DateTime.Compare(dateEmprunt, (DateTime)em.Date_Emprunt) < 0)
                    {
                        dateEmprunt = (DateTime)em.Date_Emprunt;
                    }
                }
                // afficher les abonnés inactifs

                if (listBox1.SelectedItems != null)
                {
                    labelDate.Text = " Dernier emprunt le " + dateEmprunt;
                    labelDate.ForeColor = Color.Blue;
                }
            }
        }
        

    }
}

