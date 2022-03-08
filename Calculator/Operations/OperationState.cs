namespace Calculator.Operations
{
    public class OperationState
    {
        /*
         * Classe responsável por salvar o estado da classe
         * Essa classe se faz necessária para caso queiramos guardar mais alguma informação adicional durante o salvamento de um novo estado, como data, local etc.
         * Caso não seja necessário, é possível guardar o próprio objeto na classe histórica, sem um intermediário.
         */
        public Operation Operation { get; set; }
        public DateTime CreationDate { get; set; }

        public OperationState(Operation operation, DateTime creationDate)
        {
            Operation = operation;
            CreationDate = creationDate;
        }

        public override string ToString()
        {
            return $"{Operation}, {CreationDate}";
        }
    }
}
