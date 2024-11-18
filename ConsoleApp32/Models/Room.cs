using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32.Models
{
    internal class Room
    {
        public int Id { get; set; }
        public int No { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
