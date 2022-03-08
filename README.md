# calculator
Projeto em C# voltado para mostrar uma série de Design Patterns

Com o tema "Calculadora", este projeto se destina ao entendimento dos Design Patterns que serão detalhados abaixo.

A classe principal contém uma série de exemplos, além de várias classes estarem com comentários pertinentes a sua função dentro do Design Pattern.

## Factory

Design Pattern que procura simplificar a criação dos objetos, literalmente funcionando como uma "fábrica", onde cria objetos padronizados e que raramente precisam ser alterados.

## Flyweight

Design Pattern que procura otimizar o uso de memória, controlando a instanciação de novas classes e sempre retornando uma mesma instância. Funciona como um Singleton, porém uma classe faz o gerenciamento de várias outras classes.

## Interpreter

Design Pattern que procura simplificar a resolução de expressões em forma de árvore.

Ex.: (1 + 1) * (2 - (10 + 10))

O interpreter utiliza de interfaces genéricas, realizando os cálculos das espressões da "direita" e "esquerda". Como se aproveita da estrutura de árvore, é possível uma expressão estar dentro de outra.

## Memento

Design Pattern que procura armazenar o histórico de estados de uma classe.

## Visitor

Design Pattern que "visita" uma estrutura de árvore, realizando o caminho inverso do "Interpreter". Essencial para a exibição da expressão original na tela, por exemplo.

## Bridge

Design Pattern que procura se unir com outras hierarquias de classes.
No exemplo da aplicação, temos uma hierarquia de tipos de mensagens e outra de tipos de envio. 
Como se tratam de duas hierarquias diferentes que precisam de unir para enviar um SMS, por exemplo, podemos utilizar o padrão Bridge para esta unificação.

## Command

Design Pattern que trabalha gerenciando comandos de classes.
Neste exemplo, armazenamos os comandos em uma lista para futuramente serem executados com maior controle e em uma hora mais propícia.
Utilizamos de uma interface para generalizar os comandos, forçando a classe a apenas implementar o método Execute(), para que a lista de comandos saiba executá-los corretamente.

## Adapter

Design Pattern que procura adaptar determinadas classes para a utilização dela nos escopos do projeto.
Por exemplo, caso seja recebida uma requisição no formato XML, a classe Adapter será responsável por realizar a transformação desta requisição em um objeto, para que seja possível manipulá-la e outros lugares do projeto.

## Facades

Design Pattern que procura abstrair códigos complexos, de sistemas legados por exemplo, criando uma "fachada", a fim de tornar mais fácil a utilização de determinadas funções.

Devemos tomar cuidado com este tipo de padrão, pois a classe "Facade" pode ficar bagunçada e cada vez mais complexa, se tornando um "cantinho da bagunça".

## Singleton

Design Pattern semelhante ao Flyweight, mas se preocupa apenas UM objeto, retornando sempre a mesma instância durante todo o ciclo de vida da aplicação.

