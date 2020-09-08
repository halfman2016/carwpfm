using System.Collections.Generic;

namespace carmins.Models
{
    public partial class Orgs
    {
        public Orgs()
        {
            Cars = new HashSet<Cars>();
            People = new HashSet<People>();
            Sysusers = new HashSet<Sysusers>();
        }

        public int Idorgs { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Addr { get; set; }

        public virtual Orgset Orgset { get; set; }
        public virtual ICollection<Cars> Cars { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<Sysusers> Sysusers { get; set; }
    }
}
