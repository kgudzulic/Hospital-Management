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
using projekat.Model;
using projekat.Controller;
using Controller;
using System.Collections.ObjectModel;
using Model;
using System.Text.RegularExpressions;

namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for AddAppointment.xaml
    /// </summary>
    public partial class AddAppointment : Window
    {
        private AppointmentController _appointmentController;
        private RoomController _roomController;
        private DoctorController _doctorController;
        private PatientController _patientControler;

        public uint _id;
        private uint _doctorId;
        private uint _patientId;
        private uint _roomId;
        //private uint _idDelete;

        public AddAppointment(uint id)
        {
            _id = id;
            InitializeComponent();
            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            _roomController = app.RoomController;
            _doctorController = app.DoctorController;
            _patientControler = app.PatientController;
        }

        private void Rooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBox)sender;
            var rm = (Room)item.SelectedItem;
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            var Appoint = new ObservableCollection<Appointment>(_appointmentController.GetAll());
            int i = Appoint.Count() + 1;

            var roomsCB = new ObservableCollection<Room>(_roomController.GetAll());
            Rooms.ItemsSource = roomsCB;
            DataContext = this;

            var docsCB = new ObservableCollection<Doctor>(_doctorController.GetAll());
            Doctors.ItemsSource = docsCB;
            DataContext = this;

            var patsCB = new ObservableCollection<Patient>(_patientControler.GetAll());
            Patients.ItemsSource = patsCB;
            DataContext = this;

            tb1.Text = i.ToString();
        }

        private void Doctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBox)sender;
            var dt = (Doctor)item.SelectedItem;
        }

        private void Patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBox)sender;
            var pt = (Patient)item.SelectedItem;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            var Aptm = new ObservableCollection<Appointment>(_appointmentController.GetAll());
            int i = Aptm.Count() + 1;


            if (tb2.Text.Length == 0 || tb2.Text.Length == 0 || Rooms.SelectedItem == null || Doctors.SelectedItem == null || Patients.SelectedItem == null)
            {
                errormessage.Text = "All fields must be filled.";
                if(tb1.Text.Length == 0)
                {
                    tb1.Focus();
                }
                else if (tb2.Text.Length == 0)
                {
                    tb2.Focus();
                }
                else if (Doctors.SelectedItem == null)
                {
                    Doctors.Focus();
                }
                else if (Patients.SelectedItem == null)
                {
                    Patients.Focus();
                }
                else if (Rooms.SelectedItem == null)
                {
                    Rooms.Focus();
                }
            }
            /*else if (Regex.IsMatch(tb1.Text, @"^[A-Za-z]*$"))
            {
                errormessage.Text = "Enter a valid time format.";
                tb1.Select(0, tb1.Text.Length);
                tb1.Focus();
            }
            else if (Regex.IsMatch(tb2.Text, @"^[A-Za-z]*$"))
            {
                errormessage.Text = "Enter a valid time format.";
                tb2.Select(0, tb2.Text.Length);
                tb2.Focus();
            }*/
            else
            {
                Room roomItem = Rooms.SelectedItem as Room;
                uint roomId = roomItem.Id;

                Doctor doctorItem = Doctors.SelectedItem as Doctor;
                uint doctorId = doctorItem.Id;

                Patient patientItem = Patients.SelectedItem as Patient;
                uint patientId = patientItem.Id;

                Room rm = _roomController.FindRoom(roomId);
                Doctor dc = _doctorController.ReadDoctor(doctorId);
                Patient pt = _patientControler.ReadPatient(patientId);

                Appointment appointment = new Appointment((uint)i, Convert.ToDateTime(tb2.Text), Convert.ToDateTime(tb3.Text), dc.Id, pt.Id, rm.Id);
                _appointmentController.CreateNewAppointment(appointment);

                AppointmView ae2 = new AppointmView(_id);
                ae2.Show();
                this.Close();
            }
        }
    }
}
