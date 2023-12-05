using Lab14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");
            Bank bank = new Bank("Вова Адидас", 10000, Bank.type.saving);
            bank.DumpToScreen();


            Console.WriteLine("Задание 2");
            System.Reflection.MemberInfo inf;
            inf = typeof(RationalDigits);
            object[] arr = inf.GetCustomAttributes(false);
            foreach (object i in arr)
            {
                if(i is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute a = (DeveloperInfoAttribute)i;
                    Console.WriteLine($"Разработчик :{a.Name} \n");
                }

            }

            System.Reflection.MemberInfo inf1;
            inf1 = typeof(Bank);
            object[] arr1 = inf1.GetCustomAttributes(false);
            foreach (Attribute atribute in arr1)
            {
                if (atribute is NameOrgAtribute)
                {
                    NameOrgAtribute a = (NameOrgAtribute)atribute;
                    Console.WriteLine($"Разработчик :{a.Name} \n Организация:{a.Organization}");
                }
            }
            Console.ReadKey();


        }
    }
}