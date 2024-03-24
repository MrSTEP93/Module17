using FactoryMethodRealExample;
using Module17.MessageEngine.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.MessageEngine.Factories
{
    /// <summary>
    /// По задумке, это абстрактная фабрика по отправке сообщений 
    /// на конкретный шлюз (Email)
    /// </summary>
    public class EmailMessageFactory : IMessageFactory
    {
        public Message Message { get; set; }
        public IGateway Gateway { get; set; }

        public EmailMessageFactory(string messageText)
        {
            Message = new Message(messageText);
            Gateway = new EmailGateway();
        }
    }
}
