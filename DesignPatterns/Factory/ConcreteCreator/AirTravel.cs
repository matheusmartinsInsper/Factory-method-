using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.ConcreteProducts;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.ConcreteCreator
{
    internal class AirTravel : ITravell
    {
        public ITransport FactoryMethod()
        {
            return new AirPlane();
        }
    }
}
