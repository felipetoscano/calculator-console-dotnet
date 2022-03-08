using Calculator.Messages;

namespace Calculator.Senders
{
    public class SmsSender : ISender
    {
        public void Send(IMessage message)
        {
            /*
             * Realiza operação de envio de SMS
             */
            Console.WriteLine($"Enviando por SMS: {message.Format()}");
        }
    }
}
