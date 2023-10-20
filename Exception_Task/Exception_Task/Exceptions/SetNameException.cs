using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Task.Exceptions
{
    internal class SetNameException:Exception
    {
        public SetNameException(string message):base(message) 
        {
        }
    }
}
