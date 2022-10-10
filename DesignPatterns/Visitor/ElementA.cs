﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class ElementA : IElement
    {
        public float Price { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementA(this);
            
        }
    }
}
