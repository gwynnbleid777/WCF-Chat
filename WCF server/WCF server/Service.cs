using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_server
{
    class Service : IContract
    {
        public string Say(string phrase)
        {
            Console.WriteLine("Message received with information - {0}", phrase);
            return "Message received!!";
        }
    }
}
