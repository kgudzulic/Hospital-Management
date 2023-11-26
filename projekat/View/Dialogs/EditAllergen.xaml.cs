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
    /// Interaction logic for EditAllergen.xaml
    /// </summary>
    public partial class EditAllergen : Window
    {
        private AllergenController _allergenController;

        public uint _idD;
        public uint _idA;

        public EditAllergen(uint idDoc, uint idAl)
        {
            _idD = idDoc;
            _idA = idAl;
            InitializeComponent();
            var app = Application.Current as App;
            _allergenController = app.AllergenController;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Allergen alg = _allergenController.GetAllergen(_idA);

            if (tb2.Text.Length == 0)
            {
                errormessage.Text = "All fields must be filled.";
                tb2.Focus();
            }
            else if (!Regex.IsMatch(tb2.Text, @"^[A-Z][a-z]*$"))
            {
                errormessage.Text = "Enter a valid allergen name.";
                tb2.Select(0, tb2.Text.Length);
                tb2.Focus();
            }
            else
            {
                Allergen allergen = new Allergen(alg.Id, tb2.Text);
                _allergenController.UpdateAllergen(allergen);

                AllergensList ae2 = new AllergensList(_idD);
                ae2.Show();
                this.Close();
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _allergenController = app.AllergenController;
            Allergen alg = _allergenController.GetAllergen(_idA);

            tb2.Text = alg.Name;
            tb1.Text = alg.Id.ToString();
        }
    }
}
