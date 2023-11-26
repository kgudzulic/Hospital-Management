using projekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Service;

namespace projekat.Controller
{
    public class AppointmentController
    {
        private readonly AppointmentService _service;

        public AppointmentController(AppointmentService service)
        {
            _service = service;
        }
        public Appointment CreateNewAppointment(Appointment appointment)
        {
            return _service.CreateNewAppointment(appointment);
        }

        public Boolean DeleteApointment(uint id)
        {
            return _service.DeleteApointment(id);
        }

        public Model.Appointment UpdateApointment(Appointment appointment)
        {
            return _service.UpdateApointment(appointment);
        }

        public Model.Appointment GetApointment(uint id)
        {
            return _service.GetApointment(id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _service.GetAll();
        }
    }
}
