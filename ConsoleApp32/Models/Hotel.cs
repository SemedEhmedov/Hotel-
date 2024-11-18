using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32.Models
{
    internal class Hotel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int CustomersCount { get; set; }
        public int RoomCount { get; set; }
        public int Rating { get; set; }
    }
}
