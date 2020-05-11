using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        MusiqueSQLEntities musique;
        public Form1()
        {
            InitializeComponent();
            musique = new MusiqueSQLEntities();

            var musiciens = (from m in musique.Musicien
                             //where m.Nom_Musicien.StartsWith(textBox1.Text)
                             orderby m.Nom_Musicien
                             select m).ToList();
            foreach (Musicien m in musiciens)
            {
                //Console.Write(m.Nom_Musicien + ", ");
                listBox1.Items.Add(m);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            var musiciens = (from m in musique.Musicien
                             where m.Nom_Musicien.StartsWith(textBox1.Text)
                             orderby m.Nom_Musicien
                             select m).ToList();
            foreach (Musicien m in musiciens)
            {
                listBox1.Items.Add(m);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Musicien m = (Musicien)listBox1.SelectedItem;
            
            foreach (Oeuvre o in m.Oeuvre)
            {
                //listBox2.Items.Add(o.Titre_Oeuvre);
                listBox2.Items.Add(o);
            }
            /*
            foreach (Diriger d in x.me.Diriger)
                foreach (Composition_Disque c in d.Enregistrement.Composition_Disque)
                    listBox2.Items.Add(c.Disque.Album.Titre_Album);
            */
        }
    }
}
