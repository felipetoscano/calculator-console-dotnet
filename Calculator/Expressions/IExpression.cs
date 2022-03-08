using Calculator.Visitors;

namespace Calculator.Expressions
{
    /*
     * Com a utilização desta interface, conseguimos generalizar as expressões da direita e da esquerda, permitindo infinitas combinações.
     * E com o método Evaluate(), podemos resolver em cada classe o que deve ser feito com a expressão.
     * Ao implementar o método Accept(), obrigamos a classe que herda realizar a implementação das configurações de impressão na tela.
     */
    public interface IExpression
    {
        public int Evaluate();
        public void Accept(IVisitor visitor);
    }
}
