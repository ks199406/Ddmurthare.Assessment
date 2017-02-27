using Ddmurthare.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddmurthare.Service.Concrete
{
    public class ComputeLogic : IComputeLogic
    {
        IValidationLogic validationLogic;
        public ComputeLogic()
        {
            this.validationLogic = new ValidationLogic();
        }
        public bool ComputeElement(string element, string symbol)
        {
            int firstIndex = 0;
            int secondindex = 0;
            bool isValid = true;
            if (!validationLogic.ValidateString(element))
            {
                isValid = false;
            }
            if (!validationLogic.ValidateString(symbol))
            {
                isValid = false;

            }
            if (!validationLogic.ValidateSymbolLength(symbol))
            {
                isValid = false;

            }
            if (!validationLogic.ValidateUpper(element[0]))
            {
                isValid = false;

            }
            if (!validationLogic.ValidateUpper(symbol[0]))
            {
                isValid = false;

            }
            if (!validationLogic.ValidateExist(symbol[0].ToString().ToUpper(), element.ToUpper()))
            {
                isValid = false;

            }
            if (!validationLogic.ValidateExist(symbol[1].ToString().ToUpper(), element.ToUpper()))
            {
                isValid = false;

            }
            firstIndex = validationLogic.GetWordIndex(symbol[0].ToString().ToUpper(), element.ToUpper());
            secondindex = validationLogic.GetWordIndex(symbol[1].ToString().ToUpper(), element.ToUpper());
            if (firstIndex > secondindex)
            {
                isValid = false;

            }
            return isValid;
        }

    }
}
