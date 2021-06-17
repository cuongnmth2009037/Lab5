using System;

namespace Lab5.Exercise2
{
    public class AmountException : Exception
    {
        private string _personName;
        private string _message;

        public AmountException()
        {
        }

        public AmountException(string message, string personName)
        {
            this._message = message;
            this._personName = personName;
            PrintError();
            
        }

        public AmountException(string message)
        {
            throw new NotImplementedException();
        }

        private void PrintError()
        {
            Console.WriteLine($"Amount exception with person {_message}, {_personName}");
        }
    }
}