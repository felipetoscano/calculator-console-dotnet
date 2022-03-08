namespace Calculator.Messages
{
    /* Classe responsável pela hierarquia de classes de mensagens
     * Quando temos uma hierarquia de classes e queremos separar as responsabilidades, mas ainda unindo-as de alguma forma, podemos utilizar o padrão Bridge
     */
    public interface IMessage
    {
        public void Send();

        public string Format();
    }
}
