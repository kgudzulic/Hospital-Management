using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using projekat.Controller;
using Controller;
using projekat.Model;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace projekat.View.Dialogs
{
    partial class AppointmView : Window
    {
        private uint _id;
        private AppointmentController _appointmentController;
        private RoomController _roomController;
        private DoctorController _doctorController;
        private PatientController _patientControler;

        private DateTime _startAppointment;
        private DateTime _endAppointment;
        private uint _doctorId;
        private uint _patientId;
        private uint _roomId;
        private uint _idDelete;

        public string t;
        public string d;
        DateTime dt;

        public ObservableCollection<Appointment> Data { get; set; }

        public ObservableCollection<Patient> People { get; set; }

        public AppointmView(uint id)
        {
            _id = id;
            InitializeComponent();
            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            _roomController = app.RoomController;
            _doctorController = app.DoctorController;
            _patientControler = app.PatientController;

            People = new ObservableCollection<Patient>(_patientControler.GetAll());

            Data = new ObservableCollection<Appointment>(_appointmentController.GetAll().ToList());


            for (int i = 0; i < Data.Count(); i++)
            {
                Room room = _roomController.FindRoom(Data[i].IdRoom);
                Doctor doctor = _doctorController.ReadDoctor(Data[i].IdDoctor);
                Patient patient = _patientControler.ReadPatient(Data[i].IdPatient);
                Data[i].RoomName = room.Name;
                Data[i].DoctorName = doctor.Name;
                Data[i].DoctorSurname = doctor.Surname;
                Data[i].PatientUsername = patient.Username;
                Data[i].PatientName = patient.Name;
                Data[i].PatientSurname = patient.Surname;

                if (Data[i].IdDoctor == _id)
                {
                    DataGridXAML.Items.Add(Data[i]);
                }
            }
            Appointment ap = DataGridXAML.SelectedItem as Appointment;
        }

        public DateTime StartAppointment
        {
            get => _startAppointment;
            set
            {
                if (_startAppointment != value)
                {
                    _startAppointment = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime EndAppointment
        {
            get => _endAppointment;
            set
            {
                if (_endAppointment != value)
                {
                    _endAppointment = value;
                    OnPropertyChanged();
                }
            }
        }

        public uint Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        public uint IdDelete
        {
            get => _idDelete;
            set
            {
                if (_idDelete != value)
                {
                    _idDelete = value;
                    OnPropertyChanged();
                }
            }
        }

        public uint IdDoctor
        {
            get => _doctorId;
            set
            {
                if (_doctorId != value)
                {
                    _doctorId = value;
                    OnPropertyChanged();
                }
            }
        }

        public uint IdPatient
        {
            get => _patientId;
            set
            {
                if (_patientId != value)
                {
                    _patientId = value;
                    OnPropertyChanged();
                }
            }
        }

        public uint IdRoom
        {
            get => _roomId;
            set
            {
                if (_roomId != value)
                {
                    _roomId = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Appointment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            addBtn.IsEnabled = true;
            editBtn.IsEnabled = false;
            removeBtn.IsEnabled = false;
        }

        private void DataGridXAML_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            addBtn.IsEnabled = true;
            editBtn.IsEnabled = true;
            removeBtn.IsEnabled = true;
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Appointment apt = DataGridXAML.SelectedItem as Appointment;
            Appointment temp = _appointmentController.GetApointment(apt.Id);
            new EditAppointment(_id, apt.Id)
            {
                Owner = Application.Current.MainWindow
            }.ShowDialog();
            this.Close();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            new DoctorHomepage(_doctorId)
            {
                Owner = Application.Current.MainWindow
            };
            this.Close();
        }

        private void patinfo_Click(object sender, RoutedEventArgs e)
        {
            new PatientsView(_doctorId)
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _doctorId = 555;
            new DoctorLogin()
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
            this.Close();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddAppointment(_id)
            {
                Owner = Application.Current.MainWindow
            }.ShowDialog();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            DataContext = this;

            Appointment ap = DataGridXAML.SelectedItem as Appointment;
            _appointmentController.DeleteApointment(ap.Id);

            for (int i = 0; i < Data.Count(); i++)
            {
                if (Data[i].Id == ap.Id)
                {
                    DataGridXAML.Items.Remove(Data[i]);
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new DoctorHomepage(_doctorId)
            {
                Owner = Application.Current.MainWindow
            };
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            new AppointmView(_doctorId)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            new ReqTimeOff(_doctorId)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            new PatientsView(_doctorId)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            new UMeds(_doctorId)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            new AnamnesisView(_doctorId)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            _doctorId = 555;
            new DoctorLogin()
            {
                Owner = Application.Current.MainWindow
            }.ShowDialog();
            this.Close();
        }
    }
}
