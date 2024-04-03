using Module17.Final.Accounts;
using Module17.Final.Calculator;
using Module17.Final.Calculator.Calculator;
using System;

namespace Module17.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Account acc = new Account();
            acc.Type = AccountTypes.Common;
            acc.Balance = 1000.0;
            InterestCalculator.CalculateInterest(acc, new CommonAccountInterestCalculator());
            InterestCalculator.CalculateInterest(acc, new SalaryAccountInterestCalculator());
        }
    }
}


/*
 * Данный вариант доработки был предложен ментором в Пачке, когдая я понял, что у меня не получается самостоятельно вызвать метод расчета в зависимости от типа аккаунта.
 * Сначала я подумал, что в данном варианте я могу вызвать для обычного аккаунта расчет зарплатной ставки, эти два понятия никак не связаны и не контролируются.
 * Затем я решил добавить проверку на тип аккаунта, и теперь это имеет право на жизнь.
 */