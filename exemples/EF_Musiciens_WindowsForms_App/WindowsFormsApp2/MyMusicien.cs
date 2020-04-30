using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyMusicien
    {
        public Musicien me { get; set; }
        public MyMusicien(Musicien m)
        {
            me = m;
        }
        public override string ToString()
        {
            return me.Nom_Musicien + " " + me.Prénom_Musicien;
        }
    }
}
