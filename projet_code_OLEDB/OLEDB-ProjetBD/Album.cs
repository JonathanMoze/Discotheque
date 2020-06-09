using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLEDB_ProjetBD
{
    using System;
    using System.Collections.Generic;
    class Album
    {
        public Album()
        {
            this.Emprunter = new HashSet<Emprunter>();
        }

        public int Code_Album { get; set; }
        public string Titre_Album { get; set; }
        public Nullable<int> Année_Album { get; set; }
        public Nullable<int> Code_Genre { get; set; }
        public Nullable<int> Code_Editeur { get; set; }
        public byte[] Pochette { get; set; }
        public string ASIN { get; set; }

        public virtual Editeur Editeur { get; set; }
        public virtual Genre Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprunter> Emprunter { get; set; }

        public override int GetHashCode()
        {
            return Code_Album;
        }
    }
}
