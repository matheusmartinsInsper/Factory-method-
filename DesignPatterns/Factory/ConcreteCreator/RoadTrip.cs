using DesignPatterns.Factory.ConcreteProducts;
using DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.ConcreteCreator
{
    internal class RoadTrip : ITravell
    {
        public ITransport FactoryMethod()
        {
            return new Truck();
        }
    }
}
