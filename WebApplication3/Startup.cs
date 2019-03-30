using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly:OwinStartup(typeof(WebApplication3.Startup))]
namespace WebApplication3
{
    public class Startup
    {
        public Startup()
        {
            Console.WriteLine("Start up called!!");
        }
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}