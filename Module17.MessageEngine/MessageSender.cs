namespace FactoryMethodRealExample
{
    /// <summary>
    /// Абстрактный класс для рассылок
    /// </summary>
    abstract class MessageSender
    {
        public string Recipient { get; private set; }

        public MessageSender (string recipient)
        { 
            Recipient = recipient; 
        }
        
        // Фабричный метод
        abstract public bool Send(string text);
    }
}