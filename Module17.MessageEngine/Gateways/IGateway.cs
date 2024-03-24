using FactoryMethodRealExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.MessageEngine.Gateways
{
    /// <summary>
    /// Интерфейс, описывающий поля и методы шлюзов для отправки сообщений
    /// </summary>
    public interface IGateway
    {
        public string Name { get; }
        //public string Recipient { get;}

        public void Send (Message message, string recipient);
    }
}
