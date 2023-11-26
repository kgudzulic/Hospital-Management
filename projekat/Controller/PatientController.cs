using System;
using System.Collections.Generic;
using Model;
using Service;
namespace Controller
{
   public class PatientController
   {
        private readonly PatientService _service;

        public PatientController(PatientService service)
        {
            _service = service;
        }
        public Patient CreateNewPatient(Patient patient)
        {
            return _service.CreateNewPatient(patient);
        }
      
        public Patient ReadPatient(uint id)
        {
            return _service.ReadPatient(id);
        }

        public Patient FindPatientByUsername(string username)
        {
            return _service.FindPatientByUsername(username);
        }
      
        public Patient UpdatePatient(Patient patient)
        {
            return _service.UpdatePatient(patient);
        }
      
        public Boolean DeletePatient(uint id)
        {
            return _service.DeletePatient(id);
        }
      
        public IEnumerable<Patient> GetAll()
        {
            return _service.GetAll();
        }

        public Patient GetPatient(uint id)
        {
            return _service.GetPatient(id);
        }
   }
}