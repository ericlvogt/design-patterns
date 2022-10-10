using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class VariableExpression : IExpression
    {
        private string _name;

        public VariableExpression(string name)
        {
            _name = name;
        }

        public bool Interpret(IContext context)
        {
            return context.GetVariableValue(_name);
        }
    }
}
