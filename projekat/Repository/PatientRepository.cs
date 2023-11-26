// File:    PatientRepository.cs
// Author:  3500x
// Created: 12 April 2022 19:14:48
// Purpose: Definition of Class PatientRepository

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model;
using projekat.Exception;

namespace Repository
{
   public class PatientRepository
   {
        private const string NOT_FOUND_ERROR = "Account with {0}:{1} can not be found!";
        private readonly string _path;
        private readonly string _delimeter;
        private readonly string _dateTimeFormat;
        private uint _patientrMaxId;
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];
        private FileStream temp;

        public PatientRepository(string path, string delimeter, string dateTimeFormat)
        {
            _path = path;
            _delimeter = delimeter;
            _dateTimeFormat = dateTimeFormat;
            _patientrMaxId = GetMaxId(GetAll());
        }

        private uint GetMaxId(IEnumerable<Patient> patients)
        {
            return patients.Count() == 0 ? 0 : patients.Max(patient => patient.Id);
        }

        public Patient AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatient(uint id)
        {
            try
            {
                return GetAll().SingleOrDefault(patient => patient.Id == id);
            }
            catch (ArgumentException)
            {
                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "id", id));
            }
        }

        public Patient FindPatientByUsername(string username)
        {
            try
            {
                return GetAll().SingleOrDefault(user => user.Username == username);
            }
            catch (ArgumentException)
            {
                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "username", username));
            }
        }

        public Patient UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Boolean RemovePatient(uint id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> GetAll()
        {
            return File.ReadAllLines(_path)
             .Select(ConvertCSVFormatToPatient)
             .ToList();
        }

        private Patient ConvertCSVFormatToPatient(string patientCSVFormat)
        {
            Patient patient = new Patient();
            string[] tokens = patientCSVFormat.Split(_delimeter.ToCharArray());

            uint Id = uint.Parse(tokens[0]);
            string Username = tokens[1];
            string Password = tokens[2];
            string Name = tokens[3];
            string Surname = tokens[4];
            string Adress = tokens[5];
            string Email = tokens[6];
            Enum.TryParse(tokens[7], out Gender gender);
            DateTime.Parse(tokens[8]);

            return new Patient(
                Id,
                Name,
                Surname,
                DateTime.Parse(tokens[8]),
                Adress,
                Email,
                gender,
                Password,
                Username
            );
        }

        private string ConvertPatientToCSVFormat(Patient patient)
        {
            return string.Join(_delimeter,
                patient.Id,
                patient.Username,
                patient.Password,
                patient.Name,
                patient.Surname,
                patient.Adress,
                patient.Email,
                patient.Gender,
                patient.DateOfBirth
                );
        }

        private void AppendLineToFile(string path, string line)
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }

    }
}