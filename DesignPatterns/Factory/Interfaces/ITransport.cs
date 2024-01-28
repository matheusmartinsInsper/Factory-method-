using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Interfaces
{
    internal interface ITransport
    {
        public DateTime CreateDate { get; protected set; }
        public double Velocidade { get; set; }
        public void SpeedUp(double acrescimoVelocidade);
        public void Brake(double decrescimoVelocidade);
    }
}
