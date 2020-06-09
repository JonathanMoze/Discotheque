﻿using System;
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
    public partial class Emprunt : Form
    {
        OleDbConnection dbCon;
       
        public Emprunt()
        {
            InitializeComponent();
            dbCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            dbCon.Open();
            ChargeAlbumsDispo();
            Affichage();
            labelDate.Text = " ";
        }
        
        public void Affichage()
        {
            comboBox1.Items.Add("Tout");
            comboBox1.Items.Add("les albums disponibles uniquement");
            comboBox1.Items.Add("les albums indisponibles uniquement");
        }
        public void ChargeAlbumsDispo()
        {
            #region Chargement des Albums
            listBox1.Items.Clear();
            string album = "SELECT Album.Code_Album, Album.Titre_Album FROM Album "
           + "LEFT OUTER JOIN Emprunter ON Album.Code_Album = Emprunter.Code_Album "
           + "WHERE Emprunter.Date_Emprunt IS NULL OR Emprunter.Date_Retour IS NOT NULL "
           + "ORDER BY Titre_Album";
            OleDbCommand cmd = new OleDbCommand(album, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string titre = "Sans titre";
                if (!reader.IsDBNull(1)) titre = reader.GetString(1);

                Album a = new Album(id, titre);
                // Ajout dans la ListBox
                listBox1.Items.Add(a.Titre_Album);
            }
            reader.Close();

            // Récupérer tous les albums
            /*var albums = (from a in musique.Album
                          orderby a.Titre_Album
                          select a).ToList();

            var albemprunte = (from ab in musique.Emprunter
                               where ab.Date_Retour == null
                               select ab).ToList();
            listBox1.Items.Clear();
            // Remplir la listbox
            foreach (Album a in albums)
            {
                bool emprunter = false;
                foreach (Emprunter e in albemprunte)
                {
                    if (e.Code_Album == a.Code_Album) emprunter = true;
                }
                if (!emprunter) listBox1.Items.Add(a);
            }*/
            #endregion
        }

        public void ChargerAlbumsNonDispo()
        {
            listBox1.Items.Clear();
            string album = "SELECT Album.Code_Album, Album.Titre_Album FROM Album "
            +"LEFT OUTER JOIN Emprunter ON Album.Code_Album = Emprunter.Code_Album "
            +"WHERE Emprunter.Date_Emprunt IS NOT NULL AND Emprunter.Date_Retour IS NULL "
            +"ORDER BY Titre_Album";
            OleDbCommand cmd = new OleDbCommand(album, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string titre = "Sans titre";
                if (!reader.IsDBNull(1)) titre = reader.GetString(1);

                Album a = new Album(id, titre);
                // Ajout dans la ListBox
                listBox1.Items.Add(a.Titre_Album);
            }
            reader.Close();
            /*var albemprunte = (from ab in musique.Emprunter
                               where ab.Date_Retour == null
                               select ab).ToList();
            foreach (Emprunter e in albemprunte)
            {
                listBox1.Items.Add(e.Album.Titre_Album);
            }*/
        }

        public void ChargerTousAlbums()
        {
            #region Chargement des Albums
            listBox1.Items.Clear();
            string album = "SELECT Album.Code_Album, Album.Titre_Album, Emprunter.Date_Emprunt, Emprunter.Date_Retour FROM Album "
                 + "LEFT OUTER JOIN Emprunter ON Album.Code_Album = Emprunter.Code_Album "
                 + "ORDER BY Titre_Album";
            OleDbCommand cmd = new OleDbCommand(album, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string titre = "Sans titre";
                if (!reader.IsDBNull(1)) titre = reader.GetString(1);
                DateTime emprunt = default;
                if (!reader.IsDBNull(2)) emprunt = reader.GetDateTime(2);
                DateTime retour = default;
                if (!reader.IsDBNull(3)) retour = reader.GetDateTime(3);
                Album a = new Album(id, titre);
                if (emprunt != default && retour == default) listBox1.Items.Add(a.Titre_Album + "  -  INDISPONIBLE");
                else listBox1.Items.Add(a.Titre_Album);
            }
            reader.Close();

            // Récupérer tous les albums
            /* var albums = (from a in musique.Album
                           orderby a.Titre_Album
                           select a).ToList();

             var albemprunte = (from ab in musique.Emprunter
                                where ab.Date_Retour == null
                                select ab).ToList();
             listBox1.Items.Clear();
             // Remplir la listbox
             foreach (Album a in albums)
             {
                 bool emprunter = false;
                 foreach (Emprunter e in albemprunte)
                 {
                     if (e.Code_Album == a.Code_Album) emprunter = true;
                 }
                 if (emprunter) listBox1.Items.Add(a + "  -  INDISPONIBLE");
                 else listBox1.Items.Add(a);
             }*/
            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            labelMessage.Text = "";
            labelDate.Text = "";
            #region  Récupération d l'album sélectionné
            try
            {
                string album = "SELECT Album.Code_Album, Album.Titre_Album FROM Album "
                 + "WHERE Titre_Album = " + listBox1.SelectedItem
                 + "ORDER BY Titre_Album";
                OleDbCommand cmd = new OleDbCommand(album, dbCon);
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int id = reader.GetInt32(0);
                string titre = "Sans titre";
                if (!reader.IsDBNull(1)) titre = reader.GetString(1);
                Album a = new Album(id, titre);
                reader.Close();
                titreAlbum.Text = a.Titre_Album;
                button1.Enabled = true;
            }
            catch
            {
                labelMessage.Text = "Cet album est indisponible";
                labelMessage.ForeColor = Color.Red;
                button1.Enabled = false;
            }
            #endregion
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            #region Récuperation de l'album et l'abonné
            Abonné abn = new Abonné();
            abn.Login = "temp";
            bool emprunter = false;
            labelMessage.Text = "";
            label5.Text = "";
            Album AlbSelection = new Album();
            try
            {                
                if (listBox1.SelectedItem != null && !titreAlbum.Text.Contains("INDISPONIBLE"))
                {
                    string album = "SELECT Album.Code_Album, Album.Titre_Album FROM Album "
                 + "WHERE Titre_Album = "+ listBox1.SelectedItem
                 + "ORDER BY Titre_Album";
                    OleDbCommand cmd = new OleDbCommand(album, dbCon);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int id = reader.GetInt32(0);
                    string titre = "Sans titre";
                    if (!reader.IsDBNull(1)) titre = reader.GetString(1);
                    AlbSelection = new Album(id,titre);
                    reader.Close();
                }
                else
                {
                    emprunter = true;
                    label5.Text = "Cet album est indisponible";
                    label5.ForeColor = Color.Red;
                    
                }
            }
            catch
            {
                labelMessage.Text = "Veuillez choisir un autre album et cliquez sur emprunter ";
            }
            try
            {
                string abonne = "SELECT Abonné.Code_Abonné, Abonné.Login Code_Pays FROM Abonné "
                        + "WHERE Login = '"+ Login.Text + "'";
                OleDbCommand cmd = new OleDbCommand(abonne, dbCon);
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                abn.Code_Abonné = reader.GetInt32(0);
                abn.Login = reader.GetString(1);
                reader.Close();
            } catch (Exception)
            {
                label5.Text = "Entrez un login valide";
                label5.ForeColor = Color.Red;
            }
            /* var abonnés = (from a in musique.Abonné
                            orderby a.Login
                            select a).ToList();

             // Remplir la listbox
             foreach (Abonné a in abonnés)
             {
                 if (Login.Text == a.Login)
                 {
                     var abonné = (from ab in musique.Abonné
                                   where ab.Login == Login.Text
                                   select ab).ToList();
                     abn = abonné.First();
                 }
                 else
                 {
                     label5.Text = "Entrez un login valide";
                     label5.ForeColor = Color.Red;
                 }
             }*/
            // Verifier que l'album est disponible
            if (!emprunter)
            {
                string abonne = "SELECT COUNT(Emprunter.Code_Album) FROM Emprunter "
                    +"WHERE Date_Retour IS NULL AND Emprunter.Code_Album = '" + AlbSelection.Code_Album + "'";
                OleDbCommand cmd = new OleDbCommand(abonne, dbCon);
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int cmpte = reader.GetInt32(0);
                if (cmpte != 0)
                {
                    emprunter = true;
                    label5.Text = "Cet album est indisponible";
                    label5.ForeColor = Color.Red;
                }
            }
            /*if (!emprunter)
            {
                var albemprunte = (from ab in musique.Emprunter
                                   where ab.Date_Retour == null
                                   select ab).ToList();
                foreach (Emprunter em in albemprunte)
                {
                    if (em.Code_Album == AlbSelection.Code_Album)
                    {
                        //emprunter = true;
                        label5.Text = "Cet album est indisponible";
                        label5.ForeColor = Color.Red;
                    }
                }
            }*/
            // Création d'emprunt
            if (listBox1.SelectedItem != null && abn.Login != "temp" && !emprunter)
            {
                string insert = " insert into Emprunter (code_Album, code_Abonné, Date_Emprunt) " +
                        "Values (?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(insert, dbCon);
                cmd.Parameters.Add("code_abonné", OleDbType.Integer).Value = abn.Code_Abonné;
                cmd.Parameters.Add("code_album", OleDbType.Integer).Value = AlbSelection.Code_Album;
                cmd.Parameters.Add("date_emprunt", OleDbType.VarChar).Value = DateTime.Now;
                /* Emprunter E = new Emprunter()
                 {
                     Code_Abonné = abn.Code_Abonné,
                     Code_Album = AlbSelection.Code_Album,
                     Date_Emprunt = DateTime.Now
                 };
                 musique.Emprunter.Add(E);*/
                try
                {
                    cmd.ExecuteNonQuery();
                    // musique.SaveChanges();
                    Login.Clear();
                    label5.Text = "Emprunt OK";
                    label5.ForeColor = Color.Red;
                    labelDate.Text = "Album emprunté le " + DateTime.Now;
                    labelDate.ForeColor = Color.Blue;
                }
                catch
                {
                    label5.Text = "Erreur !!";
                    label5.ForeColor = Color.Red;
                }
            }
            #endregion
        }


        /* Barre de recherche */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string album = "SELECT Album.Code_Album, Album.Titre_Album FROM Album "
          + "LEFT OUTER JOIN Emprunter ON Album.Code_Album = Emprunter.Code_Album "
          + "WHERE Emprunter.Date_Emprunt IS NULL OR Emprunter.Date_Retour IS NOT NULL "
          + "AND Album.Titre_Album = '"+ textBox1.Text+"%'"
          + "ORDER BY Titre_Album";
            OleDbCommand cmd = new OleDbCommand(album, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string titre = "Sans titre";
                if (!reader.IsDBNull(1)) titre = reader.GetString(1);

                Album a = new Album(id, titre);
                // Ajout dans la ListBox
                listBox1.Items.Add(a.Titre_Album);
            }
            reader.Close();
            /* var al = (from a in musique.Album
                       where a.Titre_Album.ToUpper().Contains(textBox1.Text.ToUpper())
                       orderby a.Titre_Album
                       select a).ToList();

             var albemprun = (from ab in musique.Emprunter
                              where ab.Date_Retour == null
                              select ab).ToList();
             listBox1.Items.Clear();
             // Remplir la listbox
             foreach (Album a in al)
             {
                 bool emprunter = false;
                 foreach (Emprunter emp in albemprun)
                 {
                     if (emp.Code_Album == a.Code_Album) emprunter = true;
                 }
                 if (emprunter) listBox1.Items.Add(a);
             }*/
        }

        #region Revenir au menu principal
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Tout":
                    ChargerTousAlbums();
                    break;
                case "les albums disponibles uniquement":
                    ChargeAlbumsDispo();
                    break;
                case "les albums indisponibles uniquement":
                    ChargerAlbumsNonDispo();
                    break;

            }
        }
    }
}
