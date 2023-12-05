using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Bank
    {
        public enum type
        {
            current,
            saving
        }
        private string Holder;
        private int Id = 0;
        private double Balans;
        private type Type = type.current;
        private static int Idk;
        private Queue<BankTransaction> queue = new Queue<BankTransaction>();

        public BankTransaction this[int index] => queue.ToArray()[index];


        public Bank(type Type)
        {
            Idk++;
            Id = Idk;
            this.Type = Type;
        }
        public Bank(string Holder, int Balans, type Type)
        {
            Idk++;
            Id = Idk;
            this.Balans = Balans;
            this.Type = Type;
            this.Holder = Holder;
        }

        public Bank(int Balans)
        {
            Idk++;
            Id = Idk;
            this.Balans = Balans;
        }



        public string PrintID => $"Создан новый счет в банке, его номер:{Id}";
        public double GetBalans => Balans;
        public int GetId => Id;
        public type GetTyp => Type;
        public string holder
        {
            get => Holder;
            set => Holder = value;
        }



        public void Takeoff()
        {
            Console.WriteLine("Введите сумму, которую хотите снять");
            bool flag = double.TryParse(Console.ReadLine(), out double sum);
            if (!flag)
            {
                Console.WriteLine("Вы не ввели число\n");
            }
            BankTransaction bankTransaction = new BankTransaction(-sum);

            if (Balans > sum)
            {
                Balans -= sum;
                queue.Enqueue(bankTransaction);
            }
            else
            {
                Console.WriteLine("Неправильно попробуй еще раз");
                Takeoff();
            }
        }
        public void Takeon()
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            bool flag = double.TryParse(Console.ReadLine(), out double sum);
            if (!flag)
            {
                Console.WriteLine("Вы не ввели число\n");
            }
            BankTransaction bankTransaction = new BankTransaction(sum);
            queue.Enqueue(bankTransaction);
            Balans += sum;
        }
        public void transfer(Bank Bank, double sum)
        {
            if (Balans > sum)
            {
                BankTransaction bankTransaction = new BankTransaction(-sum);
                BankTransaction bankTransaction2 = new BankTransaction(sum);

                queue.Enqueue(bankTransaction);
                Balans -= sum;
                Bank.Balans += sum;
                Bank.queue.Enqueue(bankTransaction2);
            }
            else Console.WriteLine("Не хватает денег для перевода");
        }
        public void Print()
        {
            Console.WriteLine($"Номер = {Id}, Тип: {Type}, Баланс: {Balans}");
        }
        public void PrintMoneySell()
        {
            foreach (BankTransaction item in queue)
                Console.WriteLine(item.PrintInfo);

        }

    }
}
