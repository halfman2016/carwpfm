using System;

namespace carmins.Models
{
    public partial class Sysusers
    {
        public int Idsysuser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? Createdate { get; set; }
        public string Role { get; set; }
        public int? OrgsIdorgs { get; set; }

        public virtual Orgs OrgsIdorgsNavigation { get; set; }
    }
}
