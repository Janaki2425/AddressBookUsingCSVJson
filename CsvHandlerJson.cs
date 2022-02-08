using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyAccess
{
    internal class CsvHandlerJson
    {
        public static void ImplementJSON()
        {
            string importPath = @"C:\Users\91936\source\repos\ThirdPartyAccess\ThirdPartyAccess\Address.csv";
            string exportpath = @"C:\Users\91936\source\repos\ThirdPartyAccess\ThirdPartyAccess\ExportJSON.json";
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
                Console.WriteLine(("\n Now reading from csv file and write to Json file"));
                
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportpath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}

    


    

