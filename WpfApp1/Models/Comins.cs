using System;
using System.Collections.Generic;

namespace carm.Models
{
    public partial class Comins
    {
        public int IdCommerceins { get; set; }
        public int? Amount { get; set; }
        public string Ponum { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int InsclassIdinsclass { get; set; }
        public int CarsOwnersIdowners { get; set; }
        public int CarsIdcars { get; set; }

        public virtual Cars CarsIdcarsNavigation { get; set; }
        public virtual Insclass InsclassIdinsclassNavigation { get; set; }
    }
}
