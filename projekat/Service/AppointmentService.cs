using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Model;
using projekat.Repository;

namespace projekat.Service
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _repo;

        public AppointmentService(AppointmentRepository repo)
        {
            _repo = repo;
        }
        public Appointment CreateNewAppointment(Appointment appointment)
        {
            return _repo.CreateNewAppointment(appointment);
        }

        public Boolean DeleteApointment(uint id)
        {
            return _repo.DeleteApointment(id);
        }

        public Appointment UpdateApointment(Appointment apointment)
        {
            return _repo.UpdateApointment(apointment);
        }

        public Appointment GetApointment(uint id)
        {
            return _repo.GetApointment(id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _repo.GetAll();
        }

        public AppointmentRepository apointmentRepository;
    }
}
