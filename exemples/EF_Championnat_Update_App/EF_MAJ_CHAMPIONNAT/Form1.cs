using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EF_MAJ_CHAMPIONNAT
{
    public partial class Form1 : Form
    {
        CHAMPIONNATEntities championnat;


        public Form1()
        {
            InitializeComponent();
            // initialisation contrôles
            ChargeListBoxJOUEURS();
            ChargeComboBoxEQUIPES();
        }

        private void ChargeListBoxJOUEURS()
        {
            championnat = new CHAMPIONNATEntities();
            // on récupère tous les joueurs
            var joueurs = (from j in championnat.JOUEURS
                              orderby j.NOM
                             select j).ToList();
            // on initialise la listbox
            listBoxJOUEURS.Items.Clear();
            // création des objets locaux et remplissage de la listbox
            foreach (JOUEURS j in joueurs)
            {
                MyJoueur jj = new MyJoueur(j);
                listBoxJOUEURS.Items.Add(jj);
            }

        }

        private void ChargeComboBoxEQUIPES()
        {
            //on récupère toutes les équipes
            var equipes = (from e in championnat.EQUIPES
                           orderby e.VILLE
                           select e).ToList();
            foreach (EQUIPES e in equipes)
            {
                MyEquipe ee = new MyEquipe(e);
                comboBoxEquipe.Items.Add(ee.me.VILLE);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void listBoxJOUEURS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // que si la sélection vient de l'utilisateur, pas si "désélectionné" par programme
            if (listBoxJOUEURS.SelectedIndex != -1)
            {
                // on récupère le joueur sélectionné et on met à jour les trois contrôles
                MyJoueur j = (MyJoueur)listBoxJOUEURS.SelectedItem;
                textBoxNom.Text = j.me.NOM;
                textBoxSalaire.Text = j.me.SALAIRE.ToString();
                comboBoxEquipe.SelectedIndex = comboBoxEquipe.Items.IndexOf(j.me.EQUIPES.VILLE);
            }
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            // joueur sélectionné ?
            if (listBoxJOUEURS.SelectedItem != null)
            {
                // on récupère le joueur sélectionné et on le supprime
                MyJoueur j = (MyJoueur)listBoxJOUEURS.SelectedItem;
                championnat.JOUEURS.Remove(j.me);
                championnat.SaveChanges();
                // mise à jour de la listBoxJOUEURS
                listBoxJOUEURS.Items.Remove(listBoxJOUEURS.SelectedItem);
                // rafraîchissement
                Rafraîchir();
            }
            else PopupErreurOK("Aucun joueur sélectioné", "Erreur");
        }


        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            // les trois contrôles sont remplis ?
            if (textBoxNom.TextLength != 0 && textBoxSalaire.Text != "" && comboBoxEquipe.SelectedIndex != -1)
            {
                // le salaire est un entier ?
                if (Int32.TryParse(textBoxSalaire.Text, out int s))
                {
                    // on crée un nouveau JOUEUR
                    JOUEURS j = new JOUEURS();
                    j.NOM = textBoxNom.Text.Substring(0, Math.Min(textBoxNom.Text.Length, 32));
                    j.SALAIRE = s;
                    // on récupère l'ID de l'équipe
                    var IdEquipe = (from eq in championnat.EQUIPES
                                    where eq.VILLE == comboBoxEquipe.Text
                                    select eq.ID_EQUIPE);
                    j.ID_EQUIPE = IdEquipe.First();
                    // ajout du nouveau joueur
                    championnat.JOUEURS.Add(j);
                    championnat.SaveChanges();

                    // création de l'objet interne MyJoueur : on récupère d'abord le joueur créé
                    var joueurCréé = (from jc in championnat.JOUEURS
                                      where jc.NOM == j.NOM && jc.SALAIRE == j.SALAIRE && jc.ID_EQUIPE == j.ID_EQUIPE
                                      select jc).ToList();
                    MyJoueur jj = new MyJoueur(joueurCréé.First());

                    // mise à jour de la listbox et rafraîchissement
                    listBoxJOUEURS.Items.Add(jj);
                    Rafraîchir();
                }
                else PopupErreurOK("Le salaire doit être un nombre", "Erreur");
            }
            else PopupErreurOK("Tous les champs doivent être remplis", "Erreur");
        }

        private void Rafraîchir()
        {
            // on réinitialise les trois contrôles et on "désélectionne" le joueur dans listBoxJOUEURS
            textBoxNom.Clear();
            textBoxSalaire.Clear();
            comboBoxEquipe.SelectedIndex = -1;
            listBoxJOUEURS.SelectedIndex = -1;
        }

        private void boutonRafraîchir_Click(object sender, EventArgs e)
        {
            Rafraîchir();
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            // joueur sélectionné ?
            if (listBoxJOUEURS.SelectedItem != null)
            {
                // le salaire est un entier ?
                if (Int32.TryParse(textBoxSalaire.Text, out int s))
                {
                    // on récupère le joueur sélectionné et on le modifie
                    MyJoueur jj = (MyJoueur)listBoxJOUEURS.SelectedItem;
                    jj.me.NOM = textBoxNom.Text.Substring(0, Math.Min(textBoxNom.Text.Length, 32));
                    jj.me.SALAIRE = s;
                    // on récupère l'ID de l'équipe
                    var IdEquipe = (from eq in championnat.EQUIPES
                                    where eq.VILLE == comboBoxEquipe.Text
                                    select eq.ID_EQUIPE);
                    jj.me.ID_EQUIPE = IdEquipe.First();
                    championnat.SaveChanges();
                    // On met à jour listBoxJOUEURS: suppression, rajout et sélectionné
                    listBoxJOUEURS.Items.Remove(listBoxJOUEURS.SelectedItem);
                    listBoxJOUEURS.Items.Add(jj);
                    listBoxJOUEURS.SelectedIndex = listBoxJOUEURS.Items.IndexOf(jj);                    
                }
                else PopupErreurOK("Le salaire doit être un nombre", "Erreur");
            }
            else PopupErreurOK("Aucun joueur sélectioné", "Erreur");
        }

        private void PopupErreurOK(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

        }

    }
}
