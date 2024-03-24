using System;
using System.Text;

namespace FactoryMethodRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var message = new Message("Ваш номер заказа - 83456");





            //// Отправляем заказ по SMS
            //MessageSender sender = new SmsMessageSender("+79856455320");
            //Message smsMessage = sender.Send(messageText);
         
            //// Отправляем заказ по e-mail
            //sender = new EmailMessageSender("orders@myshop.com");
            //Message message = sender.Send(messageText);

        }
    }
}