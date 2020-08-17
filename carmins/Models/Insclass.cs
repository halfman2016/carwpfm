using System;
using System.Collections.Generic;

namespace carmins.Models
{
    public partial class Insclass
    {
        public Insclass()
        {
            Comins = new HashSet<Comins>();
            Forceins = new HashSet<Forceins>();
        }

        public int Idinsclass { get; set; }
        public string Insname { get; set; }
        public string Inscorp { get; set; }
        public string Instype { get; set; }
        public string Corpaddr { get; set; }
        public string Corppostcode { get; set; }
        public string Corptele { get; set; }

        public virtual ICollection<Comins> Comins { get; set; }
        public virtual ICollection<Forceins> Forceins { get; set; }
    }
}
