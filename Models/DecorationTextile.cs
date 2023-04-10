﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_II.Models
{
    public partial class DecorationTextile
    {
        public long MainDecorationid { get; set; }
        public long MainTextileid { get; set; }
    }
}
