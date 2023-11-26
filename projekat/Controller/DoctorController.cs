using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

using projekat.Service;

namespace projekat.Controller
{
    public class DoctorController
    {
        private readonly DoctorService _service;

        public DoctorController(DoctorService service)
        {
            _service = service;
        }

        public Doctor CreateNewDoctor(Doctor doctor)
        {
            return _service.CreateNewDoctor(doctor);
        }

        public Doctor ReadDoctor(uint id)
        {
            return _service.ReadDoctor(id);
        }

        public Doctor FindDoctorByUsername(string username)
        {
            return _service.FindDoctorByUsername(username);
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            return _service.UpdateDoctor(doctor);
        }

        public Boolean DeleteDoctor(uint id)
        {
            return _service.DeleteDoctor(id);
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _service.GetAll();
        }

    }
}
