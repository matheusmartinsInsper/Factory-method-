using DesignPatterns.Factory;
using DesignPatterns.Factory.ConcreteCreator;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns
{
    internal class Program
    {
        
        public static ITravell createTravel(string command, Dictionary<string, ITravell> typesTravell)
        {
            Console.WriteLine("Escolha um tipo de viagem \n Digite 1 para Sea \n Digite 2 para Air \n Digite 3 para Trip \n Digite 0 para Sair");
            command = Console.ReadLine();
            ITravell travel;
            typesTravell.TryGetValue(command, out travel);
            return travel;
        }
        static void Main(string[] args)
        {
            Dictionary<string, ITravell> typesTravell = new Dictionary<string, ITravell>();
            typesTravell.Add("1", new OceanVoyage());
            typesTravell.Add("2", new AirTravel());
            typesTravell.Add("3", new RoadTrip());
            string command= "1";
            string action = "1";
            while (command!= "0")
            {
                ITravell travel = createTravel(command, typesTravell);
                ITransport transport = travel.FactoryMethod();
                Console.WriteLine($"createDate: {transport.CreateDate.ToString()} | Velocidade: {transport.Velocidade}");

                Console.WriteLine("Escolha um tipo de acao \n Digite 1 para acelerar \n Digite 2 para frear \n Digite 0 para sair");
                action = Console.ReadLine();
                if(action!= "0")
                {
                    while (action != "0")
                    {
                        if (action == "1")
                        {
                            Console.WriteLine("Digite a Velocidade ");
                            double velocidade;
                            velocidade = double.Parse(Console.ReadLine());
                            transport.SpeedUp(velocidade);
                            Console.WriteLine($"createDate: {transport.CreateDate.ToString()} | Velocidade: {transport.Velocidade}");
                            Console.WriteLine("Escolha um tipo de acao \n Digite 1 para acelerar \n Digite 2 para frear \n Digite 0 para sair");
                            action = Console.ReadLine();
                        }
                        else if (action == "2")
                        {
                            Console.WriteLine("Digite a Velocidade ");
                            double velocidade;
                            velocidade = double.Parse(Console.ReadLine());
                            transport.Brake(velocidade);
                            Console.WriteLine($"createDate: {transport.CreateDate.ToString()} | Velocidade: {transport.Velocidade}");
                            Console.WriteLine("Escolha um tipo de acao \n Digite 1 para acelerar \n Digite 2 para frear \n Digite 0 para sair");
                            action = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Ação invalida ");
                            break;
                        }
                    }
                }
                else if(action == "0")
                {
                    Console.WriteLine("Programa finalizado.");
                    break;
                }
               
            }
            
        }
    }
}