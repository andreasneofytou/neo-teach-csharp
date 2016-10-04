using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace Teach.Models {
    public class User : IdentityUser<int> {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinedDate { get; set; }
        public Address Address { get; set; }
        public bool IsActive { get; set; }
    }
}
