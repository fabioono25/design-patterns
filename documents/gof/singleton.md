## Singleton Pattern

### Definition

The Singleton Pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to that instance. It is used to control object creation and restricts the instantiation of a class to a single object.

It is a relatively straightforward pattern to implement. It involves ensuring that a class has only one instance and providing a global point of access to that instance. This pattern is commonly used for managing resources that should have a single instance throughout the application.

&nbsp;

### Why this pattern

The Singleton Pattern was created to address the need for a single point of access to a specific instance of a class. It is particularly useful when a single instance of a class needs to coordinate actions across the system, such as managing a configuration or controlling access to a shared resource.

&nbsp;

### About

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

&nbsp;

### Model

![](https://github.com/fabioono25/design-patterns/blob/main/assets/singleton.png)

![](https://github.com/fabioono25/design-patterns/blob/main/assets/singleton2.png)

&nbsp;

### Advantages
- **Single Instance**: Guarantees that a class has only one instance throughout the application's lifecycle.
- **Global Access**: Provides a global point of access to the instance, allowing easy sharing of resources.
- **Lazy Initialization**: The instance is created only when it is first accessed, improving resource utilization.
- **Thread Safety**: Can be implemented to ensure thread-safe instance creation in multi-threaded environments.

&nbsp;

### Disadvantages
- **Global State**: The Singleton pattern introduces a global state, which can make the code harder to maintain and test.
- **Testing Challenges**: The global state can lead to difficulties in unit testing and mocking the Singleton instance.
- **Hidden Dependencies**: Classes using the Singleton may become tightly coupled to it, making code less modular.

&nbsp;

### Real-World Examples of Use

- **Database Connection Pool**: A Singleton can manage a pool of database connections, ensuring efficient resource utilization.
- **Logger**: A Singleton logger instance can be used across the application for consistent and centralized logging.
- **Configuration Manager**: Singleton can manage application configuration settings in a centralized manner.
- **Print Spooler**: In a print spooling system, a Singleton could manage print requests to a single printer instance.

&nbsp;

### Relationship with Other Patterns
- **Factory Method**: Singleton can be considered a specialization of the Factory Method pattern, where a factory creates only a single instance.
- **Facade**: A Singleton can act as a Facade to provide a simplified interface to a complex subsystem.
- **State**: The Singleton pattern is often used with the State pattern to manage the application's global state.

&nbsp;

### How to Replace This Pattern
- **Dependency Injection**: In some cases, Dependency Injection can be used to provide a single instance of a class when needed.
- **Static Methods/Fields**: Depending on the scenario, using static methods or fields can achieve similar results.

&nbsp;

### Examples of Implementation:
#### Simple Implementation [Not thread-safe]:

The following implementation is simple and not thread-safe. In a multi-threaded environment, multiple threads could access the Instance property simultaneously and create multiple instances.

```csharp
public sealed class SimpleSingleton
{
    private static SimpleSingleton instance;

    private SimpleSingleton() { }

    public static SimpleSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SimpleSingleton();
            }
            return instance;
        }
    }
}
```

&nbsp;

#### Thread-safe Implementation:

Example of a thread-safe implementation: it ensures thread safety using a locking mechanism. However, this can introduce performance overhead due to locking.

```csharp
public sealed class ThreadSafeSingleton
{
    private static readonly object lockObject = new object();
    private static ThreadSafeSingleton instance;

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ThreadSafeSingleton();
                }
            }
            return instance;
        }
    }
}
```

&nbsp;

#### Double-Checked Locking (pre C# 6.0):

The Double-Checked Locking (DCL) pattern in C# has some issues related to memory model and compiler optimizations that can make it potentially unsafe when not implemented correctly. Prior to C# 6, there were concerns about how the compiler and the runtime might reorder instructions, leading to potential race conditions and incorrect behavior:

```csharp
public sealed class DoubleCheckedLockingSingleton
{
    private static DoubleCheckedLockingSingleton instance;
    private static readonly object lockObject = new object();

    private DoubleCheckedLockingSingleton() { }

    public static DoubleCheckedLockingSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new DoubleCheckedLockingSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
```

&nbsp;

#### Double-Checled Locking (after C# 6.0):

In C# 6 and later versions, the introduction of the volatile keyword and improvements in the memory model help to mitigate some of these issues. The volatile keyword indicates that a field should not be cached by processors, ensuring that reads and writes to the field always go to the main memory, rather than relying on cached values. This helps in ensuring proper synchronization and visibility of the singleton instance across multiple threads.

Here's an example of using the volatile keyword in a Double-Checked Locking implementation:

```csharp
public sealed class ThreadSafeSingleton
{
    private static volatile ThreadSafeSingleton instance;
    private static readonly object lockObject = new object();

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
```
By marking the instance variable as volatile, you ensure that reads and writes to the variable are not optimized or reordered, helping to prevent potential issues that were present in earlier versions of C#.

It's important to note that while the use of volatile helps address some of the issues with the DCL pattern, it may not completely eliminate all potential problems in all scenarios. Additionally, starting with C# 7.0, the Lazy<T> class is recommended for achieving safe and efficient lazy initialization in singleton patterns, as shown in the previous example labeled "Lazy Initialization." This approach is simpler and less error-prone than managing the synchronization manually.

&nbsp;

#### Lazy Initialization:

This approach provides lazy initialization using the 'Lazy<T>' class, ensuring thread safety and efficient resource utilization:

```csharp
public sealed class LazySingleton
{
    private static readonly Lazy<LazySingleton> lazyInstance = new Lazy<LazySingleton>(() => new LazySingleton());

    private LazySingleton() { }

    public static LazySingleton Instance => lazyInstance.Value;
}

```

&nbsp;

#### Monostate Pattern (Shared State):

Provides a gloal state while avoiding some of the complexities of a traditional Singleton pattern. However, it doesn't prevent multiple instances:

```csharp
public class MonostateSingleton
{
    private static string data;

    public string Data
    {
        get => data;
        set => data = value;
    }
}
```

&nbsp;

#### Singleton Anti-Pattern:

The following example creates an instance during construction, defeating the purpose of Singleton. It can lead to unexpected behavior and violates the intended design:

```csharp
public sealed class SingletonAntiPattern
{
    private static SingletonAntiPattern instance;

    private SingletonAntiPattern()
    {
        instance = new SingletonAntiPattern(); // Creates an instance on construction!
    }

    public static SingletonAntiPattern Instance => instance;
}
```

<p>&nbsp;</p>

### Links

[Head First - Abstract Factory Pattern Explained](https://www.youtube.com/watch?v=hUE_j6q0LTQ)

[A good video about Abstract Factory Pattern](https://www.youtube.com/watch?v=tSZn4wkBIu8)

[Refactoring Guru](https://refactoring.guru/design-patterns/singleton)

[Source Making](https://sourcemaking.com/design_patterns/singleton)