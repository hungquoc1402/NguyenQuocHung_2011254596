﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenQuocHung_2011254596.Models
{
    public class Category
    {       
            public byte Id { get; set; }
            [Required]
            [StringLength(255)]
            public string Name { get; set; }       
    }
}