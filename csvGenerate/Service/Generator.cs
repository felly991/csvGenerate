using csvGenerate.Interface;
using csvGenerate.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace csvGenerate.Service
{
    internal class Generator : IGenerate
    {
        private readonly Random rnd = new Random();
        private string[] words;
        /// <summary>
        /// все что не в комментах - реальные данные
        /// </summary>
        /// <param name="model"></param>
        public Generator(Model model)
        {
            words = Enumerable.Range(0, rnd.Next(0, 1000000))
                .Select(x =>
                {
                    int nameInd = rnd.Next(model.NameModels.Name.Count);
                    int surnameInd = rnd.Next(model.SurnameModels.Surname.Count);
                    int lastnameInd = rnd.Next(model.LastNameModels.Lastname.Count);
                    int sexInd = rnd.Next(model.SexModels.Sex.Count);
                    int addressInd = rnd.Next(model.AddressModels.Address.Count);
                    int salaryInd = rnd.Next(model.SalaryModels.Salary.Count);

                    string name = model.NameModels.Name[nameInd];
                    string surname = model.SurnameModels.Surname[surnameInd];
                    string lastname = model.LastNameModels.Lastname[lastnameInd];
                    string sex = model.SexModels.Sex[sexInd];
                    string address = model.AddressModels.Address[addressInd];
                    string salary = model.SalaryModels.Salary[salaryInd];

                    DateTime start = new DateTime(2003, 1, 1);
                    int range = (DateTime.Today - start).Days;
                    string date = DateOnly.FromDateTime(start.AddDays(rnd.Next(range))).ToString();

                    string output = name + ";" + surname + ";" + lastname + ";" +
                           sex + ";" + address + ";" + date + ";" + salary;

                    return output;

                }).ToArray();
        }
        
        public void Generate(List<string> param)
        {
            using var writer = new StreamWriter("output.csv");
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteField(param);
            csv.NextRecord();
            for (int i = 0; i < words.Length; i++)
            {
                csv.WriteField(words[i]);
                csv.NextRecord();
            }
        }

    }
}
