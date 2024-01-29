# Padrão de Design Factory Method

O padrão de design Factory Method é um padrão de criação que define uma interface para criar um objeto, mas permite que as subclasses alterem o tipo de objetos que serão criados.

## Diagrama de Classes

O diagrama de classes abaixo representa a estrutura básica do padrão Factory Method:



### Descrição das Classes:

- **Product**: Define a interface dos objetos que o Factory Method cria.
- **ConcreteProductA, ConcreteProductB**: Implementações concretas do `Product`.
- **Creator**: Declara o Factory Method, que retorna um objeto do tipo `Product`. Pode conter implementações padrão ou abstratas do Factory Method.
- **ConcreteCreatorA, ConcreteCreatorB**: Subclasses de `Creator` que implementam o Factory Method para criar instâncias específicas de `Product`.
