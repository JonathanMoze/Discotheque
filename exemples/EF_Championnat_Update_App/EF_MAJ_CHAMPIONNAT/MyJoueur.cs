using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MAJ_CHAMPIONNAT
{
    class MyJoueur
    {
        public JOUEURS me { get; set; }

        public MyJoueur(JOUEURS j)
        {
            me = j;
        }
        public override string ToString()
        {
            return me.NOM + " (" + me.SALAIRE + ", " + me.EQUIPES.VILLE + ")";
        }

    }
}
