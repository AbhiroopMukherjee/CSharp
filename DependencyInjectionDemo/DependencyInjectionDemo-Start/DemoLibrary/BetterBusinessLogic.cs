using System;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {


            _logger.Log("BB: Starting the processing of data.");
            Console.WriteLine("BB: Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("BB: ProcessedInfo");
            _logger.Log("BB: Finished processing of the data.");
        }
    }
}
