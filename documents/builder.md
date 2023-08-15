## Builder Pattern

### Definition

The Builder Pattern is a creational design pattern that separates the construction of a complex object from its representation, allowing the same construction process to create different representations. It provides an elegant way to construct complex objects step by step, providing finer control over the creation process and resulting objects.

The pattern is particularly useful when dealing with objects that have many optional components or configurations.

&nbsp;

### Why This Pattern

The Builder Pattern was created to address the challenges of constructing complex objects with multiple components or configurations. It allows the creation process to be separate from the final object's structure, enhancing code readability, maintainability, and flexibility.

&nbsp;

### About

> Separates the construction of a complex object from its representation.

> Provides a step-by-step approach to construct an object.

> Enhances code readability and maintainability by isolating the construction logic.

> Allows the same construction process to create different representations of an object.

&nbsp;

### Model

![Builder Pattern](https://github.com/fabioono25/design-patterns/blob/main/assets/builder.png)

&nbsp;

### Advantages

- **Step-by-Step Construction**: Allows for step-by-step construction of complex objects, providing fine-grained control over each aspect.
- **Code Readability**: Isolates the construction logic, improving the clarity and maintainability of the code.
- **Flexible Object Creation**: Enables the same construction process to create different representations of the object.
- **Variability**: Supports creating variations of the same type of object using different builders.

&nbsp;

### Disadvantages

- **Increased Code Complexity**: Introduces additional classes and interfaces, potentially increasing the overall complexity of the codebase.
- **Performance Overhead**: The pattern may introduce some performance overhead due to the creation of additional objects and method calls.

&nbsp;

### Real-World Examples of Use

- **Document Building**: Constructing documents with varying structures and components, such as headers, paragraphs, and images.
- **Meal Ordering System**: Building customized meals with different components, like main courses, side dishes, and beverages.
- **Vehicle Manufacturing**: Assembling vehicles with various features, including engines, tires, interiors, and accessories.

&nbsp;

### Relationship with Other Patterns

- **Abstract Factory**: Both patterns involve creating complex objects, but the Builder pattern focuses on constructing a single object, while the Abstract Factory focuses on families of related objects.

&nbsp;

### How to Replace This Pattern

- **Direct Construction**: In simpler cases with fewer components or configurations, direct object construction might be sufficient.
- **Parameterized Constructor**: For objects with a limited number of configuration options, using a parameterized constructor could be an alternative.

&nbsp;

### Examples of Implementation

#### Simple Implementation

The following example demonstrates a simple implementation of the Builder pattern:

```csharp
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}

public class ConcreteBuilder : IBuilder
{
    private Product product = new Product();

    public void BuildPartA()
    {
        product.Add("Part A");
    }

    public void BuildPartB()
    {
        product.Add("Part B");
    }

    public void BuildPartC()
    {
        product.Add("Part C");
    }

    public Product GetResult()
    {
        return product;
    }
}

public class Product
{
    private List<string> parts = new List<string>();

    public void Add(string part)
    {
        parts.Add(part);
    }

    public string GetPartsList()
    {
        return string.Join(", ", parts);
    }
}

<p>&nbsp;</p>

### Links