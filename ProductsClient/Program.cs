using ProductServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProductsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductEntity xweb = new ProductEntity();

            foreach( var px in xweb.ToString().ToList())
            {
                Console.WriteLine(px);
            }

            //ProductEntity xweb = new ProductEntity();
            //Console.WriteLine("Accessing Database");

            //foreach (var px in xweb.ToString().ToList())
            //{
            //    Console.WriteLine(px);
            //}
            Console.WriteLine("List Complete");
            Console.ReadLine();

        }
        
    }
}
