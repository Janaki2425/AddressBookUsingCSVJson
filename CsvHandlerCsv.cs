using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
//using System.Text.Json;
using System.Threading.Tasks;

namespace ThirdPartyAccess
{
    internal class CsvHandlerCsv
    {
        public static void ImplementCSVDataHandling()
        {
            string importPath = @"C:\Users\91936\source\repos\ThirdPartyAccess\ThirdPartyAccess\Address.csv";
            string exportpath = @"C:\Users\91936\source\repos\ThirdPartyAccess\ThirdPartyAccess\ExportCSV.csv";
            using var reader = new StreamReader(importPath);
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine(" Read data successfully from address.csv");
                foreach (AddressData addressData in records)
                {
                    Console.WriteLine(" " + addressData.firstname);
                    Console.WriteLine(" " + addressData.lastname);
                    Console.WriteLine(" " + addressData.address);
                    Console.WriteLine(" " + addressData.state);
                    Console.WriteLine(" " + addressData.city);
                    Console.WriteLine(" " + addressData.code);



                }
                Console.WriteLine(("\n Now reading from csv file and write to csv file"));
                using (var writer = new StreamWriter(exportpath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }

            }
        }
    }
}

    

