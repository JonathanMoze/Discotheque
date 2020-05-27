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
    }
}
