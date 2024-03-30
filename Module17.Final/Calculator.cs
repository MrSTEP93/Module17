using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module17.Final.Accounts;

namespace Module17.Final
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(Account account)
        {
            //var interest = IAccountType.CalculateInterest(account.Balance);
            //Console.WriteLine($"For your {account.Type.GetType().Name} interest is {interest}");

            var perc = account.Type.CalculateInterest(account.Balance);

        }
    }
}


/*
 * 
 * Всем привет! Выполняю финальное задание 17.6.6, про рефакторинг CalculateInterest.  https://github.com/MrSTEP93/Module17  (Внутри решения проект с именем Module17.Final)

Первое, что мне пришло в голову, сделать интерфейс IAccountType и реализовать его двумя классами - CommonAccount и SalaryAccount. НО! Сам класс Account я оставил как сущность, и свойство Type сделал не строковое, а именно IAccountType. Следовательно, в переменную Type у меня запишется экземпляр либо CommonAccount и SalaryAccount. Сразу же вопрос, а зачем мне нужен экземпляр этих классов, наверно это перебор.. Ладно, это вопрос десятый.  Главная загвоздка вылезла в другом - обращаясь к переменной Type, я не могу вызвать метод CalculateInterest(), описанный в интерфейсе и реализованный в каждом классе по-своему (ошибка на скрине). Вот это стало мне совсем непонятно, и я застопорился.

Почитал предыдущее обсуждение этого задания ( https://app.pachca.com/chats/4732219?message=142335429 ), где @Андрей_Конопляник_ментор  предлагает "добавить интерфейс IAccount, <...> а вместо класса Account создать зарплатный и обычный аккаунт, которые будут реализовывать интерфейс IAccount."

Да, вариант рабочий, пожалуй, но здесь мне не дает покоя то, что поля Balance и Interest будут описаны в каждом классе (как и все прочие поля, коих может набраться не один десяток). Разве это не нарушает принцип Don't repeat yourself? А потом появятся другие типы аккаунтов, в которых тоже придется это всё описывать... Мне казалось, что Account - единица общая и незыблемая, со своим базовым набором полей и свойств. Да, реализация некоторых из них может отличаться, я именно это я и пытался реализовать в своем примере с интерфейсом IAccountType, однако компилятор сказал мне, что я дурак)) Собственно, теперь прошу пояснения от менторов @Андрей_Конопляник_ментор  @Шалаев_Максим_Ментор  что же я делаю не так в своей жизни и в построении приложений)) 

 */
