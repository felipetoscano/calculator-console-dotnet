using Calculator.Messages;

namespace Calculator.Senders
{
    public class EmailSender : ISender
    {
        public void Send(IMessage message)
        {
            /*
             * Realiza operação de envio ao e-mail
             */
            Console.WriteLine($"Enviando por e-mail: {message.Format()}");
        }
    }
}
