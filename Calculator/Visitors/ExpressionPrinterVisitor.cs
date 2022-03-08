using Calculator.Expressions;

namespace Calculator.Visitors
{
    /*
     * Classe que é responsável por centralizar as configurações de impressão da expressão na tela.
     * Desta forma, percorremos a árvore e vamos montando a string de exibição na tela conforme vai entrando no método Accept().
     * Este método pode chamar ele mesmo ou outro método, dependendo do tipo da classe herdada. A ramificação da árvore só acaba quando o tipo da classe é um número, permitindo agora ir para a próxima ramificação até acabar.
     */
    public class ExpressionPrinterVisitor : IVisitor
    {
        public void PrintSum(SumExpression sum)
        {
            Console.Write("(");
            sum.Left.Accept(this);
            Console.Write("+");
            sum.Right.Accept(this);
            Console.Write(")");
        }

        public void PrintSubtraction(SubtractionExpression subtraction)
        {
            Console.Write("(");
            subtraction.Left.Accept(this);
            Console.Write("-");
            subtraction.Right.Accept(this);
            Console.Write(")");
        }

        public void PrintSqrt(SqrtExpression sqrt)
        {
            Console.Write("(");
            Console.Write("√");
            sqrt.Expression.Accept(this);
            Console.Write(")");
        }

        public void PrintNumber(NumberExpression number)
        {
            Console.Write(number.Value);
        }

    }
}
