using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM_Hotel.Models
{
    public class Employee : User
    {
        public Employee(int id, int nationalId, string name, string email, string password, string phoneNumber) : base(id, nationalId, name, email, password, phoneNumber)
        {
        }
    }
}