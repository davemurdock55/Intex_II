﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_II.Models
{
    public partial class Textile
    {
        [Key]
        public long Id { get; set; }
        public string Locale { get; set; }
        public int? Textileid { get; set; }
        public string Description { get; set; }
        public string Burialnumber { get; set; }
        public string Estimatedperiod { get; set; }
        public DateTime? Sampledate { get; set; }
        public DateTime? Photographeddate { get; set; }
        public string Direction { get; set; }
    }
}
