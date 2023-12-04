using csvGenerate.Models;
using csvGenerate.Service;
using System.Diagnostics;
using System.Globalization;
List<string> symb = new List<string>() { "Name", "Surname", "Lastname", "Sex", "Address", "DateRegistration", "Salary"};
string filePath = @"C:\Users\Данила\source\repos\csvGenerate\data";
List<string> path = new List<string> { "\\Name.txt", "\\Surname.txt", "\\Lastname.txt",
                                        "\\Sex.txt", "\\Address.txt", "\\Salary.txt" };
ConcatModel model = new ConcatModel(new ReadData(new GetData()));
var result = model.concatModel(filePath, path);
new Generator(result).Generate(symb);

Console.WriteLine("complete");

