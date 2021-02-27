using System;

namespace Actions
{
    public class StringHandler
    {
        Action<string> _enterHandler;
        event Action _printStrings;
        private string _currentString;
        private bool _requiresProcessing = true;
        
        private string CurrentString
        {
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    _requiresProcessing = false;
                }
                else
                {
                    _currentString = value;
                }
            }
        }
        public StringHandler()
        {
            _printStrings += AlphaNumericCollector.PrintList;
            _printStrings += StringCollector.PrintList;
        }
        public void SetString(string input)
        {
            CurrentString = input;
            if (_requiresProcessing)
            {
                ProcessString(_currentString);
            }
        }
        public void GetStrings()
        {
            Console.WriteLine("-------------------------");
            _printStrings?.Invoke();
            Console.WriteLine("-------------------------");
        }
        private void ProcessString(string str)
        {
            bool isHaveNumber = false;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] >= 48 && str[j] <= 57)
                {
                    isHaveNumber = true;
                    break;
                }
            }
            if (isHaveNumber)
                _enterHandler = AlphaNumericCollector.AddToList;
            else
                _enterHandler = StringCollector.AddToList;

            _enterHandler(str);
        }
       
    }
}
