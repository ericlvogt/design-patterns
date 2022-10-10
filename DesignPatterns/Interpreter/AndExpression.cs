using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class AndExpression : IExpression
    {
        private IExpression _operand1;
        private IExpression _operand2;

        //Non Terminal
        public AndExpression(IExpression operand1, IExpression operand2)
        {
            _operand1 = operand1;
            _operand2 = operand2;
        }

        public bool Interpret(IContext context)
        {
            return _operand1.Interpret(context) && _operand2.Interpret(context);
        }
    }
}
