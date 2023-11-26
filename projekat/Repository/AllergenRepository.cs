using projekat.Exception;
using projekat.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Repository
{
    public class AllergenRepository
    {
        private const string NOT_FOUND_ERROR = "Account with {0}:{1} can not be found!";
        private readonly string _path;
        private readonly string _delimeter;
        private readonly string _dateTimeFormat;
        private uint _allergenMaxId;
        private uint _allergenDTOMaxId;
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        private FileStream temp;

        private String fileName;

        public AllergenRepository(string path, string delimeter, string dateTimeFormat)
        {
            _path = path;
            _delimeter = delimeter;
            _dateTimeFormat = dateTimeFormat;
            _allergenMaxId = GetMaxId(GetAll());
        }

        private uint GetMaxId(IEnumerable<Allergen> allergens)
        {
            return allergens.Count() == 0 ? 0 : allergens.Max(allergen => allergen.Id);
        }

        public IEnumerable<Allergen> GetAll()
        {
            return File.ReadAllLines(_path)
                  .Select(ConvertCSVFormatToAllergen)
                  .ToList();
        }

        public Model.Allergen CreateNewAllergen(Model.Allergen allergen)
        {
            allergen.Id = ++_allergenMaxId;
            AppendLineToFile(_path, ConvertAllergenToCSVFormat(allergen));
            return allergen;
        }

        public Model.Allergen GetAllergen(uint id)
        {
            try
            {
                return GetAll().SingleOrDefault(allergen => allergen.Id == id);
            }
            catch (ArgumentException)
            {
                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "id", id));
            }
        }

        public Model.Allergen UpdateAllergen(Model.Allergen allergen)
        {
            string temp_file = _projectPath + "\\Resources\\tempALR.txt";
            string _file = _projectPath + "\\Resources\\allergen.txt";

            using (var sr = new StreamReader(_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string lineToWrite = ConvertAllergenToCSVFormat(allergen);
                    Allergen tempApp = ConvertCSVFormatToAllergen(line);
                    if (allergen.Id != tempApp.Id)
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
            return allergen;
        }

        public Boolean DeleteAllergen(uint id)
        {
            Boolean retVal = false;
            IEnumerable<Allergen> allergens = GetAll();

            allergens = allergens.Where(a => a.Id != id).ToList();

            string temp_file = _projectPath + "\\Resources\\tempAlr.txt";
            string allergen_file = _projectPath + "\\Resources\\allergen.txt";

            using (var sr = new StreamReader(allergen_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Allergen allergen = ConvertCSVFormatToAllergen(line);
                    if (allergen.Id != id)
                    {
                        retVal = true;
                        sw.WriteLine(line);
                    }
                }
            }
            File.Delete(allergen_file);
            File.Move(temp_file, allergen_file);
            return retVal;
        }

        private Allergen ConvertCSVFormatToAllergen(string allergenCSVFormat)
        {
            Allergen allergen = new Allergen();
            string[] tokens = allergenCSVFormat.Split(_delimeter.ToCharArray());

            uint Id = uint.Parse(tokens[0]);
            string Name = tokens[1];

            return new Allergen(
                Id,
                Name
            );
        }

        private string ConvertAllergenToCSVFormat(Allergen allergen)
        {
            return string.Join(_delimeter,
                allergen.Id,
                allergen.Name
            );
        }

        private void AppendLineToFile(string path, string line)
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }
    }
}
