using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Model
{
    public class Room
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public RoomType Type { get; set; }

        public uint SquareFootage { get; set; }

        public Boolean Availability { get; set; }

        public Room()
        {

        }

        public Room(uint id)
        {
            Id = id;
        }

        public Room(uint id, string name, RoomType type, uint squareFootage, bool availability) : this(id)
        {
            Name = name;
            Type = type;
            SquareFootage = squareFootage;
            Availability = availability;
        }

        public Room(string name, RoomType type, uint squareFootage, bool availability)
        {
            Name = name;
            Type = type;
            SquareFootage = squareFootage;
            Availability = availability;
        }
    }
}
