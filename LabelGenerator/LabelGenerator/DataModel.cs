using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelGenerator
{
    public class DataModel
    {
        public string CompanyName { get; set; }

        public string ProductName { get; set; }

        public string DisplayDateTime { get; set; }

        public List<string> SerialNumbers { get; set; }
    }
}
