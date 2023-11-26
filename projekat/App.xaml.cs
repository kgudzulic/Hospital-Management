using projekat.Controller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using projekat.Repository;
using projekat.Service;
using Controller;
using Repository;
using Service;

namespace projekat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
          .Split(new string[] { "bin" }, StringSplitOptions.None)[0];
        private string DOCTOR_FILE = _projectPath + "\\Resources\\doctor.txt";
        private string USER_FILE = _projectPath + "\\Resources\\user.txt";
        private string PATIENT_FILE = _projectPath + "\\Resources\\patient.txt";
        private string ALLERGEN_FILE = _projectPath + "\\Resources\\allergen.txt";
        private string ROOM_FILE = _projectPath + "\\Resources\\room.txt";
        private string APPOINTMENT_FILE = _projectPath + "\\Resources\\appointment.txt";
        private string MEDICATION_FILE = _projectPath + "\\Resources\\medications.txt";

        private const string CSV_DELIMITER = ";";
        private const string DATETIME_FORMAT = "dd.MM.yyyy.";

        public DoctorController DoctorController { get; set; }

        public PatientController PatientController { get; set; }

        public AppointmentController AppointmentController { get; set; }

        public RoomController RoomController { get; set; }

        public AllergenController AllergenController { get; set; }

        public MedicineController MedicineController { get; set; }

        App()
        {
            var doctorRepo = new DoctorRepository(DOCTOR_FILE, CSV_DELIMITER, DATETIME_FORMAT);
            var patientRepo = new PatientRepository(PATIENT_FILE, CSV_DELIMITER, DATETIME_FORMAT);
            var roomRepo = new RoomRepository(ROOM_FILE, CSV_DELIMITER, DATETIME_FORMAT);
            var allergenRepo = new AllergenRepository(ALLERGEN_FILE, CSV_DELIMITER, DATETIME_FORMAT);
            var appointmentRepo = new AppointmentRepository(APPOINTMENT_FILE, CSV_DELIMITER, DATETIME_FORMAT);
            var medsRepo = new MedicineRepository(MEDICATION_FILE, CSV_DELIMITER, DATETIME_FORMAT);

            var doctorService = new DoctorService(doctorRepo);
            var patientService = new PatientService(patientRepo);
            var appointmentService = new AppointmentService(appointmentRepo);
            var roomService = new RoomService(roomRepo);
            var allergenService = new AllergenService(allergenRepo);
            var medsService = new MedicineService(medsRepo);

            DoctorController = new DoctorController(doctorService);
            PatientController = new PatientController(patientService);
            AppointmentController = new AppointmentController(appointmentService);
            RoomController = new RoomController(roomService);
            AllergenController = new AllergenController(allergenService);
            MedicineController = new MedicineController(medsService);
        }
    }
}
