using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    
    class InvalidInterestrateException :Exception
    {
        public InvalidInterestrateException() { }

        public InvalidInterestrateException(string message) : base(message) { }

    }
}
