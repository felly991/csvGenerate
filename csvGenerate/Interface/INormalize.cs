using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvGenerate.Interface
{
    internal interface INormalize
    {
        public void Normalize(ref string number);
    }
}
