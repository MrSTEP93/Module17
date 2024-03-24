namespace FactoryMethodRealExample
{
    /// <summary>
    /// Класс для рассылки e-mail
    /// </summary>
    class EmailMessageSender : MessageSender
    { 
        public EmailMessageSender(string @from) : base(@from)
        { }
 
        public override bool Send(string text)
        {
            return true;
        }
    }
}