using check_your_encoding.Handlers;
using check_your_encoding.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Factories
{
    public class Factory
    {
        public static IHandler Unicode = new UnicodeHandler();
        public static IHandler UTF8 = new UTF8Handler();
        public static IHandler BigEndian = new UTF16Handler();
        public static IHandler Default = new DefaultHandler();

        public static IHandler EncodingChain
        {
            get
            {
                var chain = UTF8;
                chain.SetNext(BigEndian)?.SetNext(Unicode)?.SetNext(Default);
                return chain;
            }
        }
    }
}
