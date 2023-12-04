using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvGenerate.Models
{
    internal class Model
    {
        public NameModel NameModels { get; set; }
        public SurnameModel SurnameModels { get; set; }
        public LastNameModel LastNameModels { get; set; }
        public SexModel SexModels { get; set; }
        public AddressModel AddressModels { get; set; }
        public SalaryModel SalaryModels { get; set; }

        
    }
}
