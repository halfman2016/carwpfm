﻿using System;
using System.Collections.Generic;

namespace carmwweb31.Models
{
    public partial class Testrec
    {
        public int Idtestrec { get; set; }
        public DateTime? Testdate { get; set; }
        public DateTime Exdate { get; set; }
        public int CarsIdcars { get; set; }

        public virtual Cars CarsIdcarsNavigation { get; set; }
    }
}
