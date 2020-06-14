using System;
using System.Collections.Generic;

namespace carm.Models
{
    public partial class Forceins
    {
        public int IdInsurances { get; set; }
        public int InsclassIdinsclass { get; set; }
        public int? Deathinde { get; set; }
        public int? Medinde { get; set; }
        public int? Proinde { get; set; }
        public int? Nrdeathinde { get; set; }
        public int? Nrmedinde { get; set; }
        public int? Nrproinde { get; set; }
        public float? Premium { get; set; }
        public DateTime? Startdate { get; set; }
        public float? Floatratio { get; set; }
        public DateTime? Enddate { get; set; }
        public string Dispute { get; set; }
        public float? Payty { get; set; }
        public float? Paypy { get; set; }
        public float? Lpf { get; set; }
        public float? Ttax { get; set; }
        public DateTime? Signdate { get; set; }
        public string Underwriting { get; set; }
        public string Manufacturing { get; set; }
        public string Handle { get; set; }
        public string Ponum { get; set; }
        public int CarsIdcars { get; set; }

        public virtual Cars CarsIdcarsNavigation { get; set; }
        public virtual Insclass InsclassIdinsclassNavigation { get; set; }
    }
}
