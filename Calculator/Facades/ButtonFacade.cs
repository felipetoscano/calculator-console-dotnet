using Calculator.Buttons;

namespace Calculator.Facades
{
    public class ButtonFacade
    {
        /*
         * Classe utilizada para abstrair códigos antigos, vindo de sistemas legados por exemplo, para facilitar a aplicação do código nos padrões atuais.
         * Normalmente não é muito utilizada por trazer muitos problemas.
         * Ex.: Dependendo da complexidade dos códigos, esta classe pode ficar enorme e cada vez mais complexa e "bagunçada".
         */
        public OnButton ConfigureOnButton()
        {
            /*
             * Série de comandos complexos e antigos
             */
            return new OnButton();
        }

        public OffButton ConfigureOffButton()
        {
            /*
             * Série de comandos complexos e antigos
             */
            return new OffButton();
        }
    }
}
