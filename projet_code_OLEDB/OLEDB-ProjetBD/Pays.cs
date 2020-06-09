using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLEDB_ProjetBD
{
    using System;
    using System.Collections.Generic;
    class Pays
    {
        public Pays()
        {
            this.Abonné = new HashSet<Abonné>();
            this.Editeur = new HashSet<Editeur>();
        }

        public int Code_Pays { get; set; }
        public string Nom_Pays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonné> Abonné { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Editeur> Editeur { get; set; }

        public override string ToString()
        {
            return Nom_Pays;
        }
        public override int GetHashCode()
        {
            return Code_Pays;
        }
    }
}
