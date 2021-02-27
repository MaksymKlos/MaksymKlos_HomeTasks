namespace Delegate
{
    public class StringHandler
    {
        delegate void EnterHandler(string input);
        delegate void PrintStrings();

        private string _currentString;
        private bool _requiresProcessing = true;
        private EnterHandler _enterHandler;
        private PrintStrings _printStrings;
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
        public void SetString(string input)
        {
            CurrentString = input;
            if (_requiresProcessing)
            {
                ProcessString(_currentString);
            }
            else
            {
                _requiresProcessing = true;
            }
        }
        public void GetStrings(char input)
        {
            if (input == '1')
                _printStrings = AlphaNumericCollector.PrintList;
            else
                _printStrings = StringCollector.PrintList;
            _printStrings();
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
