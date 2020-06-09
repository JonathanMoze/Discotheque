using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLEDB_ProjetBD
{
    using System;
    using System.Collections.Generic;
    class Abonné
    {

        public Abonné()
        {
            this.Emprunter = new HashSet<Emprunter>();
        }

        public int Code_Abonné { get; set; }
        public string Nom_Abonné { get; set; }
        public string Prénom_Abonné { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> Code_Pays { get; set; }

        public virtual ICollection<Emprunter> Emprunter { get; set; }
    }
}
