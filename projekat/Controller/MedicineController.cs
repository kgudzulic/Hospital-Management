using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using projekat.Service;
using Model;
using projekat.Model;

namespace projekat.Controller
{
    public class MedicineController
    {
        private readonly MedicineService _service;
        public MedicineController(MedicineService service)
        {
            _service = service;
        }
        public Model.Medicine CreateNewMedicine(Model.Medicine medicine)
        {
            return _service.CreateNewMedicine(medicine);
        }

        public Model.Medicine GetMedicine(uint id)
        {
            return _service.GetMedicine(id);
        }

        public Model.Medicine UpdateMedicine(Model.Medicine medicine)
        {
            return _service.UpdateMedicine(medicine);
        }

        public Boolean DeleteMedicine(uint id)
        {
            return _service.DeleteMedicine(id);
        }

        public IEnumerable<Medicine> GetAll()
        {
            return _service.GetAll();
        }
    }
}
