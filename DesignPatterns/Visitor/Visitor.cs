using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class Visitor : IVisitor
    {
        public float TotalPrice { get; private set; }

        public void VisitElementA(ElementA element)
        {
            TotalPrice += element.Price;
        }

        public void VisitElementB(ElementB element)
        {
            TotalPrice += (float)element.GetPrice();
        }
    }
}
