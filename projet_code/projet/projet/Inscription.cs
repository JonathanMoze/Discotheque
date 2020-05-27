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
            if (tousChampsRemplis())
            {
                    Abonné a = new Abonné();
                    a.Nom_Abonné = textBoxNom.Text;
                    a.Prénom_Abonné = textBoxPrenom.Text;
                    a.Login = textBoxLogin.Text;
                    a.Password = textBoxMDP.Text;
                    a.Code_Pays = comboBoxPays.SelectedItem.GetHashCode();
                    musiqueSQL.Abonné.Add(a);
                    musiqueSQL.SaveChanges();
                    labelMessage.Text = "Inscription confirmée";
                              
            }
            else
            {
                labelMessage.Text = "Veuillez remplir tous les champs";
                labelMessage.ForeColor = Color.Red;
            }
        }

        private bool tousChampsRemplis()
        {
            return textBoxNom.TextLength != 0 && textBoxPrenom.TextLength != 0 && comboBoxPays.SelectedIndex != -1
                && textBoxMDP.TextLength != 0 && textBoxLogin.TextLength != 0;
        }


        private bool LoginUnique(string login)
        {
            bool unique = true;
            var abonne = (from a in musiqueSQL.Abonné
                          orderby a.Code_Abonné
                          select a).ToList();
            foreach (Abonné a in abonne)
            {
                if (unique)
                {
                    unique = login != a.Login;
                }
            }
            labelMessage.Text = "Le login choisi n'est pas disponible";
            labelMessage.ForeColor = Color.Red;
            return unique;
        }



        private void button_inscription_Click(object sender, EventArgs e)
        {
            ajouterAbonne();
        }
    }
}
