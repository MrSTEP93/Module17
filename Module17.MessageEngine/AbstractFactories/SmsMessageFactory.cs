using FactoryMethodRealExample;
using Module17.MessageEngine.Factories;
using Module17.MessageEngine.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.MessageEngine.AbstractFactories
{
    /// <summary>
    /// По задумке, это абстрактная фабрика по отправке сообщений 
    /// на конкретный шлюз (SMS)
    /// </summary>
    public class SmsMessageFactory : IMessageFactory
    {
        public Message Message { get; set; }
        public IGateway Gateway { get; set; }

        public SmsMessageFactory(string messageText)
        {
            Message = new Message(messageText);
            Gateway = new SmsGateway();
        }
    }
}
