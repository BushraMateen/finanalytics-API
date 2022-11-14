using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, string key)
            : base($"{name} ({key}) is not found")
        {

        }
    }
}
