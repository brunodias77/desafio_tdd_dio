using System.Collections.Generic;

namespace Calculator
{
    public class Calculator
    {
        private List<string> historyList;
        private string date;

        public Calculator(string date)
        {
            historyList = new List<string>();
            this.date = date;
        }

        public int Add(int value1, int value2)
        {
            int result = value1 + value2;
            historyList.Insert(0, "Result: " + result + " Date: " + date);
            return result;
        }
        
        public int Subtract(int value1, int value2)
        {
            int result = value1 - value2;
            historyList.Insert(0, "Result: " + result + " Date: " + date);
            return result;
        }

        public int Multiply(int value1, int value2)
        {
            int result = value1 * value2;
            historyList.Insert(0, "Result: " + result + " Date: " + date);
            return result;
        }

        public int Divide(int value1, int value2)
        {
            int result = value1 / value2;
            historyList.Insert(0, "Result: " + result + " Date: " + date);
            return result;
        }

        public List<string> History()
        {
            historyList.RemoveRange(3, historyList.Count - 3);
            return historyList;
        } 
    }
}
