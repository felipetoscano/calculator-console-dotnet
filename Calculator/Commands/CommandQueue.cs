namespace Calculator.Commands
{
    /*
     * Classe responsável por enfileirar uma lista de comandos a serem executados
     * Com esta classe, é possível armazenar uma série de comandos que podem ser executados ao fim do dia, por exemplo, tendo um controle maior destas execuções
     */
    public class CommandQueue
    {
        private readonly IList<ICommand> commands;

        public CommandQueue()
        {
            commands = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteAll()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
        }
    }
}
