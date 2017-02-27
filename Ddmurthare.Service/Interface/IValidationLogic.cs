using System;
namespace Ddmurthare.Service.Interface
{
   public  interface IValidationLogic
    {
         int GetWordIndex(string word, string element);
         bool ValidateExist(string word, string element);
         bool ValidateString(string word);
         bool ValidateSymbolLength(string symbol);
         bool ValidateUpper(char word);
    }
}
