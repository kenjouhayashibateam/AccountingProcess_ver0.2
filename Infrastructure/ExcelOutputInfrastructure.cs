using System;
using Domain;
using Domain.Repositories;
using ClosedXML.Excel;

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
            try
            {
                string openPath =System.IO.Path.GetFullPath(Properties.Resources.SavePath);
                myWorkbook = new XLWorkbook(openPath);
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
