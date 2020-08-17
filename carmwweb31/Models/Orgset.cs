using System;
using System.Collections.Generic;

namespace carmwweb31.Models
{
    public partial class Orgset
    {
        public int? Days { get; set; }
        public string Sms { get; set; }
        public int OrgsIdorgs { get; set; }

        public virtual Orgs OrgsIdorgsNavigation { get; set; }
    }
}
