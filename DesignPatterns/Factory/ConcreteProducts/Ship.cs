using DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.ConcreteProducts
{
    internal class Ship : ITransport
    {
        private double velocidade;
        private DateTime createDate;
        public DateTime CreateDate { get { return createDate; } set { createDate = value; } }
        public double Velocidade { get { return velocidade; } set { velocidade = value; } }
        public Ship()
        {
            CreateDate = DateTime.Now;
            Velocidade = 0;
        }
        public void Brake(double decrescimoVelocidade)
        {
            if (Velocidade <= 0)
            {
                Velocidade -= decrescimoVelocidade * 0.5;
            }
            Velocidade -= decrescimoVelocidade * 0.8;
        }

        public void SpeedUp(double acrescimoVelocidade)
        {
            if (Velocidade > 120)
            {
                Velocidade = Velocidade;
            }
            else if (Velocidade > 100 && Velocidade < 120)
            {
                Velocidade += acrescimoVelocidade * 0.3;
            }
            Velocidade += acrescimoVelocidade * 0.8;
        }
    }
}
