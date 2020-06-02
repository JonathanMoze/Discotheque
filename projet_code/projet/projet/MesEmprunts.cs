using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class MesEmprunts : Form
    {

        MusiqueSQLEntities musiqueSQL;
        public MesEmprunts()
        {
            InitializeComponent();
            musiqueSQL = new MusiqueSQLEntities();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            Abonné abn = new Abonné();

            if (LoginBox.Text != null && PassBox.Text != null)
            {
                var abo = (from a in musiqueSQL.Abonné
                           where a.Login == LoginBox.Text && a.Password == PassBox.Text
                           select a).ToList();
                abn = abo.First();

            }

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
                listAlbums.Items.Add(album);

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
    }
}
