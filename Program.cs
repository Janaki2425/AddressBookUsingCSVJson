using System;
namespace ThirdPartyAccess
{
    public class Program
    {
        static void Main(string[] args)
        {
            CsvHandlerCsv.ImplementCSVDataHandling();
            CsvHandlerJson.ImplementJSON();
        }
    }
}