using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AM_Hotel.Models
{
    public abstract class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int roomID { get; set; }
        public string roomName { get; set;}
        public string roomFloor { get; set; }
        public string roomCapacity { get; set; }
        public string roomAvailability { get; set; }


    }
}