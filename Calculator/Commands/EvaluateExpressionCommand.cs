using Calculator.Expressions;

namespace Calculator.Commands
{
    /*
     * Classe que representa um comando em si
     * A partir desta classe, podemos isolar um único comando vindo de uma classe específica e, com a implementação interface genérica, podemos especificar exatamente como executar este comando.
     */
    public class EvaluateExpressionCommand : ICommand
    {
        private readonly IExpression expression;

        public EvaluateExpressionCommand(IExpression expression)
        {
            this.expression = expression;
        }

        public void Execute()
        {
            Console.WriteLine($"Executando expressão");
            expression.Evaluate();
        }
    }
}
