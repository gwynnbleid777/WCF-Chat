using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;





namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            
            Console.Title = "CLIENT";
            Uri address = new Uri ("http://localhost:4000/IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(address);

            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding,endpoint);

            IContract channel = factory.CreateChannel();
                                   
            Console.WriteLine ("Enter a message u wanna sent");

            //string input = Console.ReadLine();

            //string response = channel.Say(input);
            //Console.WriteLine(response);
            //Console.ReadKey();

            while (true)
            {
                string input = Console.ReadLine();
                string response = channel.Say(input);
                Console.WriteLine(response);
                
                //ConsoleKeyInfo key = Console.ReadKey();
                //if (key.Key == ConsoleKey.F1)
                //Environment.Exit(0);
                //ConsoleKeyInfo key = Console.ReadKey();
                //if (key.Key == ConsoleKey.Escape)
                //{
                //    string input = Console.ReadLine();

                //    string response = channel.Say(input);
                //    Console.WriteLine(response);
                //}

            }

            
        }
    }
}
