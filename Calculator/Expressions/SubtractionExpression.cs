using Calculator.Visitors;

namespace Calculator.Expressions
{
    public class SubtractionExpression : IExpression
    {
        public IExpression Left { get; private set; }
        public IExpression Right { get; private set; }

        public SubtractionExpression(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public int Evaluate()
        {
            return Left.Evaluate() - Right.Evaluate();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PrintSubtraction(this);
        }
    }
}
