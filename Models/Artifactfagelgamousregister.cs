using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_II.Models
{
    public partial class Artifactfagelgamousregister
    {
        [Key]
        public long Id { get; set; }
        public string Registernum { get; set; }
        public string Photographed { get; set; }
        public string Notes { get; set; }
        public string Coordinateset { get; set; }
    }
}
