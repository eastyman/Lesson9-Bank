using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9_Banks
{
    public class Menu
    {
        private Account[] accountList;
        public void ShowMenu()
        {
            accountList = new Account[3];
            accountList[0] = new DepAccount(10.5, 15.0, "Artur Pirojkov");
            accountList[1] = new CardAccount(8.5, 20.0, "Mikhail Stasov");
            accountList[2] = new CurrAccaunt(0.0, "Stas Mikhailov");
            while (true)
            {
                Console.Clear();
                byte listNumber = 1;
                foreach (var acc in accountList)
                {
                    Console.WriteLine(listNumber++ + " - Работа с счетом клиента " + acc.ReturnOwner());
                }
                Console.WriteLine("0 - Выход");
                Console.Write("Введите номер: ");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 0)
                    {
                        return;
                    }
                    Options(accountList[number - 1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный номер");
                    Console.ReadLine();
                }

            }
        }

        private void Options(Account account)
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Операции для счета клиента " + account.ReturnOwner());
                if (account is IProcentable)
                {
                    Console.WriteLine("ps-задать новую процентную ставку");
                    Console.WriteLine("sp-начислить проценты");
                }
                if (account is IAccessable)
                {
                    Console.WriteLine("pm-положить деньги на счет");
                    Console.WriteLine("gm-снять деньги со счтеа");
                }
                Console.WriteLine("cl - закрыть счет");
                Console.WriteLine("i - инфа по счету");
                Console.WriteLine("b - вернуться в главное меню");
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();
                Console.Clear();
                switch (command)
                {
                    case "ps":
                        if (account is IProcentable)
                        {
                            Console.WriteLine("Введите новую процентную ставку");
                            string rate = Console.ReadLine();
                            ((IProcentable)account).SetRate(Convert.ToDouble(rate));
                        }
                        break;
                    case "sp":
                        if (account is IProcentable)
                        {
                            ((IProcentable)account).PercentAccural();
                            Console.Clear();
                            account.AccountState();
                            Console.ReadKey();
                        }
                        break;
                    case "pm":
                        if (account is IAccessable)
                        {
                            Console.WriteLine("Введите cумму, которую необходимо положить на счет");
                            string amount = Console.ReadLine();
                            ((IAccessable)account).PutAmount(Convert.ToDouble(amount));
                            account.AccountState();
                            Console.ReadKey();
                        }
                        break;
                    case "gm":
                        if (account is IAccessable)
                        {
                            Console.WriteLine("Введите cумму, которую необходимо снять со счета");
                            string amount = Console.ReadLine();
                            ((IAccessable)account).GetAmount(Convert.ToDouble(amount));
                            account.AccountState();
                            Console.ReadKey();
                        }
                        break;
                    case "b":
                        return;
                    case "i":
                        account.AccountState();
                        Console.ReadKey();
                        break;
                    case "cl":
                        account.CloseAccount();
                        account.AccountState();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;

                }
            }
        }
    }
}
