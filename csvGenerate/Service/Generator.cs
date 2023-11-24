using csvGenerate.Interface;
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
    internal class Generator : IGenerate, ICheck, INormalize
    {
        private readonly Random rnd = new Random();
        private string[] words;
        public Generator(List<string> param)
        {
            words = Enumerable.Range(0, rnd.Next(0, 10000))
                    .Select(x =>
                    {
                        int i = 0;
                        var str = "";
                        while (i != param.Count)
                        {
                            if (Check(i, param.Count) && param[i] == "int")
                            {
                                var range = Enumerable.Range(0, rnd.Next(2, 5));
                                var chars = range.Select(x => (char)rnd.Next('0', '9')).ToArray();
                                str += new string(chars) + ",";
                                Normalize(ref str);
                                i++;
                            }
                            if (Check(i, param.Count) && param[i] == "date")
                            {
                                DateTime start = new DateTime(1990, 1, 1);
                                int range = (DateTime.Today - start).Days;
                                str += DateOnly.FromDateTime(start.AddDays(rnd.Next(range))) + ",";
                                i++;
                            }
                            if (Check(i, param.Count) && param[i] == "string")
                            {
                                var range = Enumerable.Range(0, rnd.Next(0, 10));
                                var chars = range.Select(x => (char)rnd.Next('A', 'Z')).ToArray();
                                str += new string(chars) + ",";
                                i++;
                            }
                        }
                        return str.Remove(str.Length-1);
                    }).ToArray();
        }
        public void Generate(List<string> param)
        {
            words.ToList().Sort();
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
        public bool Check(int item, int count)
        {
            return item < count;
        }

        public void Normalize(ref string number)
        {
            while (number[0] == '0')
            {
                number = number.Remove(0, 1);

            }
        }
    }
}
