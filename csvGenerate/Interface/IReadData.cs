using csvGenerate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvGenerate.Interface
{
    internal interface IReadData
    {
        public NameModel readName(string filepath);
        public SurnameModel readSurname(string filepath);
        public LastNameModel readLastname(string filepath);
        public SexModel readSex(string filepath);
        public AddressModel readAddress(string filepath);
        public SalaryModel readSalary(string filepath);
    }
}
