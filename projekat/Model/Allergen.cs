using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Model
{
    public class Allergen
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public Allergen()
        {
        }

        public Allergen(string name)
        {
            Name = name;
        }

        public Allergen(uint id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
