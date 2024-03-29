﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bridgeport_Library.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }
        public string Rating { get; set; }

        public bool IsAvailable { get; set; }

    }
}