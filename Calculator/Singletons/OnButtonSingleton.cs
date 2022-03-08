using Calculator.Buttons;

namespace Calculator.Singletons
{
    /*
     * Classe responsável por retornar apenas uma instância de uma classe.
     */
    public class OnButtonSingleton
    {
        private static readonly OnButton instance = new();

        public OnButton Instance
        {
            get { return instance; }
        }
    }
}
