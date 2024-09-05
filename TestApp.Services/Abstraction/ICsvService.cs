using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TestApp.Services.Abstraction
{
    public interface ICsvService
    {
        DataTable ParseCsvData(string filePath);
    }
}
