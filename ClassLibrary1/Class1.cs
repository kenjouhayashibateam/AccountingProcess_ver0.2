using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace ClassLibrary1
{
    public class Class1
    {
         public string ReturnText()
        {
            Application app = new Application
            {
                Visible = true
            };
            string path = System.IO.Path.GetFullPath(".\\files\\AccountingProcessFile.xlsx");
            Workbooks wbs=app.Workbooks;
            Workbook wb = wbs.Open(path,,true);

            return "ok!";
        }
    }
}
