using Calculator.Senders;

namespace Calculator.Messages
{
    public class AdministratorMessage : IMessage
    {
        private readonly ISender sender;

        private readonly string name;

        private readonly DateTime date;

        public AdministratorMessage(ISender sender, string name, DateTime date)
        {
            this.sender = sender;
            this.name = name;
            this.date = date;
        }

        public string Format()
        {
            return $"Mensagem para o administrador {name}, Data: {date}";
        }

        public void Send()
        {
            sender.Send(this);
        }
    }
}
