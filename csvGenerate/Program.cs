using csvGenerate.Service;
using System.Globalization;

List<string> symb = new List<string>() { "int", "string", "date", "string" };
new Generator(symb).Generate();
Console.WriteLine("...");