using Calculator.Expressions;

namespace Calculator.Visitors
{
    /*
     * Classe responsável por deixar a Visitor genérica.
     * Desta forma, podemos implementar vários tipos de impressora para mostrar diferentes tipos de exibição, por exemplo.
     */
    public interface IVisitor
    {
        public void PrintSum(SumExpression sum);
        public void PrintSubtraction(SubtractionExpression subtraction);
        public void PrintSqrt(SqrtExpression sqrt);
        public void PrintNumber(NumberExpression number);
    }
}
