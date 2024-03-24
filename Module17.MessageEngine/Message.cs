namespace FactoryMethodRealExample
{
    public class Message
    {
        public string Text { get; set; }
        //public string Recipient { get; set; }

        //string recepient
        public Message(string text)
        {
            Text = text;
            //Recipient = recepient;
        }
    }
}