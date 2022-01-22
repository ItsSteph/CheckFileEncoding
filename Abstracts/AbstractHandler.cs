using check_your_encoding.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_your_encoding.Abstracts
{
    public abstract class AbstractHandler : IHandler
    {
        public IHandler? _nextHandler;

        public virtual Encoding? Handle(string fileName)
        {
            if(this._nextHandler != null)
            {
                return this._nextHandler.Handle(fileName);
            }
            else
            {
                return null;
            }
        }
        public IHandler? SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
