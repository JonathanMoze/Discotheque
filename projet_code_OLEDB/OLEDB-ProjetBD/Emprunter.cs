using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLEDB_ProjetBD
{
    using System;
    using System.Collections.Generic;
    class Emprunter
    {
        public int Code_Abonné { get; set; }
        public int Code_Album { get; set; }
        public Nullable<System.DateTime> Date_Emprunt { get; set; }
        public Nullable<System.DateTime> Date_Retour { get; set; }

        public virtual Abonné Abonné { get; set; }
        public virtual Album Album { get; set; }
    }
}
