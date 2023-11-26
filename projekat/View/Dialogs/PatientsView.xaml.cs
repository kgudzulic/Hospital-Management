using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using Controller;
using projekat.Controller;
using projekat.Model;
using Model;
using PdfSharp.Pdf;
using PdfSharp;
using System.Data;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using System.Drawing;

namespace projekat.View.Dialogs
{
    public partial class PatientsView : Window
    {
        private AppointmentController _appointmentController;
        private RoomController _roomController;
        private DoctorController _doctorController;
        private PatientController _patientControler;
        public ObservableCollection<Patient> Pat { get; set; }
        public ObservableCollection<Appointment> Data { get; set; }

        private uint _id_logged_in;

        public PatientsView(uint id)
        {
            _id_logged_in = id;
            InitializeComponent();
            var app = Application.Current as App;
            _patientControler = app.PatientController;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _patientControler = app.PatientController;
            var Pat = new ObservableCollection<Patient>(_patientControler.GetAll());
            Patients.ItemsSource = Pat;
            DataContext = this;
        }

        private void Patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGridXAML.Items.Clear();
            var item = (ListBox)sender;
            var pac = (Patient)item.SelectedItem;
            var dat = pac.DateOfBirth;
            tb1.Text = pac.Username;
            tb2.Text = pac.Name;
            tb3.Text = pac.Surname;
            tb4.Text = pac.Adress;
            tb5.Text = pac.Email;
            tb6.Text = dat.ToString("dd/MM/yyyy");

            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            _roomController = app.RoomController;
            _doctorController = app.DoctorController;
            _patientControler = app.PatientController;

            Data = new ObservableCollection<Appointment>(_appointmentController.GetAll().ToList());


            for (int i = 0; i < Data.Count(); i++)
            {
                Room room = _roomController.FindRoom(Data[i].IdRoom);
                Doctor doctor = _doctorController.ReadDoctor(Data[i].IdDoctor);
                Data[i].RoomName = room.Name;
                Data[i].DoctorName = doctor.Name;
                Data[i].DoctorSurname = doctor.Surname;

                if (Data[i].IdPatient == pac.Id)
                {
                    DataGridXAML.Items.Add(Data[i]);
                }
            }
            Appointment ap = DataGridXAML.SelectedItem as Appointment;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _id_logged_in = 555;
            new DoctorLogin()
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
            this.Close();
        }

        private void appoint_Click(object sender, RoutedEventArgs e)
        {
            new AppointmView(_id_logged_in)
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new DoctorHomepage(_id_logged_in)
            {
                Owner = Application.Current.MainWindow
            };
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            new AppointmView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            new ReqTimeOff(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            new PatientsView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            new UMeds(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            new AnamnesisView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            _id_logged_in = 555;
            new DoctorLogin()
            {
                Owner = Application.Current.MainWindow
            }.ShowDialog();
            this.Close();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //GeneratePDF();
        }

        /*public void GeneratePDF()
        {
            using (PdfDocument doc = new PdfDocument())
            {
                PdfPage page = doc.Pages.Add();
                PdfGraphics graphics = page.Graphic;
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
                PdfFont font1 = new PdfStandardFont(PdfFontFamily.Helvetica, 15);
                string naslov = "Patient's Medical Record";

                graphics.DrawString(naslov, font, PdfBrushes.Black, new PointF(200, 0));
                string textPDF = "Report abaout room occupation for 25/5/2022 - 25/6/2022 : ";
                graphics.DrawString(textPDF, font1, PdfBrushes.Black, new PointF(80, 75));
                PdfLightTable pdfLightTable = new PdfLightTable();
                DataTable table = new DataTable();

                table.Columns.Add("Room Name");
                table.Columns.Add("Period");
                table.Columns.Add("Doctor");

                table.Rows.Add(new string[] { "room 202", "10:00h", "Dr Nikolina" });
                table.Rows.Add(new string[] { "room 202", "10:30h", "Dr Sandra" });
                table.Rows.Add(new string[] { "room 202", "12:00h", "Dr Sava" });
                table.Rows.Add(new string[] { "room 303", "08:00h", "Dr Dunja" });
                table.Rows.Add(new string[] { "room 303", "08:30h", "Dr Nikolina" });
                table.Rows.Add(new string[] { "room 303", "09:15h", "Dr Maksim" });
                table.Rows.Add(new string[] { "room 404", "10:00h", "Dr Dunja" });
                table.Rows.Add(new string[] { "room 404", "10:30h", "Dr Olivera" });
                table.Rows.Add(new string[] { "room 404", "12:00h", "Dr Adrijana" });
                table.Rows.Add(new string[] { "room 505", "08:00h", "Dr Zoran" });
                table.Rows.Add(new string[] { "room 505", "08:30h", "Dr Svetlana" });
                table.Rows.Add(new string[] { "room 505", "08:45h", "Dr Andrej" });
                table.Rows.Add(new string[] { "room 606", "13:00h", "Dr Aleksandar" });
                table.Rows.Add(new string[] { "room 606", "14:30h", "Dr Marko" });
                table.Rows.Add(new string[] { "room 606", "15:00h", "Dr Ivan" });


                pdfLightTable.DataSource = table;
                pdfLightTable.Style.ShowHeader = true;
                pdfLightTable.Draw(page, new PointF(0, 100));

                doc.Save(@"img\report.pdf");

                doc.Close(true);
            }
        }*/
    }
}
