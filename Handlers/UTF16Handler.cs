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
            var bom = new byte[4];
            using (var file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            if (bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
            {
                return Encoding.UTF8;
            }
            else { return base.Handle(fileName); }


        }
    }
}
