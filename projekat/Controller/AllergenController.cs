using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Model;
using projekat.Service;

namespace projekat.Controller
{
    public class AllergenController
    {
        private readonly AllergenService _service;
        public AllergenController(AllergenService service)
        {
            _service = service;
        }
        public Model.Allergen CreateNewAllergen(Model.Allergen allergen)
        {
            return _service.CreateNewAllergen(allergen);
        }

        public Model.Allergen GetAllergen(uint id)
        {
            return _service.GetAllergen(id);
        }

        public Model.Allergen UpdateAllergen(Model.Allergen allergen)
        {
            return _service.UpdateAllergen(allergen);
        }

        public Boolean DeleteAllergen(uint id)
        {
            return _service.DeleteAllergen(id);
        }

        public IEnumerable<Allergen> GetAll()
        {
            return _service.GetAll();
        }
    }
}
