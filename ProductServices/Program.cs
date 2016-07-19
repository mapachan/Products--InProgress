using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ProductServices
{
    public class Program
    {
        static void Main (string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ProductService)))
            {
                host.Open();
                Console.WriteLine("Server is Open");
                Console.WriteLine("Press enter to Exit");
                Console.ReadLine();
            }

        }
    }
}