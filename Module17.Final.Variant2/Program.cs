using Module17.Final.Variant2.Accounts;
using System;

namespace Module17.Final.Variant2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var acc1 = new CommonAccount();
            acc1.Balance = 1000.0;
            acc1.CalculateInterest();

            var acc2 = new SalaryAccount();
            acc2.Balance = 35000.0;
            acc2.CalculateInterest();

            Console.ReadKey();
        }
    }
}


/*
 * Второй вариант задания, сделанный по подсказке других студентов. Получился более легким и изящным
 * (решил попробовать обойтись даже без интерфейса), расчет ставки включен в сам класс-наследних аккаунта.
 * 
 * На мой взгляд, при таком подходе нет смысла вызывать метод CalculateInterest некого класса Calculator, 
 * чтобы потом вызвать из него метод, встроенный в класс-наследник Account.
 * Да, можно, но я не стал - такая реализация у меня есть в первом варианте решения =)
 */
