using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc2
{
    public class User : IUser
    {
        public bool login()
        {
            Console.WriteLine("call Ioc2");
            return false;
        }
    }
}
