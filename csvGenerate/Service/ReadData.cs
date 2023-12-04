using csvGenerate.Interface;
using csvGenerate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvGenerate.Service
{
    internal class ReadData : IReadData
    {
        private readonly IGetData _getData;
        public ReadData(GetData getData)
        {
            _getData = getData;
        }

        public AddressModel readAddress(string filePath)
        {
            AddressModel model = new AddressModel();
            model.Address = _getData.getData(filePath);
            return model;
        }

        public NameModel readName(string filepath)
        {
            NameModel model = new NameModel();
            model.Name = _getData.getData(filepath);
            return model;
        }

        public LastNameModel readLastname(string filepath)
        {
            LastNameModel model = new LastNameModel();
            model.Lastname = _getData.getData(filepath);
            return model;
        }

        public SalaryModel readSalary(string filepath)
        {
            SalaryModel model = new SalaryModel();
            model.Salary = _getData.getData(filepath);
            return model;
        }

        public SexModel readSex(string filepath)
        {
            SexModel model = new SexModel();
            model.Sex = _getData.getData(filepath);
            return model;
        }

        public SurnameModel readSurname(string filepath)
        {
            SurnameModel model = new SurnameModel();
            model.Surname = _getData.getData(filepath);
            return model;
        }

    }
}
