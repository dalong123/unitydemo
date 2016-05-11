using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOc
{
    public class UnityTwo
    {
        IUnityContainer container;
        public UnityTwo()
        {
            container = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(container);
            section.Configure(container, "third");
        }
        public void fourth()
        {
          var result= container.Resolve<dalong.IUser>();
          Console.WriteLine("fouth");
          result.loginApp();
        }
        public  void firstcall()
        {
            var user=  container.Resolve<User>("StandarUser");
            Console.WriteLine("first with name");
            user.login();
        }

        public void secondcall()
        {
            var user = container.Resolve<User>();
            Console.WriteLine("second  without name");
            user.login();
        }
        public void thirdcall()
        {
            var user = container.Resolve<UserTwo>();
            Console.WriteLine("thirdcall  without name");
            user.login();
        }
    }
}
