using System;
using Domain;
using Domain.Repositories;
using ClosedXML.Excel;
using System.IO;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace Infrastructure
{
    public class ExcelOutputInfrastructure : IDataOutput
    {

        private XLWorkbook myWorkbook;
        private readonly ILogger Logger;

        public ExcelOutputInfrastructure(ILogger logger)
        {
            Logger = logger;
        }

        public ExcelOutputInfrastructure():this(new LogFile()){}

        private void ExcelOpen()
        {
            string openPath =System.IO.Path.GetFullPath(Properties.Resources.SaveFolderPath+Properties.Resources.SaveFile);
            try
            {
                myWorkbook = new XLWorkbook();
                bool setInstance = true;
                FileStream fs = new FileStream(openPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                myWorkbook = new XLWorkbook(fs, XLEventTracking.Disabled);
                foreach(IXLWorksheet worksheet in myWorkbook.Worksheets)
                {
                    if(worksheet.Name=="test")
                    {
                        setInstance = false;
                    }
                }
                if (setInstance)
                {
                    myWorkbook.AddWorksheet("test");
                }
                myWorkbook.SaveAs(fs);
            }
            catch(InvalidCastException e)
            {
                Logger.Log(ILogger.LogInfomation.ERROR, e.Message);
            }
        }

        public void CashBoxDataOutput(Cashbox cashbox)
        {
            ExcelOpen();
        }
    }
}
