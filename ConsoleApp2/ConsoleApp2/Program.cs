using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    class ConsoleApp2
    {

        static void Main(string[] args)
        {
            var Tigr = new Tiger("Tigril");
            var Karp = new Fish("Karp");
            var Mediv = new Bird("Mediv");
            Console.WriteLine("Добро пожаловать в наш зоопарк! Выберите животного про которого хотите узнать");
            do
            {
                Console.WriteLine("1 Тигр\n2 Карп\n3 Птицы\n4 выход");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Tigr.Live();
                        Tigr.Eat();
                        Tigr.Option();
                        break;
                    case 2:
                        Karp.Eat();
                        Karp.Fisher();
                        break;
                    case 3:
                        Mediv.Liv();
                        Mediv.War();
                        break;
                    case 4:
                        Console.WriteLine("Выйти из зоопарка");
                        return;

                    default:
                        Console.WriteLine("Ошибка! Попробуйте еще раз!");
                        break;
                }
                Console.WriteLine("Введите 1 если хотите вернуться в меню или 0 если хотите выйти");
                int x;
                x = int.Parse(Console.ReadLine());
                if (x == 0) 
                    { 
                        return; 
                    }
            } while (true);
        }

    }
}
