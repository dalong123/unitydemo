using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.ServiceLocation;


using Microsoft.Practices.Unity;

namespace IOc
{
    class Program
    {
        static void Main(string[] args)
        {

            //StartApplogin<User> start = new StartApplogin<User>();
            //var result= start.GetTypeService<User>().login();
            //start.GetTypeService2();
            //Console.WriteLine("User service "+result);

            //start.login();
            //Console.WriteLine("StartApplogin service " + result);

            // StartupApp app = new StartupApp();

            UnityTwo unity = new UnityTwo();

            unity.firstcall();

            unity.secondcall();

            unity.thirdcall();

            unity.fourth();
          //  unity.thirdcall();
            Console.ReadLine();

        }
    }
}
