
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

> 

> 

### Model


### Real-World Examples of Use

* **ss**: ss

<p>&nbsp;</p>

### Links

[Head First - Abstract Factory Pattern Explained](https://www.youtube.com/watch?v=hUE_j6q0LTQ)

[A good video about Abstract Factory Pattern](https://www.youtube.com/watch?v=tSZn4wkBIu8)

[Refactoring Guru](https://refactoring.guru/design-patterns/singleton)

[Source Making](https://sourcemaking.com/design_patterns/singleton)

<p>&nbsp;</p>

## Command Pattern

### Definition

> 

> 

### Model


### Real-World Examples of Use

* **ss**: ss

### Links

## Adapter Pattern

## Simple Factory Pattern

## Books and Links

* [Head First Design Patterns - O'Reilly Media](https://learning.oreilly.com/library/view/head-first-design/0596007124/)
* [Refactoring.Guru](https://refactoring.guru/)
* [DoFactory](https://www.dofactory.com/net/design-patterns)
* [Source Making](https://sourcemaking.com/)
* [Clean Code - Design Patterns - Uncle Bob](https://cleancoders.com/episode/clean-code-episode-25)


