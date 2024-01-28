using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.ConcreteProducts
{
    internal class Truck : ITransport
    {
        private double velocidade;
        private DateTime createDate;
        public DateTime CreateDate { get { return createDate; } set { createDate = value; } }
        public double Velocidade { get { return velocidade; } set { velocidade = value; } }
        public Truck()
        {
            CreateDate = DateTime.Now;
            Velocidade = 0;
        }
        public void SpeedUp(double acrescimoDeVelocidade)
        {
            velocidade += acrescimoDeVelocidade;
        }

        public void Brake(double decrescimoDeVelocidade)
        {
            if (Velocidade <= 0)
            {
                Velocidade -= decrescimoDeVelocidade * 0.5;
            }
            velocidade += decrescimoDeVelocidade;
        }
    }
}
