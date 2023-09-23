using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AM_Hotel.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int NationalId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public string PhoneNumber { get; set; }

        public User(int id, int nationalId, string name, string email, string password, string phoneNumber)
        {
            Id = id;
            NationalId = nationalId;
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
    }
