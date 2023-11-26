// File:    PatientRepository.cs
// Author:  3500x
// Created: 12 April 2022 19:00:06
// Purpose: Definition of Class PatientRepository

using System;
using Repository;

using System.Collections.Generic;
using Model;
namespace Service
{
   public class PatientService
   {
        private readonly PatientRepository _repo;

        public PatientService(PatientRepository repo)
        {
            _repo = repo;
        }

        public Patient CreateNewPatient(Patient patient)
        {
            return _repo.AddPatient(patient);
        }

        public Patient ReadPatient(uint id)
        {
            return _repo.GetPatient(id);
        }

        public Patient FindPatientByUsername(string username)
        {
            return _repo.FindPatientByUsername(username);
        }

        public Patient UpdatePatient(Patient patient)
        {
            return _repo.UpdatePatient(patient);
        }

        public Boolean DeletePatient(uint id)
        {
            return _repo.RemovePatient(id);
        }

        public IEnumerable<Patient> GetAll()
        {
            return _repo.GetAll();
        }

        public Patient GetPatient(uint id)
        {
            return _repo.GetPatient(id);
        }
    }
}