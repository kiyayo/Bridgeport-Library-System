﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bridgeport_Library.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        public string Name { get; set; }
        
       
    }
}