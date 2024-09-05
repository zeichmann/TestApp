using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using TestApp.Services.Abstraction;

namespace TestApp.Services
{
    public class CsvService : ICsvService
    {
        public DataTable ParseCsvData(string filePath)
        {
            var result = new DataTable();
            result.Columns.Add("Firstname");
            result.Columns.Add("Surname");
            result.Columns.Add("Nick");

            //Using StreamReader instead of File.ReadLines to avoid memory problems in case of big csv files

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    
                    result.Rows.Add(fields);
                }
            }
            
            return result;
        }
    }
}
