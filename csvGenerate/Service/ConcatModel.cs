using csvGenerate.Interface;
using csvGenerate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvGenerate.Service
{
    internal class ConcatModel : IConcatModel
    {
        private readonly IReadData _readData;
        public ConcatModel(ReadData readData)
        {
            _readData = readData;
        }
        public Model concatModel(string filePath, List<string> file)
        {
            Model model = new Model();
            //    Type type = typeof(Model);
            //    int i = 0;
            //    foreach (var item in type.GetProperties())
            //    {

            //    }
            model.NameModels = _readData.readName(filePath + file[0]);
            model.SurnameModels = _readData.readSurname(filePath + file[1]);
            model.LastNameModels = _readData.readLastname(filePath + file[2]);
            model.SexModels = _readData.readSex(filePath + file[3]);
            model.AddressModels = _readData.readAddress(filePath + file[4]);
            model.SalaryModels = _readData.readSalary(filePath + file[5]);

            return model;
        }
        
    }
}
