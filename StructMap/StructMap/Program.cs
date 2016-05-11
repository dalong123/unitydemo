using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using WebDAVSharp.Server.Stores.DiskStore;
using WebDAVSharp.Server.Adapters;
using System.Threading;
using WebDAVSharp.Server;
using System.Security.Principal;
using System.Net;
using System.Security.Authentication.ExtendedProtection;

namespace StructMap
{
    class Program
    {
     

        public static void Main()
        {
            WebDavDiskStore  store=new WebDavDiskStore("C:\\");
         //   HttpListenerAdapter http = new HttpListenerAdapter();

            WebDAVSharp.Server.WebDavServer server = new WebDAVSharp.Server.WebDavServer(store);
            server.Listener.Prefixes.Add("http://10.2.132.19:8089/");
            server.Listener.Prefixes.Add("http://localhost:8089/");
            server.Listener.Prefixes.Add("http://127.0.0.1:8089/");
          //  server.Listener.AdaptedInstance.UnsafeConnectionNtlmAuthentication = false;
            server.Listener.AdaptedInstance.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
            //  server.Listener.AdaptedInstance.GetContext();
            //server.Listener.AdaptedInstance.UnsafeConnectionNtlmAuthentication = false;
            //server.Listener.AdaptedInstance.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
            server.Listener.AdaptedInstance.AuthenticationSchemeSelectorDelegate =
            new AuthenticationSchemeSelector(AuthenticationSchemeForClient);
 
        //    server.Listener.AdaptedInstance.ExtendedProtectionSelectorDelegate=new HttpListener.ExtendedProtectionSelector()
            server.Start();
            Console.ReadLine();

        }

        static AuthenticationSchemes AuthenticationSchemeForClient(HttpListenerRequest request)
        {
            Console.WriteLine("Client authentication protocol selection in progress...");
            // Do not authenticate local machine requests.
            if (request.RemoteEndPoint.Address.Equals(IPAddress.Loopback))
            {
                return AuthenticationSchemes.None;
            }
            else
            {
                return AuthenticationSchemes.IntegratedWindowsAuthentication;
            }
        }

    }
}
