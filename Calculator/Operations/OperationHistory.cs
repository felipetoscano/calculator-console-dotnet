namespace Calculator.Operations
{
    public class OperationHistory
    {
        /*
         * Classe responsável por guardar os históricos de estados de uma classe
         * Caso eu precise manter um histórico de estados de um determinado objeto, posso centralizar em uma classe que será responsável por isso
         */
        private readonly IList<OperationState> states;

        public OperationHistory()
        {
            states = new List<OperationState>();
        }

        public OperationState Take(int index)
        {
            return states[index];
        }

        public void Add(OperationState state)
        {
            states.Add(state);
        }
    }
}
