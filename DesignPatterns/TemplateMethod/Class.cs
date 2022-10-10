using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public abstract class Class : IClass
    {
        public string TemplateMethod(string text)
        {
            string result = text;
            result = EncodeNumbers(result);
            result = EncodeWords(result);
            return result;
        }


        protected abstract string EncodeWords(string text);

        protected abstract string EncodeNumbers(string text);
    }
}
