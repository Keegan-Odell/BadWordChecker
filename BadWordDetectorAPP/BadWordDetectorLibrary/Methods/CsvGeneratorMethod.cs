using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BadWordDetectorLibrary.Models;

namespace BadWordDetectorLibrary.Methods
{
    public static class CsvGeneratorMethod
    {
        public static void CsvGenerator<T>(this List<T> list)
        {
            string filePath = @"C:\Users\odellkc\OneDrive - Daikin Applied Americas\Documents\TimCoreyC#\TestTXTExport\List.txt";

            string csv = "";
            Type modelType = list[0].GetType();
            PropertyInfo[] properties =
                modelType.GetProperties();

            foreach (PropertyInfo props in properties)
            {
                csv += $",{props.Name}";
            }
            csv = csv.Substring(1);
            csv += "\n";

            foreach (var thing in list)
            {

                Type type = thing.GetType();
                PropertyInfo[] props = type.GetProperties();

                string csvSub = "";
                foreach (PropertyInfo prop in props)
                {
                    object value = prop.GetValue(thing);
                    csvSub += $",{value}";
                }

                csvSub = csvSub.Substring(1);
                csv += csvSub;
                csv += "\n";
            }

            File.WriteAllText(filePath, csv);
        }
    }
}


