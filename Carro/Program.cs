using System;
using System.Threading;

namespace _Car
{
    public class Car
    {
        static void Main(string[] args)
        {
            Management c1 = new Management("FORD","Corcel II", false, 1979, 0);
            Console.WriteLine(c1.Manufacturer);
            Console.WriteLine(c1.Model);
            Console.WriteLine(c1.Year);
            Console.WriteLine(c1.EngineOn);
            Console.WriteLine(c1.Velocity);
            Thread.Sleep(5000);
            Management c2 = new Management("BMW", "X1", false, 2020, 0);
            Console.WriteLine(c2.Manufacturer);
            Console.WriteLine(c2.Model);
            Console.WriteLine(c2.Year);
            Console.WriteLine(c2.EngineOn);
            Console.WriteLine(c2.Velocity);
            Thread.Sleep(5000);
            firstStep();
        }

        static void firstStep()
        {
            // Console.Clear();
            Console.WriteLine($"Carro");
            Console.WriteLine("O que você deseja fazer:");
            Console.WriteLine("1 - Entrar no carro [1]");
            Console.WriteLine("2 - Olhar motor [2]");
            Console.WriteLine("3 - EXIT [0]");
            
            Console.WriteLine("-----------------------------");     
            Console.WriteLine("Selecione uma opção:");

            int res = int.Parse(Console.ReadLine());    
            
            if(res == 1)
            {
                Doors enter = new Doors();
                enter.Enter();
            }
            else if(res == 2)
            {
                Motor see = new Motor();
                see.lifespan();
                Thread.Sleep(4000);
                firstStep();
            }
            else if (res == 0)
                System.Environment.Exit(0);
            else
                firstStep();
            secondStep();
        }
        static void secondStep()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("O que deseja fazer agora:");
            Console.WriteLine("1 - Ligar o carro [1]");
            Console.WriteLine("2 - Sair do carro [0]");

            Console.WriteLine("------------------------");
            Console.WriteLine("Selecione uma opção:");

            int res2 = int.Parse(Console.ReadLine());

            if(res2 == 1)
            {
                Motor start = new Motor();
                start.startCar();
            }
           else if(res2 == 0)
           {
               Doors exit = new Doors();
               exit.Exit();
               firstStep();
           }
           else
               secondStep();   
        }   
    }
}