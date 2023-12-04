using csvGenerate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvGenerate.Interface
{
    internal interface IConcatModel
    {
        public Model concatModel(string filePath, List<string> file);
    }
}
