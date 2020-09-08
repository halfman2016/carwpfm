using System;

namespace carmins.Models
{
    public partial class Drivers
    {
        public int Iddriver { get; set; }
        public string Name { get; set; }
        public string Licenseno { get; set; }
        public DateTime? Applydate { get; set; }
        public int? PeopleIdpeople { get; set; }

        public virtual People PeopleIdpeopleNavigation { get; set; }
    }
}
