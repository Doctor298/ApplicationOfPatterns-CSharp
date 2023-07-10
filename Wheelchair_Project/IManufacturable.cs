using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project
{
    public interface IManufacturable
    {
        public string ModelName { get; set; }

        public int Year { get; }

        public string SerialNumber { get; }

        public string BuildStatus { get; set; } 
    }
}
