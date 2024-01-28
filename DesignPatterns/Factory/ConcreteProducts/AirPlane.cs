using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.ConcreteProducts
{
    internal class AirPlane : ITransport
    {
        private double velocidade;
        private DateTime createDate;
        public DateTime CreateDate { get { return createDate; } set { createDate = value; } }
        public double Velocidade { get { return velocidade; } set { velocidade = value; } }
        public AirPlane()
        {
            CreateDate = DateTime.Now;
            Velocidade = 0;
        }
        public void Brake(double decrescimoVelocidade)
        {
            if (Velocidade <= 0)
            {
                Velocidade += 0;
            }
            Velocidade -= decrescimoVelocidade * 0.9;
        }

        public void SpeedUp(double acrescimoVelocidade)
        {
            if (Velocidade >= 800)
            {
                Velocidade += acrescimoVelocidade * 0.1;
            }
            Velocidade += acrescimoVelocidade * 0.85;
        }
    }
}
