using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using projekat.Model;
using projekat.Exception;

namespace projekat.Repository
{
    public class MedicineRepository
    {
        private const string NOT_FOUND_ERROR = "Account with {0}:{1} can not be found!";
        private readonly string _path;
        private readonly string _delimeter;
        private readonly string _dateTimeFormat;
        private uint _medicineMaxId;
        private uint _medicineDTOMaxId;
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        private FileStream temp;

        private String fileName;

        public MedicineRepository(string path, string delimeter, string dateTimeFormat)
        {
            _path = path;
            _delimeter = delimeter;
            _dateTimeFormat = dateTimeFormat;
            _medicineMaxId = GetMaxId(GetAll());
        }

        private uint GetMaxId(IEnumerable<Medicine> medicine)
        {
            return medicine.Count() == 0 ? 0 : medicine.Max(allergen => allergen.Id);
        }

        public IEnumerable<Medicine> GetAll()
        {
            return File.ReadAllLines(_path)
                  .Select(ConvertCSVFormatToMedicine)
                  .ToList();
        }

        public Model.Medicine CreateNewMedicine(Model.Medicine medicine)
        {
            medicine.Id = ++_medicineMaxId;
            AppendLineToFile(_path, ConvertMedicineToCSVFormat(medicine));
            return medicine;
        }

        public Model.Medicine GetMedicine(uint id)
        {
            try
            {
                return GetAll().SingleOrDefault(medicine => medicine.Id == id);
            }
            catch (ArgumentException)
            {
                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "id", id));
            }
        }

        public Model.Medicine UpdateMedicine(Model.Medicine medicine)
        {
            string temp_file = _projectPath + "\\Resources\\tempALR.txt";
            string _file = _projectPath + "\\Resources\\medications.txt";

            using (var sr = new StreamReader(_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string lineToWrite = ConvertMedicineToCSVFormat(medicine);
                    Medicine tempApp = ConvertCSVFormatToMedicine(line);
                    if (medicine.Id != tempApp.Id)
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
            return medicine;
        }

        public Boolean DeleteMedicine(uint id)
        {
            Boolean retVal = false;
            IEnumerable<Medicine> medicine = GetAll();

            medicine = medicine.Where(a => a.Id != id).ToList();

            string temp_file = _projectPath + "\\Resources\\tempAlr.txt";
            string medicine_file = _projectPath + "\\Resources\\mediactions.txt";

            using (var sr = new StreamReader(medicine_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Medicine medicines = ConvertCSVFormatToMedicine(line);
                    if (medicines.Id != id)
                    {
                        retVal = true;
                        sw.WriteLine(line);
                    }
                }
            }
            File.Delete(medicine_file);
            File.Move(temp_file, medicine_file);
            return retVal;
        }

        private Medicine ConvertCSVFormatToMedicine(string medicineCSVFormat)
        {
            Medicine medicine = new Medicine();
            string[] tokens = medicineCSVFormat.Split(_delimeter.ToCharArray());

            uint Id = uint.Parse(tokens[0]);
            string Name = tokens[1];
            string Ingredients = tokens[2];
            uint AllergenId = uint.Parse(tokens[3]);
            bool IsApproved = bool.Parse(tokens[4]);

            return new Medicine(
                Id,
                Name,
                Ingredients,
                AllergenId,
                IsApproved
            );
        }

        private string ConvertMedicineToCSVFormat(Medicine medicine)
        {
            return string.Join(_delimeter,
                medicine.Id,
                medicine.Name,
                medicine.Ingredients,
                medicine.AllergenId,
                medicine.IsApproved
            );
        }

        private void AppendLineToFile(string path, string line)
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }
    }
}
