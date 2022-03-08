using Calculator.Visitors;

namespace Calculator.Expressions
{
    public class NumberExpression : IExpression
    {
        public int Value { get; private set; }

        public NumberExpression(int value)
        {
            Value = value;
        }

        public int Evaluate()
        {
            return Value;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PrintNumber(this);
        }
    }
}
