using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Interpreter;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatternsTest
{
    [TestClass]
    public class InterpreterTest
    {
        [TestMethod]
        public void TestInterpreter()
        {
            Context context = new();

            context.AssignVariable("true", true);
            context.AssignVariable("false", false);

            IExpression falseExpression = new AndExpression(new VariableExpression("true"), new VariableExpression("false"));
            IExpression trueExpression =  new AndExpression(new AndExpression(new VariableExpression("true"), new VariableExpression("true")), 
                                                            new VariableExpression("true"));

            Assert.IsTrue(trueExpression.Interpret(context));
            Assert.IsFalse(falseExpression.Interpret(context));
        }
    }
}