using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using projekat.Model;
using projekat.Repository;

namespace projekat.Service
{
    public class AllergenService
    {
        private readonly AllergenRepository _repo;
        public AllergenService(AllergenRepository repository)
        {
            _repo = repository;
        }
        public Model.Allergen CreateNewAllergen(Model.Allergen allergen)
        {
            return _repo.CreateNewAllergen(allergen);
        }

        public Model.Allergen GetAllergen(uint id)
        {
            return _repo.GetAllergen(id);
        }

        public Model.Allergen UpdateAllergen(Model.Allergen allergen)
        {
            return _repo.UpdateAllergen(allergen);
        }

        public Boolean DeleteAllergen(uint id)
        {
            return _repo.DeleteAllergen(id);
        }

        public IEnumerable<Allergen> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
