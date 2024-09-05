using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestApp.Services;
using TestApp.Services.Abstraction;
using Unity;

namespace TestApp
{
    public partial class CsvParsing : Page
    {
        //should be replaced by DI
        public ICsvService csvService = new CsvService();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = csvService.ParseCsvData(Server.MapPath("~/Content/test.csv"));

            // Bind the DataTable to the GridView
            CsvData.DataSource = dataTable;
            CsvData.DataBind();
        }
    }
}