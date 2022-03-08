using Calculator.Senders;

namespace Calculator.Messages
{
    public class ClientMessage : IMessage
    {
        private readonly ISender sender;

        private readonly string name;

        public ClientMessage(ISender sender, string name)
        {
            this.sender = sender;
            this.name = name;
        }

        public string Format()
        {
            return $"Mensagem para o cliente {name}";
        }

        public void Send()
        {
            sender.Send(this);
        }
    }
}
