
# Design Patterns

The idea is to organize all design patterns (GoF and no GoF) in a series of definitions and examples.


## Design Principles

> Identify the aspects of your application that vary and separate them from what stays the same.

> Program to an interface, not an implementation

> Favor composition over inheritance


## Strategy Pattern

### Definition

> Defines a **family of algorithms**, encapsulate each one in separated classes, and makes them **interchangeable** (Plug-and-play). Strategy lets the algorithm **vary independently** from the clients that use it (decoupling them).

> Use composition rather than inheritance.
> 
> Strategies are easily replaceable and interchangeable by clients at runtime.

> Focus on behaviors and how they vary, and compose them to be used by one or multiple family of classes (clients). Example: RubberDuck with a NoFlyBehavior.

> The clients inherits from an class that contains compositions to the interfaces that are represented by concrete behaviors. Example: Client > IBehavior > ConcreteBehaviorA, ConcreteBehaviorB
> 
> We can add the strategies via constructor of the client or exposing a method. Ex: > Duck - setFlyStrategy(IFlyStrategy f)
>  
>  We avoid the violation of SRP and OCP principles with the adoption of Strategy Pattern.
> 
> There is a relationship with State Pattern. However, the intents differ. Strategies are independent and unaware of each other (not jumping states, like State Pattern). Another difference is that Strategy refers to applying different implementations to achieve the same thing, while with State it's about doing different things, based on the state.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/Strategy.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/strategy2.png)

### Real-World Examples of Use

* A **PaymentService** that should be allowed to support multiple playment methods. In the *processOrder* method, instead of adding lots of *if statements* (breaking SRP and OCP), the PaymentService will act as a Context, with a composition to an interface PaymentStrategy. The client that will use the PaymentService will know what concrete strategy is going to use (PaymentByCreditCard, PaymentByPaypal), where each of these concrete payments implements the PaymentStrategy interface.

* **Transportation**: where we have multiple modes of transportation (taxi, personal car, app cars, bus). Any of these modes of transportation will get the traveler to the airport, but each of them will use a different **Strategy**.

* **Sorting**: we want to sor, but we don't know what algorithm we are using (BubbleSort, QuickSort, Merge Sort).

* **Validation**: we are using some rule, but it is not clear if they will be new ones to be implemented.

* **RPG**: a character has some capabilities (like walk), but we can add more during the game (flying).

* **Storing information**: we want to allow the client to story in different types of database, for example.

* **Output**: we need to support different outputs (CSV, XML, JSON).

* **Discount**: if we want to implement different discount strategies (NoDiscountStrategy, QuarterDiscountStrategy, BlackFridayDiscountStrategy).

* **Form**: design different forms, depending on the client (SimpleFormStrategy, ExtendedFormStrategy, CustomFormStrategy).

### Links

[Head First - Strategy Pattern Explained](https://www.youtube.com/watch?v=v9ejT8FO-7I&t=1s)

[A good video about Strategy Pattern](https://www.youtube.com/watch?v=Nrwj3gZiuJU
)

[Refactoring Guru](https://refactoring.guru/design-patterns/strategy)

[Source Making](https://sourcemaking.com/design_patterns/strategy)


## Observer Pattern

### Definition

> Defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.

> Moving from a poll (have you changed??) to a push approach (I've changed).
> 
> Observers register to Observable. When the Observable (Subject, Publisher) changes, the Observers (Subscribers) are Notified.
> 
> Subscription mechanism, where customers can choose when and based on what to be notified.
> 
> One Observable HAS many Observers. So, Observable contains a list of Observers.
> 
> Applying the OCP because you can introduce new Subscribers without having to change the Publisher's code.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/observer.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/observer2.png)

### Real-World Examples of Use

* **Notifications**: if you want all departments to be notified when the state of a dispatch changes.

* **Newsletter**: we want to be notified every time a product is added to the shop.

* **Status Updates**: in a social media, when someone updates her status, all her followers get the notification.

* **Display Events**: when some event is executed in an UI, other events must recognize and change accordingly (MVC Pattern).


### Links

[Head First - Observer Pattern Explained](https://www.youtube.com/watch?v=_BpmfnqjgzQ)

[A good video about Observer Pattern](https://www.youtube.com/watch?v=-oLDJ2dbadA&list=PLlsmxlJgn1HJpa28yHzkBmUY-Ty71ZUGc&index=12
)

[Refactoring Guru](https://refactoring.guru/design-patterns/observer)

[Source Making](https://sourcemaking.com/design_patterns/observer)



## Decorator Pattern

### Definition

> Attaches **additional responsibilities** to an object dynamically. Decorator provides a flexible alternative to subclassing by extending funcionality.
> 
> Composed by Components and Decorators (wrapper for a component). The Component is a wrapped class that defines the basic behavior, which can be altered by Decorators.
> 
> The Decorator IS-A Component and also HAS-A Component. Decorator behaves as a Component but also has a reference to another concrete Component (that can be another Decorator).
> 
> Using composition rather than inheritance.
> 
> Avoid class explosion by adding new behaviors (or combinations).
> 
> Enforcing OCP, where each class is isolated from the new extensions.
> 
> The additional responsibilities are defined by the Decorators.
> 
> If you have a concrete Decorator representing a cost, you will return the cost of it, in relation to the thing that is is decorating (the cost of another Decorator or Component).

> Composite and Decorator are related (both rely on recursive composition to organize objects). Decorator, however, has only one Coponent and adds additional responsibilities to the wrapped object, while Composite just "sums up" its children's results.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/decorator.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/decorator2.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/decorator3.png)

### Real-World Examples of Use

* **Notification**: if you want to add dynamically different combinations of notifications (via email, SMS, WhatApp, Facebook), you can define a BaseNotifierDecorator that implements INotifier interface (the Component), and wrap different concrete Decorators to be used (FacebookDecorator, WhatsAppDecorator, EmailDecorator).

* **Pizza**: where you can have a combination of pizza varieties, each of them with different and combined toppings (ToppingsDecorator).

* **Encryption System**: where you can add different types of encryption algorithms.

* **Text Editor**: you can format the same text in different ways (Bold, Italic, Underline, Color).


### Links

[Head First - Decorator Pattern Explained](https://www.youtube.com/watch?v=GCraGHx6gso)

[A good video about Decorator Pattern](https://www.youtube.com/watch?v=v6tpISNjHf8)

[Refactoring Guru](https://refactoring.guru/design-patterns/decorator)

[Source Making](https://sourcemaking.com/design_patterns/decorator)



## Factory Method Pattern

### Definition

> Defines an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. Factory method lets a class to defer instantiation to subclasses.

> Avoid class explosion (Composition over Inheritance).

> Avoid breaking the SRP and OCP principles (no switch cases in a class), defering the creation to subclasses.
 
> Separate the product construction code from the code that uses this product.
 
> The Simple Factory is the first step for devering the responsibility of creating objects to another class. However, it is still limited, in a way that we still have a switch case (in the Factory), as a single point of failure.
 
> Use it if you have no idea of the exact types of the objects your code will work with.
 
> You can extend the Product construction code inpdependently from the rest of the application.
 
> You can add new Products without breaking existing code.


### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/factorymethod.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/factorymethod2.png)

### Real-World Examples of Use

* **Game**: composed by levels, where you create many types of other objects (like asteroids - RandomAsteroidFactory).

* **Restaurant**: where you have different types of burgers, instead of have all the logic for deciding which type of burger will be created, you defer to specialized factories, present in subclasses, the logic for creating each type of burger.

* **Bank Account**: the same idea from before (PersonalAccount, BusinessAccount, CheckingAccount).


<p>&nbsp;</p>

### Links

[Head First - Factory Method Pattern Explained](https://www.youtube.com/watch?v=EcFVTgRHJLM)

[A good video about Factory Method Pattern](https://www.youtube.com/watch?v=EdFq_JIThqM)

[Refactoring Guru](https://refactoring.guru/design-patterns/factory-method)

[Source Making](https://sourcemaking.com/design_patterns/factory_method)

<p>&nbsp;</p>

## Abstract Factory Pattern

### Definition

> Provides an interface for creating **families of related or dependent objects** without specifying their concrete classes.

> Many designs start by using the Factory Method Pattern, evolving to an Abstract Factory Design.
> 
> Following the OCP and SRP, by allowing each concreate factory to be self-contained and independent on the construction of the product.
> 
> Every time we work under the assumption of **suite of products**, we can evaluate the use of this pattern.
> 
> Abstract Factory, Builder and Prototype are responsible for creating products. They serve for different intents, but they can be worked together with Abstract Factory.
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/abstractfactory.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/abstractfactory.png)

### Real-World Examples of Use

* **Platform-Independent UI**: when you generate UIs for different Operational Systems, the Abstract Factory will create a family of objects related to this specific OS.

* **Themes**: if you want to apply different theme modes (dark, light), you should change lots of related controls (button, label, list) following the color patterns that are necessary.

* **Laptop Factory**: if the client is considering buying a laptop from a specific brand (Dell, Apple), and it will create a variation of the same components a laptop have (processor, storage, screen, keyboard).


<p>&nbsp;</p>

### Links

[Head First - Abstract Factory Pattern Explained](https://www.youtube.com/watch?v=v-GiuMmsXj4)

[A good video about Abstract Factory Pattern](https://www.youtube.com/watch?v=QNpwWkdFvgQ)

[Refactoring Guru](https://refactoring.guru/design-patterns/abstract-factory)

[Source Making](https://sourcemaking.com/design_patterns/abstract_factory)

<p>&nbsp;</p>

## Singleton Pattern

### Definition

> Lets you ensure that a class has **only one instance** and provides a **global access point of access** to it (single point of access).

> It is considered an anti-pattern. Avoid globals is one of the motives.
> 
> Difficult to test because many test frameworks rely on inheritance when producing mock objects.
> 
> A private static singleton field will enforce the singleton instance. A private constructor + static method (getInstance) will be used to verify the present instance (and generating one). 
> 
> Breaks the SRP.
> 
> It requires special treatment in a multithreading environment so that multiple threads won't create a singleton object several times.
> 
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/singleton.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/singleton2.png)


### Real-World Examples of Use

* **Don't Use it**: although it is possible to implement the Singleton pattern in a thread-safe approach, the testability will be lost + the SRP is breaked by the use of this pattern.

* **Loggging**: an use of this pattern could be related to logging features, in a way that the log is accessed globally by the application and it can have just one instance active.

* **Database connection**: the same explanation of the previous item (logging). For both examples of use, don't forget to consider that in a multithreading environment you should control the threads to avoid multiple instances.

<p>&nbsp;</p>

### Links

[Head First - Abstract Factory Pattern Explained](https://www.youtube.com/watch?v=hUE_j6q0LTQ)

[A good video about Abstract Factory Pattern](https://www.youtube.com/watch?v=tSZn4wkBIu8)

[Refactoring Guru](https://refactoring.guru/design-patterns/singleton)

[Source Making](https://sourcemaking.com/design_patterns/singleton)

<p>&nbsp;</p>

## Command Pattern

### Definition

> Encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queues or log requests, and support **undoable operations**.

> The Command is injected into the Invoker (remote control). When the Invoker is called, we send the Command, that it will responsible for some action upon a Receiver (Lamp).
> 
> Avoid the enormous number of subclasses decreases the risk of breaking the code in any subclass everytime we modify the parent class.
> 
> Turns a specific method call into a stand-alone object.
> 
> You can passs commands at method arguments, storing them inside other objects, switching commands at runtime.
> 
> Commands can be serialized, making it easy to write it to an read it from a file.
> 
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/command.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/command2.png)

### Real-World Examples of Use

* **Remote Control**: where you can program specific commands for each button, making them configurable/changeable per button.

* **Button in Application**: adding actions for buttons (games, for example) without needing of creating multiple classes. Adding a Command interface and implementing SaveCommand, OpenCommand.


### Links

[Head First - Command Pattern Explained](https://www.youtube.com/watch?v=9qA5kw8dcSU)

[A good video about Command Pattern](https://www.youtube.com/watch?v=UfGD60BYzPM)

[Refactoring Guru](https://refactoring.guru/design-patterns/command)

[Source Making](https://sourcemaking.com/design_patterns/command)

<p>&nbsp;</p>

## Adapter Pattern

### Definition

> Converts the interface of a class into another interface the client expects. 
> 
> Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
> 
> Wrap an existing class with a new interface.
> 
> Adapter can be called Wrapper.
> 
> Through inheritance and composition, the Adapter creates a middle-layer class that serves as a translator.
> 
> Adapter is about making two incompatible interfaces compatible. Facade is about taking a bunch of complex interactions and create an object that can deal with it, Proxy is about creating a layer between something you want to call (security, caching), Decorator is a way of adding behavior for some object. 
> 
> SRP and OCP guaranteed.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/adapter.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/adapter2.png)

### Real-World Examples of Use

* **Integration**: the main use of Adapter Pattern is a client integrating/consuming interfaces, without the need of changing them. That means, when potentially in the future, the client has the opportunity to integrate with a different/newer version of the Adaptee, nothing will change (because we rely on the interface).

* **Customer Integration**: maybe you have to get data from a customer in a 3rd-party system. The Adapter provides a way to expose an interface, and the Adapter will be responsible to get and treat the information (from whatever it is), converting into the correct format the client needs.



### Links

[Head First - Adapter Pattern Explained](https://www.youtube.com/watch?v=2PKQtcJjYvc)

[A good video about Adapter Pattern](https://www.youtube.com/watch?v=wA3keqCeKtM)

[Refactoring Guru](https://refactoring.guru/design-patterns/adapter)

[Source Making](https://sourcemaking.com/design_patterns/adapter)

<p>&nbsp;</p>


## Facade Pattern

### Definition

> Provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
> 
> It provides a simplified interface while still exposing the full funcionality of the system to those who may need it.
> 
> The intent of **Adapter Pattern** is to alter an interface so that it matches one a client is expecting. The intent of Facade Pattern is to provide a simplified interface to a subsystem.
> 
> Principle of Least Knowledge (Law of Demeter): talk only to your immediate friends. Facade avoid the complexity affecting the client.
> 
> The drawback is that the Facade can aggregate much responsibility. It is called ***God Object***. We can create additional Facades to avoid it.
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/facade.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/facade2.png)

### Real-World Examples of Use

* **Video Converter**: you can implement a Facade with a method convertVideo(filename, format). It will, under the hood, integrate with lots of different processes for conversion (CodecFactory, AuxioMixer, MGEG4 Compression Coded, CompressionCodec).

* **Order**: when you purchase a product, they are lots of processes envolved (Get Product details, Make Payment, Send Invoice). When we create a Facade, we encapsulate in a method called PlaceOrder().

* **Generate Report**: you have multiple sources of data, coming from different databases, and you want to generate a report. You can use a HelperFacade that will integrate with them, where you pass the source of data - Oracle, MySQL and the data).


### Links

[Head First - Facade Pattern Explained](https://www.youtube.com/watch?v=K4FkHVO5iac)

[A good video about Facade Pattern](https://www.youtube.com/watch?v=xWk6jvqyhAQ)

[Refactoring Guru](https://refactoring.guru/design-patterns/facade)

[Source Making](https://sourcemaking.com/design_patterns/facade)

<p>&nbsp;</p>


## Template Method Pattern

### Definition

> Description.
> 
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/xx)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/xx.png)

### Real-World Examples of Use

* **Item**: desc.


### Links

[Head First - Template Method Pattern Explained]()

[A good video about Template Method Pattern]()

[Refactoring Guru](https://refactoring.guru/design-patterns/)

[Source Making](https://sourcemaking.com/design_patterns/)

<p>&nbsp;</p>

## Iterator Method Pattern

### Definition

> Description.
> 
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/xx)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/xx.png)

### Real-World Examples of Use

* **Item**: desc.


### Links

[Head First - Iterator Pattern Explained]()

[A good video about Iterator Pattern]()

[Refactoring Guru](https://refactoring.guru/design-patterns/)

[Source Making](https://sourcemaking.com/design_patterns/)

<p>&nbsp;</p>

## Composite Method Pattern

### Definition

> Description.
> 
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/xx)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/xx.png)

### Real-World Examples of Use

* **Item**: desc.


### Links

[Head First - Composite Pattern Explained]()

[A good video about Composite Pattern]()

[Refactoring Guru](https://refactoring.guru/design-patterns/)

[Source Making](https://sourcemaking.com/design_patterns/)

<p>&nbsp;</p>

## Books and Links

* [Head First Design Patterns - O'Reilly Media](https://learning.oreilly.com/library/view/head-first-design/0596007124/)
* [Refactoring.Guru](https://refactoring.guru/)
* [DoFactory](https://www.dofactory.com/net/design-patterns)
* [Source Making](https://sourcemaking.com/)
* [Clean Code - Design Patterns - Uncle Bob](https://cleancoders.com/episode/clean-code-episode-25)


