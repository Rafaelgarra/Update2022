using System;
using System.Collections.Generic;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyException :ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
