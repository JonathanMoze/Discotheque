using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MAJ_CHAMPIONNAT
{
    class MyEquipe
    {
        public EQUIPES me { get; set; }
        public MyEquipe(EQUIPES e)
        {
            me = e;
        }
        public override string ToString()
        {
            return me.VILLE;
        }

    }
}
