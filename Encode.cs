using System.Text;

namespace check_your_encoding
{
    public class Encode
    {
        public static Encoding GetEncodingType()
        {
            return Encoding.ASCII;
        }



        public static Encoding GetASCII(string fileName)
        {
            var bom = new byte[4];
            using (var file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

                return Encoding.ASCII;
            
                
        }

        public static Encoding GetUTF8(string fileName)
        {
            var bom = new byte[4];
            using (var file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }


            return Encoding.UTF8;
        }
    }
}