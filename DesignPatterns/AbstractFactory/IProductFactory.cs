using System;

namespace DesignPatterns.AbstractFactory
{
    public interface IProductFactory
    {
        public abstract IProduct CreateProduct();
    }
}
