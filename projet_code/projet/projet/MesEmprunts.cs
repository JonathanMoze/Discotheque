using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class MesEmprunts : Form
    {
        Abonné abn;
        MusiqueSQLEntities musiqueSQL;
        public MesEmprunts()
        {
            InitializeComponent();
            abn = new Abonné();
            musiqueSQL = new MusiqueSQLEntities();
            buttonProlonger.Enabled = checkBoxEmprunt.Checked && listAlbums.SelectedItem!=null;
            checkBoxEmprunt.Enabled = abn==null;
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {


            if (LoginBox.Text != null && PassBox.Text != null)
            {
                var abo = (from a in musiqueSQL.Abonné
                           where a.Login == LoginBox.Text && a.Password == PassBox.Text
                           select a).ToList();
                abn = abo.First();

            }

            chargerListeAlbum();
            checkBoxEmprunt.Enabled = abn!=null;
        }
        #region Revenir au menu principal

        void chargerListeAlbum()
        {
            listAlbums.Items.Clear();
            var emprunts = (from em in musiqueSQL.Emprunter
                            where em.Code_Abonné == abn.Code_Abonné
                            select em).ToList();
            foreach (Emprunter emp in emprunts)
            {
                Album album = new Album();
                var albums = (from alb in musiqueSQL.Album
                              where alb.Code_Album == emp.Code_Album
                              select alb).ToList();
                album = albums.First();
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
            Application.Run(new Menu());
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
            var emprunts = (from em in musiqueSQL.Emprunter
                            where em.Code_Abonné == abn.Code_Abonné
                            select em).ToList();
            Emprunter emprunt = new Emprunter();
            foreach (Emprunter emp in emprunts)
            {
                if (emp.Code_Album == listAlbums.SelectedItem.GetHashCode())
                {
                    emprunt = emp;
                }
            }
            emprunt.Date_Emprunt = System.DateTime.Now;
            musiqueSQL.Emprunter.AddOrUpdate(emprunt);
            musiqueSQL.SaveChanges();
        }

        private void checkBoxEmprunt_CheckedChanged(object sender, EventArgs e)
        {
            listAlbums.Items.Clear();
            if (LoginBox.Text != null && PassBox.Text != null)
            {
                var abo = (from a in musiqueSQL.Abonné
                           where a.Login == LoginBox.Text && a.Password == PassBox.Text
                           select a).ToList();
                abn = abo.First();

            }
            buttonProlonger.Enabled = checkBoxEmprunt.Checked && listAlbums.SelectedItem != null;

            chargerListeAlbum();

        }

        private void listAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonProlonger.Enabled = checkBoxEmprunt.Checked && listAlbums.SelectedItem != null;
        }
    }
}
