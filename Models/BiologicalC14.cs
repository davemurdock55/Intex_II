using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_II.Models
{
    public partial class BiologicalC14
    {
        [Key]
        public long MainBiologicalid { get; set; }
        [Key]
        public long MainC14id { get; set; }
    }
}
