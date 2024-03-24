using FactoryMethodRealExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.MessageEngine.Gateways
{
    /// <summary>
    /// Класс, реализующий шлюз емейл-сообщений
    /// </summary>
    public class EmailGateway : IGateway
    {
        public string Name { get; private set; }
        //public string Recipient { get; private set; }

        public EmailGateway()
        {
            Name = "Email gateway";
        }

        public void Send(Message message, string recipient)
        {
            if (message == null)
            {
                //Recipient = recipient;
                Console.WriteLine("Ну типа, отправлено email письмо");
            }
        }
    }
}
