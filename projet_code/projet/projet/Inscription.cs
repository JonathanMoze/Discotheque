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
    public partial class Inscription : Form
    {
        MusiqueSQLEntities musiqueSQL;
        public Inscription()
        {
            InitializeComponent();
            musiqueSQL = new MusiqueSQLEntities();
            chargerComboBoxPays();
        }

        public void chargerComboBoxPays()
        {
            var pays = (from p in musiqueSQL.Pays
                        orderby p.Nom_Pays
                        select p).ToList();
            foreach (Pays p in pays)
            {
                comboBoxPays.Items.Add(p);
            }
        }

        public void ajouterAbonne()
        {
            if (textBoxNom.TextLength != 0 && textBoxPrenom.TextLength != 0
                && MdpUnique(textBoxMDP.Text) && LoginUnique(textBoxLogin.Text)
                && comboBoxPays.SelectedIndex != -1)
            {
                Abonné a = new Abonné();
                a.Nom_Abonné = textBoxNom.Text;
                a.Prénom_Abonné = textBoxPrenom.Text;
                a.Login = textBoxLogin.Text;
                a.Password = textBoxMDP.Text;
                a.Code_Pays = comboBoxPays.SelectedItem.GetHashCode();
                musiqueSQL.Abonné.Add(a);
                musiqueSQL.SaveChanges();
            }
        }

        private bool MdpUnique(string mdp)
        {
            bool unique = mdp.Length != 0;
            var abonne = (from a in musiqueSQL.Abonné
                          orderby a.Code_Abonné
                          select a).ToList();
            foreach (Abonné a in abonne)
            {
                if (!unique)
                {
                    unique = mdp != a.Password;
                }
            }
            return unique;
        }

        private bool LoginUnique(string login)
        {
            bool unique = login.Length != 0;
            var abonne = (from a in musiqueSQL.Abonné
                          orderby a.Code_Abonné
                          select a).ToList();
            foreach (Abonné a in abonne)
            {
                if (!unique)
                {
                    unique = login != a.Login;
                }
            }
            return unique;
        }



        private void button_inscription_Click(object sender, EventArgs e)
        {
            ajouterAbonne();
        }
    }
}
