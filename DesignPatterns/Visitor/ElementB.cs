using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class ElementB : IElement
    {
        private int _quantity;
        private int _pricePerUnit;

        public ElementB(int quantity, int pricePerUnit)
        {
            _quantity = quantity;
            _pricePerUnit = pricePerUnit;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public int GetPrice()
        {
            return _quantity * _pricePerUnit;
        }
    }
}
