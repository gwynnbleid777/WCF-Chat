using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCF_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            Uri address = new Uri("http://localhost:4000/IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            Type contract = typeof(IContract);

            ServiceHost host = new ServiceHost(typeof(Service));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("App is redy to receive a message");

            Console.ReadKey();
            host.Close();
           
            

            
        }
    }
}
