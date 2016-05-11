using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOc
{
    public class User:IUser
    {

        public int Age { get; set; }

        public bool login()
        {

            Console.WriteLine("user login method");
            return true;
        }
    }
}
