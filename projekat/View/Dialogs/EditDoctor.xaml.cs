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
using Model;
using projekat.Model;
using Controller;
using projekat.Controller;
using System.Text.RegularExpressions;

namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for EditDoctor.xaml
    /// </summary>
    public partial class EditDoctor : Window
    {
        private DoctorController _doctorController;
        private uint _id;

        public EditDoctor(uint id)
        {
            _id = id;
            InitializeComponent();
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb21.Text.Length == 0 || tb31.Text.Length == 0 || tb41.Text.Length == 0 || tb51.Text.Length == 0 || tb61.Text.Length == 0)
            {
                errormessage.Text = "All fields must be filled.";

                if(tb21.Text.Length == 0)
                {
                    tb21.Focus();
                }
                else if (tb31.Text.Length == 0)
                {
                    tb31.Focus();
                }
                else if (tb41.Text.Length == 0)
                {
                    tb41.Focus();
                }
                else if (tb51.Text.Length == 0)
                {
                    tb51.Focus();
                }
                else if (tb61.Text.Length == 0)
                {
                    tb61.Focus();
                }
            }
            else if (!Regex.IsMatch(tb21.Text, @"^[A-Z][a-z]*$"))
            {
                errormessage.Text = "Enter a valid first name.";
                tb21.Select(0, tb21.Text.Length);
                tb21.Focus();
            }
            else if (!Regex.IsMatch(tb31.Text, @"^[A-Z][a-z]*$"))
            {
                errormessage.Text = "Enter a valid last name.";
                tb31.Select(0, tb31.Text.Length);
                tb31.Focus();
            }
            else if (!Regex.IsMatch(tb41.Text, @"^([A-Z][a-z]*)+\s+(([A-Z][a-z]*)+\s+)*?([0-9]*)$"))
            {
                errormessage.Text = "Enter a valid address.";
                tb41.Select(0, tb41.Text.Length);
                tb41.Focus();
            }
            else if (!Regex.IsMatch(tb51.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                tb51.Select(0, tb51.Text.Length);
                tb51.Focus();
            }
            /*else if (!Regex.IsMatch(tb61.Text, @"^[0-3][0-9][\w.][0-1][0-2][\w.][1-9]{4}$"))
            {
                errormessage.Text = "Enter a valid date of birth.";
                tb61.Select(0, tb61.Text.Length);
                tb61.Focus();
            }*/
            else
            {
                this.Close();
            }
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
            Doctor doctor = _doctorController.ReadDoctor(_id);

            var DAT = doctor.DateOfBirth;
            tb11.Text = doctor.Username;
            tb21.Text = doctor.Name;
            tb31.Text = doctor.Surname;
            tb41.Text = doctor.Adress;
            tb51.Text = doctor.Email;
            tb61.Text = DAT.ToString("dd/MM/yyyy");
            tb71.Text = doctor.Specialization.ToString();
        }
    }
}
