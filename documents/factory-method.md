## Factory Method Pattern

### Definition

The Factory Method Pattern is a creational design pattern that provides an **interface for creating objects in a super class**, but **allows subclasses to alter the type of objects that will be created**. It promotes loose coupling and enhances extensibility by delegating the responsibility of object creation to subclasses.

It encapsulates the object creation process in a separate method, which can be overridden by subclasses to create specific instances of objects.

&nbsp;

### Why This Pattern

The Factory Method Pattern was created to address the need for a flexible and extensible way of creating objects. It allows a class to delegate the responsibility of instantiating objects to its subclasses, enabling the creation of different types of objects without altering the code of the superclass.

&nbsp;

### About

> A method for creating an object in the superclass, but allowing subclasses to alter the type of object that will be created.

> Enhances extensibility by letting subclasses decide which class to instantiate.

> Promotes loose coupling between the creator and the product.

> Commonly used to implement libraries, frameworks, and plug-ins.

> Provides a clear separation of responsibilities between object creation and object usage.

&nbsp;

### Model

![Factory Method Pattern](https://github.com/fabioono25/design-patterns/blob/main/assets/factorymethod.png)

![Factory Method Pattern](https://github.com/fabioono25/design-patterns/blob/main/assets/factorymethod2.png)

&nbsp;

### Advantages

- **Loose Coupling**: Clients are decoupled from the specific classes they instantiate, allowing for more flexibility in the system.
- **Extensibility**: New product classes can be easily added without modifying existing code.
- **Single Responsibility Principle (SRP)**: Creator classes focus on object creation, adhering to the SRP.
- **Encapsulation**: The creation process is encapsulated in the factory method, promoting encapsulation.

&nbsp;

### Disadvantages

- **Complexity**: Introduces additional complexity compared to directly instantiating objects.
- **Increased Number of Classes**: The pattern can lead to an increased number of classes in the system, which might be overwhelming for small projects.

&nbsp;

### Real-World Examples of Use

- **GUI Libraries**: Different operating systems can have different implementations of GUI components (buttons, windows, etc.) through factory methods.
- **Document Generators**: A document generator could have factory methods for creating different document formats (PDF, HTML, etc.).
- **Game Development**: Game engines often use factory methods to create various game objects based on user interactions.

&nbsp;

### Relationship with Other Patterns

- **Abstract Factory**: The Factory Method can be considered a specialization of the Abstract Factory pattern, where each concrete factory corresponds to a single product.
- **Template Method**: The Factory Method pattern often uses a template method to define the steps of object creation that subclasses can override.

&nbsp;

### How to Replace This Pattern

- **Direct Instantiation**: In simpler scenarios, direct instantiation of objects may suffice if extensibility requirements are minimal.
- **Builder Pattern**: When the object creation process involves multiple steps or parameters, the Builder pattern might provide a more flexible solution.

&nbsp;

### Examples of Implementation

#### Simple Implementation

The following example demonstrates a simple implementation of the Factory Method pattern:

```csharp
public interface IProduct
{
    string Operation();
}

public class ConcreteProductA : IProduct
{
    public string Operation()
    {
        return "ConcreteProductA";
    }
}

public class ConcreteProductB : IProduct
{
    public string Operation()
    {
        return "ConcreteProductB";
    }
}

public abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}
