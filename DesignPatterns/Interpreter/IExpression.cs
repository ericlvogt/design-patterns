using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public interface IExpression
    {
        public bool Interpret(IContext context);
    }
}
