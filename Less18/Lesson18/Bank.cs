
namespace Metods
{
    public static class Bank
    {
        public static string ClientProductBank(string clientName, int clientAge, int colBank, int clientSum)
        {
            if (clientAge > 60 || clientSum > 1000000 || clientSum > 400000 && colBank > 2)
            {
                return $"{clientName} - акционные предложения доступны";
            }
            else
            {
                return $"{clientName} - акционные предложения не доступны";
            }
        }

        public static string ProfitClient(int clientStartSum, int vkladAge, int vkladProcent)
        { 
            double sumSum = 0;
          double j = clientStartSum;
            for (int i=1; i <= vkladAge; i++, j = sumSum) { 
            sumSum = (j / 100 * vkladProcent) + j;
            }

                return $"Полученная сумма {sumSum}";
        }

        public static string Bankomat(int cod)
        {
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

                int cup100 = cup500new % 100;
                cup100new = cup500 / 100;
                cod = cod / 100;

            }
            return $"Выданные купюры 1000 - {cup1000new}, Выданные купюры 500 - {cup500new}, Выданные купюры 100 - {cup100new}";
        }
    }
}


