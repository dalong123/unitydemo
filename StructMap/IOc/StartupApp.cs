using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace IOc
{
    public  class StartupApp
    {

        public UnityContainer myContainer = new UnityContainer();



        User userinfo =null;
        public StartupApp()
        {


            userinfo = new User() {

                Age = 33
            };
            
            myContainer.RegisterType<IUser, User>();
            myContainer.RegisterInstance<IUser>("userinfo", userinfo);
 

        }

        public void RegistType()
        {
        }

        


    }
}
