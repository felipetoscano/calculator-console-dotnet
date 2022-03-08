namespace Calculator.Buttons
{
    public class SoundButtonFlyweight
    {
        /*
         * Classe que auxilia na recuperação de objetos sem gastar muita memória.
         * Como os objetos a serem instanciados não mudarão, podemos reduzir o consumo de memória nos referindo a apenas um objeto em vez de instanciar vários novos.
         */
        private static readonly IDictionary<string, IButton> _buttons = new Dictionary<string, IButton>()
        {
            { "on", new OnButton() },
            { "off", new OffButton() },
            { "clear", new ClearButton() }
        };

        public static IButton Take(string buttonName)
        {
            return _buttons[buttonName];
        }

        public static void Sound(IButton button)
        {
            Console.WriteLine($"Emitindo som de frequência {button.Frequency}");
            //Console.Beep(button.Frequency, 300);
        }
    }
}
