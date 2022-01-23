using check_your_encoding.Abstracts;
using check_your_encoding.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Clients
{
    public class Client
    {
        protected static void ClientCode(IHandler handler, string fileName)
        {
            var result = handler.Handle(fileName);

            if (result == null){
                Console.WriteLine($"The encoding of {fileName} was not found.");
            }
            else{
                Console.Write($"   {result}");
            }
        }
    }
}
