using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TopShelfCWS
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(host =>
            {
                host.SetServiceName("MyCustomerService");
                host.SetDisplayName("My Customer Service");
                host.SetDescription("This is my custom service.");
                host.StartAutomatically();

                host.Service<NameMeAnything>();
            });
        }
    }
}
