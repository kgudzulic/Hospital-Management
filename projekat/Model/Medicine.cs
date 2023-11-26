using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace projekat.Model
{
    public class Medicine
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string Ingredients { get; set; }

        public uint AllergenId { get; set; }

        public Boolean IsApproved { get; set; }

        public Medicine()
        {
        }

        public Medicine(uint id)
        {
            Id = id;
        }

        public Medicine(uint id, string name, string ingredients, uint allergenId, bool isApproved) : this(id)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            AllergenId = allergenId;
            IsApproved = isApproved;
        }

        public Medicine(string name, string ingredients, uint allergenId, bool isApproved)
        {
            Name = name;
            Ingredients = ingredients;
            AllergenId = allergenId;
            IsApproved = isApproved;
        }
    }
}
