using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyOeuvre
    {
        public Oeuvre me { get; set; }
        public MyOeuvre(Oeuvre m)
        {
            me = m;
        }
        public override string ToString()
        {
            return me.Titre_Oeuvre;
        }
    }
}
