using System.Collections.Generic;

namespace CurrencyExchanger
{
    public class HistoryService
    {
        private OperationRepository operationRepository;

        public HistoryService()
        {
            operationRepository = new OperationRepository();
        }

        public List<string> getHistoryList()
        {
            List<Operation> operationsList = operationRepository.ReadAll();
            List<string> result = new List<string>();
            foreach (Operation line in operationsList)
            {
                result.Add(line.Username + " | " +
                        "Operation:" +
                        line.Operations + " " +
                        line.Amount + "" +
                        line.Sign + " | " +
                        "Date:" + "  " +
                        line.Date);
            }
            return result;
        }

        public void addRecord(string username, string opCode, double amount, string sign)
        {
            Operation operation = new Operation(username, opCode, amount.ToString("0.000"), sign);
            operationRepository.Write(operation);
        }
    }
}
