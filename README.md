
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

[DoFactory](https://www.dofactory.com/net/strategy-design-pattern)



## Observer Pattern

### Definition

> Defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.

> Moving from a poll (chave you changed??) to a push approach (I've changed).
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

[TutorialPoint](https://www.tutorialspoint.com/design_pattern/observer_pattern.htm
)


## Decorator Pattern

### Definition

> 

> 

### Model


### Real-World Examples of Use

* **ss**: ss

### Links


## Factory Method Pattern

### Definition

> 

> 

### Model


### Real-World Examples of Use

* **ss**: ss

### Links


## Abstract Factory Pattern

### Definition

> 

> 

### Model


### Real-World Examples of Use

* **ss**: ss

### Links

## Singleton Pattern

### Definition

> 

> 

### Model


### Real-World Examples of Use

* **ss**: ss

### Links

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


