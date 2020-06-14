using System;
using System.Collections.Generic;

namespace carm.Models
{
    public partial class Cars
    {
        public Cars()
        {
            Comins = new HashSet<Comins>();
            Forceins = new HashSet<Forceins>();
            Testrec = new HashSet<Testrec>();
        }

        public int Idcars { get; set; }
        public string Carplate { get; set; }
        public string Cartype { get; set; }
        public string Caraddress { get; set; }
        public string Caruae { get; set; }
        public string Carbrand { get; set; }
        public string Carvin { get; set; }
        public string Carengine { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Applydate { get; set; }
        public string Filenum { get; set; }
        public string Carcarry { get; set; }
        public string Carmass { get; set; }
        public string Carcarrymass { get; set; }
        public string Caremass { get; set; }
        public string Carappeara { get; set; }
        public DateTime? Carscrapdate { get; set; }
        public string Carfule { get; set; }
        public string Papercode { get; set; }
        public int OwnersIdowners { get; set; }
        public int OrgsIdorgs { get; set; }

        public virtual Orgs OrgsIdorgsNavigation { get; set; }
        public virtual ICollection<Comins> Comins { get; set; }
        public virtual ICollection<Forceins> Forceins { get; set; }
        public virtual ICollection<Testrec> Testrec { get; set; }
    }
}
