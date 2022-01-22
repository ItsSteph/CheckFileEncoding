using check_your_encoding.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Handlers
{
    public class DefaultHandler : AbstractHandler
    {
        public override Encoding? Handle(string fileName)
        {

            Console.WriteLine("Oops, I cannot determine the encoding or the encoding is not included in my methods at the moment");
            Console.WriteLine("Please excuse me");
            return null;
        }
    }
}
