using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class QuotationDecorator : Decorator
    {
        public QuotationDecorator(IComponent component) : base(component)
        {
        
        }

        public override string GetText()
        {
            return $"\"{base.GetText()}\"";
        }
    }
}
