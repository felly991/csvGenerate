using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvGenerate.Interface
{
    internal interface IGetData
    {
        public List<string>? getData(string filepath);
    }
}
