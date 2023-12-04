using csvGenerate.Interface;
using csvGenerate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csvGenerate.Service
{
    internal class GetData : IGetData
    {
        public List<string>? getData(string filepath)
        {
            List<string> data = new List<string>();
            using (var sr = new StreamReader(filepath))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(sr.ReadLine());
                }
            }
            return data;
        }
    }
}
