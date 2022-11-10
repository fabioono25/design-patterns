## Strategy Pattern

### Definition

> Lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.
> 
> Finite-State Machine concept applied, where there is a finite number of states which a program can be in. The state behaves different by state and can be switched from one state to another instantaneously (depending on the switching rules).
> 
> State-specific code should be extracted to a set of distinct classes (SRP), reducing the maintenance cost.
> 
> **Strategy Pattern** went on create a business around interchangeable algorithms (as an alternative to sublcassing), **Template Method Pattern** is about sublasses decide how to implement steps in an algorithm, while **State Pattern** help objects to control their behavior by changing their internal state (putting out conditionals).
> 
> Careful not using this pattern when a state machine has only a few steps or rarely changes.


### When to Use


### Components

- *:* 

&nbsp;

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/state.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/state2.png)


### Real-World Examples of Use

* **State Machines**: the real-world cases related to changing of states and distinct behaviors based on each state can be applied using State Pattern.

* **Traffic Signalling System**: where you have different states to control each traffic light. Remember that the transitions can have rules of trainsition applied (red to green, green to yellow, yellow to red).

* **Vending Machine**: where you should change the state (money inserted state, operation canceled state, product not available state, sold state).

* **Document Manager**: a document can be in different states (draft, in review, approved, rejected).

### Advantages

### Disadvantages

### Links

[Head First - State Pattern Explained](https://www.youtube.com/watch?v=N12L5D78MAA)

[A good video about State Pattern](https://www.youtube.com/watch?v=abX4xzaAsoc)

[Refactoring Guru](https://refactoring.guru/design-patterns/state)

[Source Making](https://sourcemaking.com/design_patterns/state)

