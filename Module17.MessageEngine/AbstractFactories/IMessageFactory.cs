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
    /// Интерфейс, организующий создание сообщения и отправку его через определенный шлюз
    /// (шлюзы будут описаны в классах, реализущих данный интерфейс)
    /// </summary>
    public interface IMessageFactory
    {
        public Message Message { set; }
        public IGateway Gateway { set; }
    }
}
