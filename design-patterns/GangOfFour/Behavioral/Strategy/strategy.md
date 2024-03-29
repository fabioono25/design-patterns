## Strategy Pattern

### Definition

> Defines a **family of algorithms**, encapsulate each one in separated classes, and makes them **interchangeable** (Plug-and-play). 

> Strategy lets the algorithm **vary independently** from the clients that use it (decoupling them).

> Use composition rather than inheritance.

> Strategies are easily replaceable and interchangeable by clients at runtime.

> Focus on behaviors and how they vary, and compose them to be used by one or multiple family of classes (clients). Example: RubberDuck with a NoFlyBehavior.

> The clients inherits from an class that contains compositions to the interfaces that are represented by concrete behaviors. Example: Client > IBehavior > ConcreteBehaviorA, ConcreteBehaviorB
 
> We can add the strategies via constructor of the client or exposing a method. Ex: > Duck - setFlyStrategy(IFlyStrategy f)
  
>  We avoid the violation of SRP and OCP principles with the adoption of Strategy Pattern.
 
> There is a relationship with *State Pattern*. However, the intents differ. Strategies are *independent* and unaware of each other (not jumping states, like State Pattern). Another difference is that Strategy refers to applying *different implementations to achieve the same thing*, while with State it's about doing different things, based on the state.

> With Strategy, we do something specific in a lot of different ways (using separated classes called strategies).

### When to Use


### Components

- *Context:* Contains a field for storing a reference to one of the strategies (their interface). It is abstract, containing methods to set the strategy at runtime (or via constructor) + a method to execute the action (that will be executed by the concrete strategy).

- *Client:* Will be responsible to pass the desired strategy to the context.

- *Strategy Interface:* declare operations common to all supported by the concrete strategies.

- *Concrete Strategies:* implement the method defined in this interace in its own way.

&nbsp;

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/Strategy.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/strategy2.png)

### Real-World Examples of Use

* **Route Planning**: the Navigator has the method buildRounte(A, B) based on cars. For each new type way to go from A to B (walking, bus, cycling), we should add more responsibility for the same class, and make the system britle. The objective is the same (construct route from A to B), however, the way that this objective is achieved vary from each class. 

![](https://github.com/fabioono25/design-patterns/blob/main/assets/route.png)

* **PaymentService**: it should be allowed to support multiple playment methods. In the *processOrder* method, instead of adding lots of *if statements* (breaking SRP and OCP), the PaymentService will act as a Context, with a composition to an interface PaymentStrategy. The client that will use the PaymentService will know what concrete strategy is going to use (PaymentByCreditCard, PaymentByPaypal), where each of these concrete payments implements the PaymentStrategy interface.



* **Transportation**: where we have multiple modes of transportation (taxi, personal car, app cars, bus). Any of these modes of transportation will get the traveler to the airport, but each of them will use a different **Strategy**.

* **Sorting**: we want to sor, but we don't know what algorithm we are using (BubbleSort, QuickSort, Merge Sort).

* **Validation**: we are using some rule, but it is not clear if they will be new ones to be implemented.

* **RPG**: a character has some capabilities (like walk), but we can add more during the game (flying).

* **Storing information**: we want to allow the client to story in different types of database, for example.

* **Output**: we need to support different outputs (CSV, XML, JSON).

* **Discount**: if we want to implement different discount strategies (NoDiscountStrategy, QuarterDiscountStrategy, BlackFridayDiscountStrategy).

* **Form**: design different forms, depending on the client (SimpleFormStrategy, ExtendedFormStrategy, CustomFormStrategy).

### Advantages

### Disadvantages

### Links

[Head First - Strategy Pattern Explained](https://www.youtube.com/watch?v=v9ejT8FO-7I&t=1s)

[A good video about Strategy Pattern](https://www.youtube.com/watch?v=Nrwj3gZiuJU)

[Refactoring Guru](https://refactoring.guru/design-patterns/strategy)

[Source Making](https://sourcemaking.com/design_patterns/strategy)

