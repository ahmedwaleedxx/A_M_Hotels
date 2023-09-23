using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_Hotel.Models
{
    public class Guest : User
    {
        public Guest(int id, int nationalId, string name, string email, string password, string phoneNumber) : base(id, nationalId, name, email, password, phoneNumber)
        {
        }

    }
}