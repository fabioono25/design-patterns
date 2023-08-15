
# Design Patterns

The idea is to organize all design patterns (GoF and no GoF) in a series of definitions and examples.


## Design Principles

> Identify the aspects of your application that vary and separate them from what stays the same.

> Program to an interface, not an implementation.

> Favor composition over inheritance.


## GoF Pattern Categories

The patterns are grouped into categories, based on their purposes:

- **Creational Patterns:** involve object instantiation and provide a way to decouple a cliente from the objects it needs to instantiate.

- **Behavioral Patterns:** how classes and objects interact and distribute responsibility.

- **Structural Patterns:** let you composte classes or objects into larger structures. 


Another classification is wheter the pattern deals with classes or objects:

- **Class Patterns:** describes how relationships between classes are defined via inheritance. Stablished at compile time.

- **Object Patterns:** relationship between objects primarily defined by composition. Created typically at runtime (more flexible and dynamic). 


## Creational Design Patterns

- [Singleton](https://github.com/fabioono25/design-patterns/blob/main/documents/singleton.md): The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. It is useful when you want to restric the instantiation of a class to a single object, such as a configuration manager or logging service.

- [Factory Method](https://github.com/fabioono25/design-patterns/blob/main/documents/factory-method.md): The Factory Method pattern defines an interface for creating objects but allows subclasses to decide which class to instantiate. This pattern is useful when you have a class with multiple subclasses and want to delegate the responsibility of object creation to the subclasses.

- [Abstract Factory](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Creational/AbstractFactory/abstractfactory.md): The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. It's useful when you need to create families of objects that should be used together, like creating different components of a GUI toolkit.

- [Builder](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Creational/Builder/builder.md): The Builder pattern separates the construction of a complex object from its representation. It allows the same construction process to create different representations of the object. This pattern is useful when you want to create complex objects step by step, providing flexibility in the construction process.

- [Prototype](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Creational/Prototype/prototype.md): The Prototype pattern involves creating a new object by copying an existing object (prototype) rather than creating a new instance from scratch. It's useful when the cost of creating a new object is higher, and you want to achieve performance improvements by copying existing instances.

&nbsp;
&nbsp;

## Behavioral Design Patterns

- [Chain of Responsibility](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/ChainOfResponsibility/chainofresponsibility.md): Le

- [Command](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/Command/command.md): Le

- [Iterator](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/Iterator/iterator.md): Le

- [Mediator](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/Mediator/mediator.md): Le

- [Memento](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/Memento/memento.md): Le

- [Observer](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/Observer/observer.md): Le

- [State](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/State/state.md): Lets an object alter its behavior when its **internal state** changes. This pattern is close to the concept of **finite-state machine**.

- [Strategy](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/Strategy/strategy.md): Lets you define a **family of algorithms**, put each of them into **separate class**, and make **their objects interchangeable**.

- [Template Method](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/TemplateMethod/templatemethod.md): L

- [Visitor](https://github.com/fabioono25/design-patterns/blob/main/design-patterns/GangOfFour/Behavioral/Visitor/visitor.md): L

&nbsp;
&nbsp;

## Structural Design Patterns

- [Adapter](): .

- [Bridge]()

- [Composite]()

- [Decorator]()

- [Facade]()

- [Flyweight]()

- [Proxy]()

&nbsp;
&nbsp;

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

> defines the sekeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.
> 
> The reuse among subclasses is improved using Template Method Pattern.
> 
> A hook may provide a way for a subclass to implement an optional part of an algorithm, or if it isn’t important to the subclass’s implementation, it can skip it.
> 
> The Hollywood Principle: Don't call us, we'll call you. A high-level component controls when and how low-level components can participate in the computation. A low-level component never calls a high-level component directly. Factory and Observer use this principle.
> 
> Template Method define an algorithm, letting subclasses do some of the work. It can have different implementations, keeping control over the algorithm's structure. Strategy, on the other way, rely on composition rather than inheritance to provide algorithms to be interchangeable (more flexible, using more objects, and slower).
> 
> Factory Method is a specialization of Template Method.
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/templatemethod.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/templatemethod2.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/hollywoodprinciple.png)

### Real-World Examples of Use

* **Frameworks**: the Template Method pattern is a great tool for creating frameworks, where the framework controls how something is done, letting you to specify some details during the process that can be **customized**.

* **Generating Reports**: suppose you must implement a routine for expense reports. The steps are similar (connect with the data source, execute query, convert to the asked format). However, if you have a connection with MySQL vs XML file, the execution will vary between them.

* **Game**: startup of the came follow the same patterns to load in general (since loading files, until cleaning temporary ones).


### Links

[Head First - Template Method Pattern Explained](https://www.youtube.com/watch?v=7ocpwK9uesw)

[A good video about Template Method Pattern](https://www.youtube.com/watch?v=cGoVDzHvD4A)

[Refactoring Guru](https://refactoring.guru/design-patterns/template-method)

[Source Making](https://sourcemaking.com/design_patterns/template_method)

<p>&nbsp;</p>

## Iterator Method Pattern

### Definition

> Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation (list, stack, queue, tree, ...).
> 
> The Iterator allows traversal of the elements of an aggregate without exposing the underlying implementation.
> 
> The iterator object is responsible for traversing (not the aggregate), which simplifies the aggregate interface and implementation, and places the responsibility where it should be.
> 
> SRP and OCP enforced: new kinds of self-contained new types of collections of iterators can be added without breaking anything.
> 
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/iterator.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/iterator2.png)

### Real-World Examples of Use

* **Game**: when you can enumerate and aggregate the objects of game that are composed internally by different data structures that manage collections of items (characters, items, maps, phases).

* **Inventory**: managing the different objects and collections of objects can be implemented using Iterator.

* **Collections**: in a general way, managing different collections and aggregate them will be possible with Iterator. You create a layer that will abstract the physical structures each collection is defined.


### Links

[Head First - Iterator Pattern Explained](https://www.youtube.com/watch?v=uNTNEfwYXhI)

[A good video about Iterator Pattern](https://www.youtube.com/watch?v=QCWJWfuAfJc)

[Refactoring Guru](https://refactoring.guru/design-patterns/iterator)

[Source Making](https://sourcemaking.com/design_patterns/iterator)

<p>&nbsp;</p>

## Composite Pattern

### Definition

> Allows you to compose objects into tree structures to represent part-whole hierarchies.
> 
> Composite lets clients treat individual objects and compositions of objects uniformly.
> 
> The idea is to build structures of objects in the form of trees that contain both compositions of objects and individual 
> 
> Composite pattern makes sense only when objects structures can be represented as a tree.
> 
> OCP applied, where you can introduce a new element types into the application without breaking the existing code.
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/composite.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/composite2.png)

### Real-World Examples of Use

* **Family Tree**: describe a family tree structure, where each node is composed by none or multiple composite nodes. The potential is to traversing the tree asking for an information (name, for example).

* **ToDo Application**: when you have a TODO list each of them can be composed by sublists of TODOs.

* **File Directory**: where you can implement the File as the Composite interface, letting TextFile and Directory implement this interface. You can realize that Directory has multiple files inside it (and without Composition this operation would break the OCP principle).


### Links

[Head First - Composite Pattern Explained](https://www.youtube.com/watch?v=EWDmWbJ4wRA)

[A good video about Composite Pattern](https://www.youtube.com/watch?v=oo9AsGqnisk)

[Refactoring Guru](https://refactoring.guru/design-patterns/composite)

[Source Making](https://sourcemaking.com/design_patterns/composite)

<p>&nbsp;</p>

## Proxy Pattern

### Definition

> Provides a surrogate or placeholder for another object to control access to it.
> 
> A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.
>
> Remote Proxy: access resources that are remote.
> 
> Virtual Proxy: controls access to a resource that it is expensive to create (cache).
> 
> Protection Proxy: it controls access to resources based on access rights.
> 
> Interact with another entity, without changing its interface.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/proxy.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/proxy2.png)

### Real-World Examples of Use

* **Lazy initialization**: when you have a heavyweight service object that wastes system resources by being always up, even though you only need it from time to time. You can implement Virtual Proxy to tackle this scenario.

* **Access control**: when you want only specific clients to be able to use the service object; for instance, when your objects are crucial parts of an operating system and clients are various launched applications (including malicious ones). Use Protection Proxy for this scenario.

* **Remote Service Call**: the proxy is located on a remote server and passes the client request over the network, handling all of the nasty details of working with the network.

* **History of Requests**: the proxy can log each request before passing it to the service.


### Links

[Head First - State Pattern Explained](https://www.youtube.com/watch?v=NwaabHqPHeM)

[A good video about State Pattern](https://www.youtube.com/watch?v=TS5i-uPXLs8)

[Refactoring Guru](https://refactoring.guru/design-patterns/proxy)

[Source Making](https://sourcemaking.com/design_patterns/proxy)

<p>&nbsp;</p>


## Bridge Pattern

### Definition

> Allows you to vary the implementation and the abstraction by placing the two in separate class hierarchies.
> 
> Lets you to split a large class or a set of closely related classes into two separate hierarchies (abstraction and implementation) which can be developed independently of each other.
> 
> Decouples an abstraction from its implementation so that the two can vary independently.
> 
> Abstraction and implementation can be extended independently.
> 
> Changes to the concrete abstraction classes don’t affect the client.
> 
> Adapter makes things work after they are designed. Bridge makes them work before they are.


### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/bridge.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/bridge2.png)

### Real-World Examples of Use

* **Graphics and Windowing systems**: that need to run over multiple platforms.

* **Send Message**: you have a scenario where you want to send a message (abstraction, or hight-level control layer) but you have two ways to do that, by Email or SMS (implementation, or low-level control layer). You can use abstract pattern to solve this problem.



### Links

[Head First - Bridge Pattern Explained](https://www.youtube.com/watch?v=F1YQ7YRjttI)

[A good video about Bridge Pattern](https://www.youtube.com/watch?v=88kAIisOiYs)

[Refactoring Guru](https://refactoring.guru/design-patterns/bridge)

[Source Making](https://sourcemaking.com/design_patterns/bridge)

<p>&nbsp;</p>

## Builder Pattern

### Definition

> Encapsulate the construction of a product (a complext object) and allow it to be constructed in steps.
> 
> The construction is multistep and varying process (different from one-step factories).
> 
> Hides the internal representation of the product from the client.
> 
> Product implementation can be swapped in and out because the client only sees an abstract interface.
> 
> Minimize the problem of using multiple parameters to construct a complex object, letting the construction to be executed in steps.
> 
> Method Chaining is used to invoke multiple methods on the same object which occurs as a single statement. Method-chaining is implemented by a series of methods that return the this reference for a class instance.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/builder.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/builder2.png)

### Real-World Examples of Use

* **Car and Manual**: the construction of a Car must be followed by its manual. You can have a Builder interface the abstracts each of the components, both of them being created as part of the car or the manual.

* **Different Representations**: use this pattern to create different representations of some product, as the example before. Another example: stone vs wooden houses.

* **Personal Information**: consider a place where you should add personal information, in a way that some of them are mandatory (like name) others not. Instead of implementing n method overloadings or with default parameters, you can consider using Builder pattern to provice concise, simple methods (addAge, addGender, addCity).
 

### Links

[A good video about Builder Pattern](https://www.youtube.com/watch?v=MaY_MDdWkQw)

[Refactoring Guru](https://refactoring.guru/design-patterns/builder)

[Source Making](https://sourcemaking.com/design_patterns/builder)

<p>&nbsp;</p>


## Chain of Responsibility Pattern

### Definition

> When you want to give more than one object a chance to handle a request.
> 
> With the Chain of Responsibility Pattern, you create a chain of objects to examine requests. Each object in turn examines a request and either handles it or passes it on to the next object in the chain.
> 
> Decouples the sender of the request and its receivers.
> 
> Simplifies your object: no need to know the chain's structure and keep direct references to its members.
> 
> Adding responsibilities dynamically (by changing the members or order of the chain).
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/chain_of_responsibility.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/chain_of_responsibility2.png)

### Real-World Examples of Use

* **Windows Systems**: handle events like mouse clicks and keyboard events.

* **Authentication System**: where they are lots of steps that must be performed regarding validation of an user in a system (Authentication, Authorization, Validation, Caching), during an order processing, for example.

* **Operators**: operators receiveing your call and handling the request to another operator, until you reach the last one.

### Links

[A good video about Chain of Responsibility Pattern](https://www.youtube.com/watch?v=FafNcoBvVQo)

[Refactoring Guru](https://refactoring.guru/design-patterns/chain-of-responsibility)

[Source Making](https://sourcemaking.com/design_patterns/chain_of_responsibility)

<p>&nbsp;</p>


## Flyweight Pattern

### Definition

> When one instance of a class can be used to provide many virtual instances.
> 
> Lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.
> 
> Reduces the number of objects instances at runtime, saving memory.
> 
> Centralizes state for many "virtual" objects into a single location.
> 
> A drawback of the Flyweight Pattern is that once you’ve implemented it, single, logical instances of the class will not be able to behave independently from the other instances.
> 
> Since the same flyweight object can be used in different contexts, you have to make sure that its state can’t be modified. A flyweight should initialize its state just once, via constructor parameters. It shouldn’t expose any setters or public fields to other objects.


### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/flyweight)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/flyweight2.png)

### Real-World Examples of Use

* **Game**: where you have parts of the game (ex: Particle) where you can divide individual parts (like coordinates) and sharing others into a specific object (color).

* **Browser Rendering**: when a browser render images for example, it is possible loading the image once, and all other times the browser can reuse the image (caching).


### Links

[A good video about Flyweight Pattern](https://www.youtube.com/watch?v=qscOsQV-K14)

[Refactoring Guru](https://refactoring.guru/design-patterns/flyweight)

[Source Making](https://sourcemaking.com/design_patterns/flyweight)

<p>&nbsp;</p>


## Interpreter Pattern

### Definition

> Use the Interpreter Pattern to build an interpreter for a language.
> 
> Given a language, the Interpreter design pattern defines a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
> 
> It is a normally ignored pattern, and almost never used.
> 
> Representing each grammar rule in a class makes the language easy to implement. 
> 
> Because the grammar is represented by classes, you can easily change or extend the language.
> 
> Nearly every use of the Composite pattern will also contain the Interpreter pattern. But the Interpreter pattern should be reserved for those cases in which you want to think of this class hierarchy as defining a language.



### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/interpreter.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/interpreter2.png)

### Real-World Examples of Use

* **Conversion tool**: it can be implemented using Interpreter Pattern.

* **Data Conversion**: it can be implemented using Interpreter Pattern.


### Links

[A good video about Interpreter Pattern](https://www.youtube.com/watch?v=6CVymSJQuJE&list=PLfZqJwaRZ_4Ns7yoUbD3i-mbASju8mIjW)

[DoFactory](https://www.dofactory.com/net/interpreter-design-pattern)

[Source Making](https://sourcemaking.com/design_patterns/interpreter)

<p>&nbsp;</p>


## Mediator Pattern

### Definition

> Use Mediator to centralize complex communications and control between related objects.
> 
> Lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.
> 
> Simplifies maintenance of the system by centralizing control logic.
> 
> Simplifies and reduces the variety of messages sent between objects in the system.
> 
> Without proper design, the Mediator object itself can become overly complex.
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/mediator.png)

### Real-World Examples of Use

* **GUI components**: Mediator is commonly used to coordinate GUI components.

* **Social Media Groups**: RegisterUser and SendMessage can be implemented using Mediator.

* **Air Traffic Control**: mediator ATC will act as the central point where all flights communication.


### Links

[A good video about Mediator Pattern](https://www.youtube.com/watch?v=35D5cBosD4c)

[Refactoring Guru](https://refactoring.guru/design-patterns/mediator)

[Source Making](https://sourcemaking.com/design_patterns/mediator)

<p>&nbsp;</p>


## Memento Pattern

### Definition

> Delegates creating the state snapshots to the actual owner of that state. Hence, the original class can make the snapshots since it has full access to its own state.
> 
> lets you save and restore the previous state of an object without revealing the details of its implementation.
> 
> Keeping the saved state external from the key object helps to maintain cohesion.
> 
> Keeps the object's data encapsulated.
> 
> Provides easy-to-implement recovery capability.
> 
> Full copies of an object's state.
> 

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/memento.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/memento2.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/memento3.png)

### Real-World Examples of Use

* **Text Editor**: any text change is stored as a state. It allows the undo of some operation, without the need to expose the base object's properties. The Memento pattern lets you make full copies of an object’s state, including private fields, and store them separately from the object. 


### Links

[A good video about memento Pattern](https://www.youtube.com/watch?v=_Q5rXfGuyLQ&t=43s)

[Refactoring Guru](https://refactoring.guru/design-patterns/memento)

[Source Making](https://sourcemaking.com/design_patterns/memento)

<p>&nbsp;</p>


## Prototype Pattern

### Definition

> Lets you copy existing objects without making your code dependent on their classes.
> 
> Use Prototype Pattern when creating an instance of a given class is either expensive or complicated.
> 
> Hides the complexity of making new instances from the client.
> 
> Provides the option for the client to generate objects whose type is not known.
> 
> Is some circumstances, copying an object can be more efficient than creating an object.
> 
> Copying an object can be sometimes complicated.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/prototype.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/prototype2.png)

### Real-World Examples of Use

* **GUI Application Framework**: using Prototype will provide a way to create application-specific objects. Who uses the framework will pass a prototypical instance of the button class. The button can return a clone when clicked, with all necessary customizations on the clone.


### Links

[A good video about Prototype Pattern](https://www.youtube.com/watch?v=DcFhITC9v0E)

[Refactoring Guru](https://refactoring.guru/design-patterns/prototype)

[Source Making](https://sourcemaking.com/design_patterns/prototype)

<p>&nbsp;</p>


## Visitor Pattern

### Definition

> When you want to add capabilities to a composite of objects and encapsulation is not important.
> 
> Lets you separate algorithms from the objects on which they operate.
> 
> Allows you to add operations to a Composite structure without changing the structure itself.
> 
> The code for operations performed by the Visitor is centralized.
> 
> The Composite classes’ encapsulation is broken when the Visitor is used.
> 
> Because the traversal function is involved, changes to the Composite structure are more difficult.

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/visitor.png)


### Real-World Examples of Use

* **Supermarket**: where the shopping cart is your set of elements. When you get to the checkout, the cashier acts as a visitor, taking the disparate set of elements (your shopping), some with prices and others that need to be weighed, in order to provide you with a total.

* **Taxi**: where the customer calls orders a taxi, which arrives at his door. Once the person sits in, the visiting taxi is in control of the transport for that person. 


### Links

[A good video about Visitor Pattern](https://www.youtube.com/watch?v=UQP5XqMqtqQ)

[Refactoring Guru](https://refactoring.guru/design-patterns/visitor)

[Source Making](https://sourcemaking.com/design_patterns/visitor)

<p>&nbsp;</p>


# Notes (TODO):

- Separate the Pattern in categories (Structural, Behavioral and Creational).
- Implement the examples from Geekific
- Add the step by step for implementing each pattern in the documentation.

