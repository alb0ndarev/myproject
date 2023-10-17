using System;
namespace Metods
{
    public static class ProgramBank
    {
        public static void ClientProductBank()
        {
            Console.WriteLine("Введите имя клиента");
            string clientName = Console.ReadLine();
        
            Console.WriteLine("Введите возраст клиента");
            string a = Console.ReadLine();
            int clientAge = Convert.ToInt32(a);
        
            Console.WriteLine("Введите количество банковских продуктов");
            string c = Console.ReadLine();
            int colBank = Convert.ToInt32(c);
      
            Console.WriteLine("Введите сумму средств");
            string d = Console.ReadLine();
            int clientSum = Convert.ToInt32(d);
           
            if (clientAge > 60 || clientSum > 1000000 || clientSum > 400000 && colBank > 2)
            {
               Console.WriteLine($"{clientName} - акционные предложения доступны");
            }
            else
            {
               Console.WriteLine($"{clientName} - акционные предложения не доступны");
            }
        }

        public static void ProfitClient()
        {
            Console.WriteLine("Введите сумму вклада");
            string a = Console.ReadLine();
            int clientStartSum = Convert.ToInt32(a);

            Console.WriteLine("Введите продолжительность вклада в годах");
            string c = Console.ReadLine();
            int vkladAge = Convert.ToInt32(c);

            Console.WriteLine("Введите желаемый процент");
            string d = Console.ReadLine();
            int vkladProcent = Convert.ToInt32(d);
            double sumSum = 0;
            double j = clientStartSum;
            for (int i=1; i <= vkladAge; i++, j = sumSum) { 
            sumSum = (j / 100 * vkladProcent) + j;
            }

            Console.WriteLine($"Полученная сумма {sumSum}");
        }

        public static void Banlomat()
        {
            Console.WriteLine("Введите необходимую сумму кратную 100");

            int cod = Convert.ToInt32(Console.ReadLine());

            int cup100new = 0;
            int cup500new = 0;
            int cup1000new = 0;


            while (cod != 0)
            {
                int cup1000 = cod % 1000;
                cup1000new = cod / 1000;
                cod = cod / 1000;

                int cup500 = cup1000 % 500;
                cup500new = cup1000 / 500;
                cod = cod / 500;

                int cup100 = cup500new % 100;//добавил коммит
                //int cup100 = cup500new % 100;//добавил коммит
                cup100new = cup500 / 100;
                cod = cod / 100;
                
            }
            Console.WriteLine("Выданные купюры 1000 - " + cup1000new);
            Console.WriteLine("Выданные купюры 500 - " + cup500new);
            Console.WriteLine("Выданные купюры 100 - " + cup100new);
        }
    }
}


