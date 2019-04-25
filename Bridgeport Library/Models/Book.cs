using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Bridgeport_Library.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; }
        [Required]
        public string Rating { get; set; }
        public ICollection BorrowHistories { get; set; }
    }
}