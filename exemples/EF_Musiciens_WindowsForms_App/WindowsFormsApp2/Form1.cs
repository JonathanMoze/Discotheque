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
                MyMusicien mm = new MyMusicien(m);
                listBox1.Items.Add(mm);
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
                MyMusicien mm = new MyMusicien(m);
                listBox1.Items.Add(mm);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            MyMusicien x = (MyMusicien)listBox1.SelectedItem;
            Musicien m = x.me;
            
            foreach (Oeuvre o in m.Oeuvre)
            {
                //MyOeuvre oo = new MyOeuvre(o);
                //listBox2.Items.Add(oo);
                listBox2.Items.Add(o.Titre_Oeuvre);
            }
            /*
            foreach (Diriger d in x.me.Diriger)
                foreach (Composition_Disque c in d.Enregistrement.Composition_Disque)
                    listBox2.Items.Add(c.Disque.Album.Titre_Album);
            */
        }
    }
}
