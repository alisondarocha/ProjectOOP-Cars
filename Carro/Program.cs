using System;
using System.Threading;

namespace _Car
{
    public class Car
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Management c1 = new Management("FORD","Corcel II", false, 1979, 0);
            Management c2 = new Management("BMW", "X1", 2020);
            Management c3 = new Management("CHEVROLET","Spin LTZ", 2016);

            while(true)
            {
                Console.WriteLine("Ver detalhes de um carro:");
                Console.WriteLine("Corcel II [1]");
                Console.WriteLine("BMW X1 [2]");
                Console.WriteLine("Spin LTZ [3]");
                Console.WriteLine("Próximo passo [0]");
                Console.WriteLine("----------------");
                Console.WriteLine("Selecione uma opção:");
                int r1 = int.Parse(Console.ReadLine());
                if(r1 == 1)
                    c1.details();
                    Thread.Sleep(2000);
                if(r1 == 2)
                    c2.details();
                    Thread.Sleep(2000);
                if(r1 == 3)
                    c3.details();
                    Thread.Sleep(2000);
                if(r1 == 0)
                    break;
            }

            while(true)
            {   
                Console.WriteLine("Verificar motor do CorcelII [1]");
                Console.WriteLine("Verificar motor do X1 [2]");
                Console.WriteLine("Verificar motor da Spin LTZ [3]");
                Console.WriteLine("Próximo passo [0]");

                Console.WriteLine("------------------------");
                Console.WriteLine("Selecione uma opção:");

                int res = int.Parse(Console.ReadLine());

                if(res == 1)
                {
                    string corcelIIMotor = c1.engineSituation();
                    Console.WriteLine(corcelIIMotor);
                }
                if(res == 2)
                {
                    string x1Motor = c2.engineSituation();
                    Console.WriteLine(x1Motor);
                }
                if(res == 3)
                {
                    string spinMotor = c3.engineSituation();
                    Console.WriteLine(spinMotor);
                }
                if(res == 0)
                    break;
            }
            while(true)
            {
                Console.WriteLine("Ligar motor do CorcelII [1]");
                Console.WriteLine("Ligar motor do X1 [2]");
                Console.WriteLine("Ligar motor da Spin LTZ [3]");
                Console.WriteLine("Próximo passo [0]");

                Console.WriteLine("------------------------");
                Console.WriteLine("Selecione uma opção:");

                int res2 = int.Parse(Console.ReadLine());

                if(res2 == 1)
                {   
                    Console.WriteLine(c1.startEngine());
                    Thread.Sleep(2000);
                }
                if(res2 == 2)
                {
                    Console.WriteLine(c2.startEngine());
                    Thread.Sleep(2000);
                }
                if(res2 == 3)
                {
                    Console.WriteLine(c3.startEngine());
                    Thread.Sleep(2000);
                }
                if(res2 == 0)
                    break;
            }
        }
    }
}