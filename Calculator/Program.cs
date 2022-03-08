using Calculator.Adapters;
using Calculator.Buttons;
using Calculator.Commands;
using Calculator.Expressions;
using Calculator.Facades;
using Calculator.Factories;
using Calculator.Messages;
using Calculator.Operations;
using Calculator.Senders;
using Calculator.Singletons;
using Calculator.Visitors;

namespace Calculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Design Pattern Factory: instanciando uma nova conexão de forma fácil.
            var connection = new ConnectionFactory().GetConnection();

            // Design Pattern Flyweight: instanciando multiplos objetos iguais.
            SoundButtonFlyweight.Sound(SoundButtonFlyweight.Take("on"));
            SoundButtonFlyweight.Sound(SoundButtonFlyweight.Take("off"));
            SoundButtonFlyweight.Sound(SoundButtonFlyweight.Take("clear"));
            SoundButtonFlyweight.Sound(SoundButtonFlyweight.Take("clear"));
            SoundButtonFlyweight.Sound(SoundButtonFlyweight.Take("clear"));

            Console.WriteLine();

            // Design Pattern Interpreter: para avaliação de expressões em esquema de "árvore".
            var left = new SubtractionExpression(new NumberExpression(10), new NumberExpression(5));
            var right = new SumExpression(new NumberExpression(1), new SqrtExpression(new NumberExpression(4)));
            var expression = new SumExpression(left, right);
            int result = expression.Evaluate();
            Console.WriteLine(result);

            Console.WriteLine();

            // Design Pattern Memento: Armazenamento de histórico de estados de uma classe.
            var operationHistory = new OperationHistory();

            var operation = new Operation(DateTime.Now, new NumberExpression(0), OperationSituation.Started);
            operationHistory.Add(operation.SaveState());

            operation.Expression = left;
            operation.Next();
            operationHistory.Add(operation.SaveState());

            operation.Expression = expression;
            operation.Next();
            operationHistory.Add(operation.SaveState());

            Console.WriteLine(operationHistory.Take(0));
            Console.WriteLine(operationHistory.Take(1));
            Console.WriteLine(operationHistory.Take(2));

            Console.WriteLine();

            // Design Pattern Visitor: visitando a árvore, fazendo o caminho inverso da criação dela, para exibir a expressão na tela, por exemplo.
            var printer = new ExpressionPrinterVisitor();
            expression.Accept(printer);

            Console.WriteLine();
            Console.WriteLine();

            // Design Pattern Bridge: separando as responsabilidades de uma hierarquia de classes outras em duas ou mais e interligando-as.
            var smsSender = new SmsSender();
            var emailSender = new EmailSender();

            new AdministratorMessage(smsSender, "Felipe", DateTime.Now).Send();
            new AdministratorMessage(emailSender, "Felipe", DateTime.Now).Send();
            new ClientMessage(smsSender, "Felipe").Send();
            new ClientMessage(emailSender, "Felipe").Send();

            Console.WriteLine();

            // Design Pattern Command: preparando uma lista de comandos a serem executados posteriormente.
            var queue = new CommandQueue();

            var expression1 = new SumExpression(new NumberExpression(1), new NumberExpression(1));
            var command1 = new EvaluateExpressionCommand(expression1);

            var expression2 = new SubtractionExpression(new NumberExpression(1), new NumberExpression(1));
            var command2 = new EvaluateExpressionCommand(expression2);

            var expression3 = new SqrtExpression(new NumberExpression(4));
            var command3 = new EvaluateExpressionCommand(expression3);

            queue.Add(command1);
            queue.Add(command2);
            queue.Add(command3);

            queue.ExecuteAll();

            Console.WriteLine();

            // Design Pattern Adapter: adaptando códigos de bibliotecas ou legadas, por exemplo, para o padrão de objeto atual.
            var adapter = new XmlAdapter();
            var onButton = new OnButton();
            var xml = adapter.GenerateXml(onButton);
            Console.WriteLine(xml);

            Console.WriteLine();

            // Design Pattern Facade: abstraindo códigos antigos e complexos para mais fácil entendimento e aplicação no padrão atual.
            var facade = new ButtonFacade();
            var onButtonFacade = facade.ConfigureOnButton();
            var offButtonFacade = facade.ConfigureOffButton();

            // Design Pattern Singleton: semelhante ao Flyweight, mas responsável por cuidar apenas de um objeto.
            var singleton = new OnButtonSingleton();
            //Todas as instâncias tem o mesmo objeto de referencia
            var onButtonSingleton1 = singleton.Instance;
            var onButtonSingleton2 = singleton.Instance;
            var onButtonSingleton3 = singleton.Instance;
        }
    }
}