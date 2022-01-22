using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_your_encoding.Abstracts;

namespace check_your_encoding.Handlers
{
    public class UTF16Handler : AbstractHandler
    {
        public override Encoding? Handle(string fileName)
        {
            //creates an array of bytes.
            byte[] bom = new byte[4];

            //using filestream to open the specfied file
            using (Stream file = File.OpenRead(fileName))
            {
                //read the byte order mark (BOM)
                file.Read(bom);
            }
            //checks if bom is equal to the bom of the encoding
            if (bom[0] == 0xfe && bom[1] == 0xff )
            {
                Console.WriteLine("The document was encoded with UTF16(BE)/BigEndian");
                return Encoding.BigEndianUnicode; // returns UTF16(BE)
            }
            else {return base.Handle(fileName); }

        }
    }
}
