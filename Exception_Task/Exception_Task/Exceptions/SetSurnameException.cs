using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Task.Exceptions
{
    internal class SetSurnameException:Exception
    {
        public SetSurnameException(string message) : base(message) 
        {
        }
    }
}
