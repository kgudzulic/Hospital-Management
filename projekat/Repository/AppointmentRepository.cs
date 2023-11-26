using projekat.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Exception;

namespace projekat.Repository
{
    public class AppointmentRepository
    {
        private const string NOT_FOUND_ERROR = "Account with {0}:{1} can not be found!";
        private readonly string _path;
        private readonly string _delimeter;
        private readonly string _dateTimeFormat;
        private uint _appointmentMaxId;
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];
        private FileStream temp;
        private String fileName;

        public AppointmentRepository(string path, string delimeter, string dateTimeFormat)
        {
            _path = path;
            _delimeter = delimeter;
            _dateTimeFormat = dateTimeFormat;
            _appointmentMaxId = GetMaxId(GetAll());
        }

        private uint GetMaxId(IEnumerable<Appointment> appointments)
        {
            return appointments.Count() == 0 ? 0 : appointments.Max(appointment => appointment.Id);
        }

        public Appointment CreateNewAppointment(Appointment appointment)
        {
            appointment.Id = ++_appointmentMaxId;
            AppendLineToFile(_path, ConvertAppointmentToCSVFormat(appointment));
            return appointment;
        }

        public Boolean DeleteApointment(uint id)
        {
            Boolean retVal = false;
            IEnumerable<Appointment> appointments = GetAll();

            appointments = appointments.Where(a => a.Id != id).ToList();

            string temp_file = _projectPath + "\\Resources\\temp1.txt";
            string appointment_file = _projectPath + "\\Resources\\appointment.txt";

            using (var sr = new StreamReader(appointment_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Appointment appointment = ConvertCSVFormatToAppointment(line);
                    if (appointment.Id != id)
                    {
                        retVal = true;
                        sw.WriteLine(line);
                    }
                }
            }

            File.Delete(appointment_file);
            File.Move(temp_file, appointment_file);
            return retVal;
        }

        public Appointment UpdateApointment(Appointment apointment)
        {
            string temp_file = _projectPath + "\\Resources\\tempAPP.txt";
            string _file = _projectPath + "\\Resources\\appointment.txt";

            using (var sr = new StreamReader(_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string lineToWrite = ConvertAppointmentToCSVFormat(apointment);
                    Appointment tempApp = ConvertCSVFormatToAppointment(line);
                    if (apointment.Id != tempApp.Id)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        sw.WriteLine(lineToWrite);
                    }
                }
            }
            File.Delete(_file);
            File.Move(temp_file, _file);
            return apointment;
        }

        public Appointment GetApointment(uint id)
        {
            try
            {
                return GetAll().SingleOrDefault(apointment => apointment.Id == id);
            }
            catch (ArgumentException)
            {
                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "id", id));
            }
        }

        public IEnumerable<Appointment> GetAll()
        {
            return File.ReadAllLines(_path)
                .Select(ConvertCSVFormatToAppointment)
                .ToList();
        }

        private Appointment ConvertCSVFormatToAppointment(string appointmentCSVFormat)
        {
            Appointment Appointment = new Appointment();
            string[] tokens = appointmentCSVFormat.Split(_delimeter.ToCharArray());

            uint Id = uint.Parse(tokens[0]);
            DateTime.Parse(tokens[1]);
            DateTime.Parse(tokens[2]);
            uint IdDoctor = uint.Parse(tokens[3]);
            uint IdPatinet = uint.Parse(tokens[4]);
            uint IdRoom = uint.Parse(tokens[5]);

            return new Appointment(
                Id,
                DateTime.Parse(tokens[1]),
                DateTime.Parse(tokens[2]),
                IdDoctor,
                IdPatinet,
                IdRoom
            );
        }
        private string ConvertAppointmentToCSVFormat(Appointment Appointment)
        {
            return string.Join(_delimeter,
                Appointment.Id,
                Appointment.StartAppointment,
                Appointment.EndAppointment,
                Appointment.IdDoctor,
                Appointment.IdPatient,
                Appointment.IdRoom);
        }

        private void AppendLineToFile(string path, string line)
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }
    }
}
