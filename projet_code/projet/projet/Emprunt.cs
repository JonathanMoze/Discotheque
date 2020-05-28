using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class Emprunt : Form
    {
        MusiqueSQLEntities musique;
        public Emprunt()
        {
            InitializeComponent();
            musique = new MusiqueSQLEntities();
            ChargeAlbums();
        }
        public void ChargeAlbums()
        {
            #region Chargement des Albums

            // Récupérer tous les albums
            var albums = (from a in musique.Album
                          orderby a.Titre_Album
                          select a).ToList();

            // Remplir la listbox
            foreach (Album a in albums)
            {
                listBox1.Items.Add(a);
            }
            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region  Récupération d l'album sélectionné
            Album a = (Album)listBox1.SelectedItem;
            titreAlbum.Text = a.ToString();
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region Récuperation de l'album et l'abonné
            Abonné abn = new Abonné();
            Album AlbSelection = new Album();
            if (listBox1.SelectedItem != null)
            {
                AlbSelection = (Album)listBox1.SelectedItem;
            }
            if (Login.Text != "")
            {                
                    var abonné = (from a in musique.Abonné
                                  where a.Login == Login.Text
                                  select a).ToList();
                    abn = abonné.First();
                
                Console.WriteLine(AlbSelection.Titre_Album);
                // Création d'emprunt
                if (listBox1.SelectedItem != null && Login.Text != "")
                {
                    Emprunter E = new Emprunter()
                    {
                        Code_Abonné = abn.Code_Abonné,
                        Code_Album = AlbSelection.Code_Album,
                        Date_Emprunt = DateTime.Now
                    };
                    musique.Emprunter.Add(E);
                    try
                    {
                        musique.SaveChanges();

                        Console.WriteLine("Emprunt OK");
                        label5.Text = "Emprunt OK";
                    }
                    catch
                    {
                        Console.WriteLine("Erreur !");
                        label5.Text = "Erreur !";
                    }
                }
                #endregion

            }

        }
        /* Barre de recherche */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            #region Récupération de tous les albums correspondant à la recherche
            var albums = (from a in musique.Album
                          where a.Titre_Album.ToUpper().StartsWith(textBox1.Text.ToUpper())
                          orderby a.Titre_Album
                          select a).ToList();
            // on réinitialise la listBox
            listBox1.Items.Clear();
            // on insère dans listBox1 les albums récupérés
            foreach (Album m in albums)
            {
                listBox1.Items.Add(m);
            }
            #endregion
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
            Application.Run(new Menu());
        }
        #endregion
    }
}
