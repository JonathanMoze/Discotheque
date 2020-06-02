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
    public partial class ListeAbonne : Form
    {
        MusiqueSQLEntities musiqueBase;
        Dictionary<int, DateTime> PersEmpr;
        public ListeAbonne()
        {
            InitializeComponent();
            musiqueBase = new MusiqueSQLEntities();
            PersEmpr = new Dictionary<int, DateTime>();
            ChargeListBoxTitresAlbums();
        }

        private void ChargeListBoxTitresAlbums()
        {
            // on récupère tous les albums
            var abonnés = (from a in musiqueBase.Abonné
                           orderby a.Nom_Abonné
                           select a).ToList();

            var emprunts = (from e in musiqueBase.Emprunter
                            orderby e.Code_Abonné
                            select e).ToList();
            // on initialise la listbox
            listBox1.Items.Clear();
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
                if (a.Nom_Abonné == null) nom = "Sans nom";
                else
                {
                    string[] v = System.Text.RegularExpressions.Regex.Split(a.Nom_Abonné, "  ");
                    nom = v[0];
                }
                // Mettre un prénom sans espaces
                if (a.Prénom_Abonné == null) prenom = "Sans prénom";
                else
                {
                    string[] v = System.Text.RegularExpressions.Regex.Split(a.Prénom_Abonné, "  ");
                    prenom = v[0];
                }
                //Ajout dans la listBox selon la présence de date
                if (dateEmprunt == default)
                {
                    listBox1.Items.Add(nom + " " + prenom + "    -    N'a pas encore fait d'emprunt");
                }
                else listBox1.Items.Add(nom + " " + prenom + "    -    " + dateEmprunt.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, DateTime> n in PersEmpr)
            {
                if (DateTime.Compare(n.Value.AddDays(365), DateTime.Now) < 0)
                {
                    Abonné abn = new Abonné();
                    var abonnés = (from a in musiqueBase.Abonné
                                   where a.Code_Abonné == n.Key
                                   orderby a.Nom_Abonné
                                   select a).ToList();
                    abn = abonnés.First();
                    musiqueBase.Abonné.Remove(abn);
                    musiqueBase.SaveChanges();
                }
            }
        }
    }
}
