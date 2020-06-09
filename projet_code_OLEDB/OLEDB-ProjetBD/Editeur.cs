using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLEDB_ProjetBD
{
    using System;
    using System.Collections.Generic;
    class Editeur
    {
        public Editeur()
        {
            this.Album = new HashSet<Album>();
        }

        public int Code_Editeur { get; set; }
        public string Nom_Editeur { get; set; }
        public Nullable<int> Code_Pays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Album { get; set; }
        public virtual Pays Pays { get; set; }
    }
}
