using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Exception;

namespace projekat.Repository
{
    public class DoctorRepository
    {
        private const string NOT_FOUND_ERROR = "Account with {0}:{1} can not be found!";
        private readonly string _path;
        private readonly string _delimeter;
        private readonly string _dateTimeFormat;
        private uint _doctorMaxId;
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];
        private FileStream temp;

        public DoctorRepository(string path, string delimeter, string dateTimeFormat)
        {
            _path = path;
            _delimeter = delimeter;
            _dateTimeFormat = dateTimeFormat;
            _doctorMaxId = GetMaxId(GetAll());
        }

        private uint GetMaxId(IEnumerable<Doctor> doctors)
        {
            return doctors.Count() == 0 ? 0 : doctors.Max(doctor => doctor.Id);
        }

        public Doctor AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(uint id)
        {
            try
            {
                return GetAll().SingleOrDefault(doctor => doctor.Id == id);
            }
            catch (ArgumentException)
            {
                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "id", id));
            }
        }

        public Doctor FindDoctorByUsername(string username)
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

        public Doctor UpdateDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Boolean RemoveDoctor(uint id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetAll()
        {
            return File.ReadAllLines(_path)
             .Select(ConvertCSVFormatToDoctor)
             .ToList();
        }

        private Doctor ConvertCSVFormatToDoctor(string doctorCSVFormat)
        {
            Doctor doctor = new Doctor();
            string[] tokens = doctorCSVFormat.Split(_delimeter.ToCharArray());

            uint Id = uint.Parse(tokens[0]);
            string Username = tokens[1];
            string Password = tokens[2];
            string Name = tokens[3];
            string Surname = tokens[4];
            string Adress = tokens[5];
            string Email = tokens[6];
            Enum.TryParse(tokens[7], out Gender gender);
            DateTime.Parse(tokens[8]);
            Enum.TryParse(tokens[9], out Specialization spec);

            return new Doctor(
                Id,
                Name,
                Surname,
                DateTime.Parse(tokens[8]),
                spec,
                Adress,
                Email,
                gender,
                Username,
                Password
            );
        }

        private string ConvertPatientToCSVFormat(Doctor doctor)
        {
            return string.Join(_delimeter,
                doctor.Id,
                doctor.Name,
                doctor.Surname,
                doctor.Adress,
                doctor.Email,
                doctor.Gender,
                doctor.DateOfBirth,
                doctor.Specialization);
        }

        private void AppendLineToFile(string path, string line)
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }
    }
}
