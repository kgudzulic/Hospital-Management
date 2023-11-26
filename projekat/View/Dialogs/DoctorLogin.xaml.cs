using Model;
using projekat.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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


namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for SecretaryLogin.xaml
    /// </summary>
    public partial class DoctorLogin : Window
    {
        private string _username;
        private string _password;
        private DoctorController _doctorController;
        public uint _IdLoggedIn;
        public DoctorLogin()
        {
            InitializeComponent();
            DataContext = this;
            _IdLoggedIn = 555;
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
        }

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        void Execute(object parameter, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
            try
            {
                Doctor doctor = _doctorController.FindDoctorByUsername(Username);
                if (doctor == null)
                {
                    if (Username == null || Password == null)
                    {
                        errormessage.Text = "All fields must be filled";
                        //MessageBox.Show("All fields must be filled", "Error");
                    }
                    else if (Username.Length < 6)
                    {
                        errormessage.Text = "Username must be at least 6 characters long";
                        //MessageBox.Show("Username must be at least 6 characters long", "Username error");
                        bpb1.Focus();
                    }
                    else if (doctor == null)
                    {
                        errormessage.Text = "Username not found";
                        //MessageBox.Show("Username not found", "Username error");
                        bpb1.Focus();
                    }
                    else
                    {
                        errormessage.Text = "Invalid input";
                        //MessageBox.Show("Invalid input", "Error");
                    }
                }
                else if (Password.Length < 8)
                {
                    errormessage.Text = "Password must be at least 8 characters long";
                    //MessageBox.Show("Password must be at least 8 characters long", "Password length error");
                    bpb1.Focus();
                }
                else if (doctor.Password != Password)
                {
                    errormessage.Text = "Incorrect password";
                    //MessageBox.Show("Incorrect password", "Password error");
                    bpb1.Focus();
                }
                else
                {
                    _IdLoggedIn = doctor.Id;
                    new DoctorHomepage(_IdLoggedIn)
                    {
                        Owner = Application.Current.MainWindow
                    }
                    .ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                this.Close();
                throw;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void bpb1_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(bpb1.ContentStringFormat == "")
            {
                pass.Visibility = Visibility.Visible;
            }
            else if (bpb1.ContentStringFormat != "")
            {
                pass.Visibility = Visibility.Hidden;
            }
        }
    }
}


