using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        public void VisitElementA(ElementA element);
        public void VisitElementB(ElementB element);
    }
}
