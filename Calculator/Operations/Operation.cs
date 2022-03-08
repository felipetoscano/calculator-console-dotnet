using Calculator.Expressions;

namespace Calculator.Operations
{
    public class Operation
    {
        public DateTime Date { get; set; }
        public IExpression Expression { get; set; }
        public OperationSituation Situation { get; set; }

        public Operation(DateTime date, IExpression expression, OperationSituation situation)
        {
            Date = date;
            Expression = expression;
            Situation = situation;
        }

        public void Next()
        {
            if (Situation == OperationSituation.Started)
                Situation = OperationSituation.InProgress;
            else if (Situation == OperationSituation.InProgress)
                Situation = OperationSituation.Ended;
        }

        public OperationState SaveState()
        {
            return new OperationState(new Operation(Date, Expression, Situation), DateTime.Now);
        }

        public override string ToString()
        {
            return $"{Date}, {Expression}, {Situation}";
        }
    }
}
