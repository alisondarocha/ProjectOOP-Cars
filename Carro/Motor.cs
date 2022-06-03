using System;
using System.Threading;

namespace _Car
{
    public class Motor
    {
        
        private double life;
        private double health
()
        {
            return life;
        }
        public void startCar()
        {
            Console.WriteLine("Ligando o carro...");
            Thread.Sleep(3000);
            Console.WriteLine("O carro está ligado!");
        }
        public void turnOffCar()
        {
            Console.WriteLine("O carro está desligado");
        }
        public void lifespan()
        {
            Console.WriteLine($"A vida útil do motor está em {health()}% ");
        } 
    }
}


