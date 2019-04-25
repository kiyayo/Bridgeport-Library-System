using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bridgeport_Library.Models
{
    public class BorrowHistory
    {
        public int BorrowHistoryId { get; set; }
        [Required]
        [Display(Name="Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Required]
        [Display(Name="Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        [Display(Name= "Borrow Date")]
        public DateTime BorrowDate { get; set; }
        [Display(Name="Return Date")]
        public DateTime? ReturnDate { get; set; }

    }
}