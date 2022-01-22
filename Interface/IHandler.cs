using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Interface
{
    public interface IHandler
    {
        Encoding? Handle(string fileName);

        IHandler? SetNext (IHandler handler);        
    }
}
