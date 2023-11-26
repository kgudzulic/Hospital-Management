using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Repository;
using Model;
using projekat.Model;

namespace projekat.Service
{
    public class MedicineService
    {
        private readonly MedicineRepository _repo;
        public MedicineService(MedicineRepository repository)
        {
            _repo = repository;
        }
        public Model.Medicine CreateNewMedicine(Model.Medicine medicine)
        {
            return _repo.CreateNewMedicine(medicine);
        }

        public Model.Medicine GetMedicine(uint id)
        {
            return _repo.GetMedicine(id);
        }

        public Model.Medicine UpdateMedicine(Model.Medicine medicine)
        {
            return _repo.UpdateMedicine(medicine);
        }

        public Boolean DeleteMedicine(uint id)
        {
            return _repo.DeleteMedicine(id);
        }

        public IEnumerable<Medicine> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
