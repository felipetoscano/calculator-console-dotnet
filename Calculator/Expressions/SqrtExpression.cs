using Calculator.Visitors;

namespace Calculator.Expressions
{
    public class SqrtExpression : IExpression
    {
        public IExpression Expression { get; private set; }

        public SqrtExpression(IExpression expression)
        {
            Expression = expression;
        }

        public int Evaluate()
        {
            return (int)Math.Sqrt(Expression.Evaluate());
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PrintSqrt(this);
        }
    }
}
