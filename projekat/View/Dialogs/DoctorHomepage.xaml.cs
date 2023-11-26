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
using Model;

namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for DoctorHomepage.xaml
    /// </summary>
    public partial class DoctorHomepage : Window
    {
        private DoctorController _doctorController;
        private uint _id_logged_in;
        public DoctorHomepage(uint id)
        {
            _id_logged_in = id;
            InitializeComponent();
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
            Doctor doctor = _doctorController.ReadDoctor(_id_logged_in);
            var DAT = doctor.DateOfBirth;
            tb1.Text = doctor.Username;
            tb2.Text = doctor.Name;
            tb3.Text = doctor.Surname;
            tb4.Text = doctor.Adress;
            tb5.Text = doctor.Email;
            tb6.Text = DAT.ToString("dd/MM/yyyy");
            tb7.Text = doctor.Specialization.ToString();

            if (doctor.Gender.ToString() == "F")
            {
                Uri resourceUri = new Uri("/img/doctor-f.png", UriKind.Relative);
                profPic.Source = new BitmapImage(resourceUri);
            }
            else if(doctor.Gender.ToString() == "M")
            {
                Uri resourceUri = new Uri("/img/doctor-m.png", UriKind.Relative);
                profPic.Source = new BitmapImage(resourceUri);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _id_logged_in = 555;
            new DoctorLogin()
            {
                Owner = Application.Current.MainWindow
            }.ShowDialog();
            this.Close();
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            this.Activate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new PatientsView(_id_logged_in)
            {

            }.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new UMeds(_id_logged_in)
            {

            }.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new AppointmView(_id_logged_in)
            {

            }.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            new AllergensList(_id_logged_in)
            {

            }.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            new AMeds(_id_logged_in)
            {

            }.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            new DoctorsView(_id_logged_in)
            {

            }.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new ReqTimeOff(_id_logged_in)
            {

            }.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            new AnamnesisView(_id_logged_in)
            {

            }.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
            Doctor doctor = _doctorController.ReadDoctor(_id_logged_in);
            new EditDoctor(_id_logged_in)
            {

            }.Show();
        }
    }
}
