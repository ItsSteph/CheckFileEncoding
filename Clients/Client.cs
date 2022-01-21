using check_your_encoding.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Clients
{
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var encodingType in new List<string> { "utf8.txt" })
            {
                Console.WriteLine($"Client: Who can handle {encodingType}?");

                var result = handler.Handle(encodingType);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {encodingType} was not found.");
                }
            }
        }
    }
}
