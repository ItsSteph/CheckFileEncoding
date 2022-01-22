﻿using check_your_encoding.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Clients
{
    public class Client
    {
        public static void ClientCode(AbstractHandler handler, string fileName)
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