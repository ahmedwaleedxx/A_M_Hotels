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
        public int userId {  get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string userEmail { get; set; }
        public string mobileNumber { get; set; }
        public string nationalID { get; set; }

    }
}