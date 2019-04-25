﻿using System.Data.Entity;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Bridgeport_Library.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string TelephoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        [Required]
        public int TRN { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class  ApplicationRole:IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) {  }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BorrowHistory>BorrowHistories { get; set; }

        public System.Data.Entity.DbSet<Bridgeport_Library.Models.RoleViewModel> RoleViewModels { get; set; }
    }
}