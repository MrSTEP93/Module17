using FactoryMethodRealExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Module17.MessageEngine.Gateways
{
    /// <summary>
    /// Класс, реализующий шлюз смс-сообщений
    /// </summary>
    public class SmsGateway : IGateway
    {
        public string Name {get; private set;}
        //public string Recipient { get; private set;}

        public SmsGateway()
        {
            Name = "SMS gateway";
        }

        public void Send (Message message, string recipient)
        {
            if (message == null)
            {
                //Recipient = recipient;
                Console.WriteLine("Ну типа, СМС отправлено");
            }
        }
    }
}
