using csvGenerate.Service;
using System.Globalization;

List<string> symb = new List<string>() { "int", "string", "date", "string", "string" };
new Generator(symb).Generate(symb);
Console.WriteLine("...");