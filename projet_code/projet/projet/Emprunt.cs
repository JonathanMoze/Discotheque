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

            // Récupérer tous les albums
            var albums = (from a in musique.Album
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
            }
            #endregion
        }

        public void ChargerAlbumsNonDispo()
        {
            listBox1.Items.Clear();
            var albemprunte = (from ab in musique.Emprunter
                               where ab.Date_Retour == null
                               select ab).ToList();
            foreach (Emprunter e in albemprunte)
            {
                listBox1.Items.Add(e.Album.Titre_Album);
            }
        }

        public void ChargerTousAlbums()
        {
            #region Chargement des Albums

            // Récupérer tous les albums
            var albums = (from a in musique.Album
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
            }
            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region  Récupération d l'album sélectionné
            try
            {
                Album a = (Album)listBox1.SelectedItem;
                titreAlbum.Text = a.ToString();
            }
            catch
            {
                labelMessage.Text = "Cet album est indisponible";
                labelMessage.ForeColor = Color.Red;
            }
            
            #endregion
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            #region Récuperation de l'album et l'abonné
            Abonné abn = new Abonné();
            abn.Login = "temp";
            bool emprunter = false;
            Album AlbSelection = new Album();
            try
            {
                if (listBox1.SelectedItem != null && !titreAlbum.Text.Contains("INDISPONIBLE"))
                {
                    AlbSelection = (Album)listBox1.SelectedItem;
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
                labelMessage.Text = "Erreur ! ";
            }
            var abonnés = (from a in musique.Abonné
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
            }
            // Verifier que l'album est disponible
            if (!emprunter)
            {
                var albemprunte = (from ab in musique.Emprunter
                                   where ab.Date_Retour == null
                                   select ab).ToList();
                foreach (Emprunter em in albemprunte)
                {
                    if (em.Code_Album == AlbSelection.Code_Album)
                    {
                        emprunter = true;
                        label5.Text = "Cet album est indisponible";
                        label5.ForeColor = Color.Red;
                    }
                }
            }
            // Création d'emprunt
            if (listBox1.SelectedItem != null && abn.Login != "temp" && !emprunter)
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

                    label5.Text = "Emprunt OK";
                    label5.ForeColor = Color.Red;
                    labelDate.Text = "Album emprunté le " + DateTime.Now;
                    labelDate.ForeColor = Color.Blue;
                }
                catch
                {
                    label5.Text = "Erreur !";
                    label5.ForeColor = Color.Red;
                }
            }
            #endregion
        }


        /* Barre de recherche */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           var al = (from a in musique.Album
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
           }
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
