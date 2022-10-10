using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class ConcreteClass : Class
    {
        protected override string EncodeNumbers(string text)
        {
            string result = string.Empty;
            int zeros = 0;

            if (!text.Contains('0'))
                return text;

            foreach (char c in text)
            {
                if (c == '0')
                    zeros++;
                else
                {
                    if (zeros > 0)
                    {
                        result += $"~0*{zeros.ToString()}";
                        zeros = 0; 
                    }
                    result += c;
                }
            }

            if (zeros > 0)
            {
                result += $"~0*{zeros.ToString()}";
            }

            return result;
        }

        protected override string EncodeWords(string text)
        {
            return text.Replace("with", "\\w");
        }
    }
}
