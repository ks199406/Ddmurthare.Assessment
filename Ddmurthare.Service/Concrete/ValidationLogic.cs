using Ddmurthare.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddmurthare.Service.Concrete
{
    public class ValidationLogic : IValidationLogic
    {
        public   bool ValidateString(string word)
        {
            if (string.IsNullOrEmpty(word.Trim()))
            {
                return false;
            }
            return true;
        }
        public   bool ValidateSymbolLength(string symbol)
        {
            if (symbol.Length != 2)
            {
                return false;
            }

            return true;
        }
        public   bool ValidateUpper(char word)
        {
            if (!Char.IsUpper(word))
            {
                return false;
            }

            return true;
        }
        public   bool ValidateExist(string word, string element)
        {
            if (!element.Contains(word))
            {
                return false;
            }

            return true;
        }
        public int GetWordIndex(string word, string element)
        {

            return element.IndexOf(word);
        }
    }
}
