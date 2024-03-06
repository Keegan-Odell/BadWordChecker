using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadWordDetectorLibrary.Models
{
    public class CarModel(string manufacturer, string model)
    {
        public event EventHandler<string> BadWord; 

        public string Manufacturer { get; set; } = manufacturer;
        public string Model { get; set; } = model;
    }
}
