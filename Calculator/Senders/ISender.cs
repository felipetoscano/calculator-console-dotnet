using Calculator.Messages;

namespace Calculator.Senders
{
    /* Classe responsável pela hierarquia de classes de formas de envio
     * Quando temos uma hierarquia de classes e queremos separar as responsabilidades, mas ainda unindo-as de alguma forma, podemos utilizar o padrão Bridge
     */
    public interface ISender
    {
        public void Send(IMessage message);
    }
}
