using System;
using System.Collections.Generic;

namespace carm.Models
{
    public partial class People
    {
        public People()
        {
            Drivers = new HashSet<Drivers>();
        }

        public int Idpeople { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Mobile { get; set; }
        public int? OrgsIdorgs { get; set; }
        public string Addr { get; set; }

        public virtual Orgs OrgsIdorgsNavigation { get; set; }
        public virtual ICollection<Drivers> Drivers { get; set; }
    }
}
