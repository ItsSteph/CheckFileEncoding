using check_your_encoding.Abstracts;
using System.Text;

namespace check_your_encoding.Handlers
{
    public class UnicodeHandler : AbstractHandler
    {
        public override Encoding? Handle(string fileName)
        {
            byte[] bom = new byte[4];
            using (Stream file = File.OpenRead(fileName))
            {
                file.Read(bom);
            }
            //checks if bom is equal to the bom of the encoding
            if (bom[0] == 0xff && bom[1] == 0xfe)
            {
                Console.WriteLine("The document is encoded with UTF16(LE)/LittleEndian");
                return Encoding.Unicode;
            }
            else
            {
                Console.WriteLine("Document is not encoded with UTF-16 / Unicode.");
                Console.WriteLine("Please try using another method");
                return base.Handle(fileName);
            }
        }
    }
}
