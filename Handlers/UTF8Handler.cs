using check_your_encoding.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Handlers
{
    public class UTF8Handler : AbstractHandler
    {
        public override Encoding? Handle(string fileName)
        {
            byte[] bom = new byte[4];
            using (Stream file = File.OpenRead(fileName))
            {
                file.Read(bom);
            }
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf)
            {
                Console.WriteLine("The document was encoded with UTF8");
                
                return Encoding.UTF8;
            }
            else
            {
                Console.WriteLine("Document is not encoded with UTF-8.");
                Console.WriteLine("Please try another.");
                return base.Handle(fileName); 
            }
        }
    }
}
