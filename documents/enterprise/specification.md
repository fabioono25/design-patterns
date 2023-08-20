## Specification Pattern

### Definition

The Specification Pattern is a behavioral design pattern that provides a mechanism for **encapsulating criteria in objects**. It allows clients to filter and match objects based on specified conditions while promoting maintainability and reusability by separating the filtering logic from the rest of the application.

By defining a set of criteria as specifications, this pattern enables dynamic composition of complex filtering conditions.

&nbsp;

### Why This Pattern

The Specification Pattern addresses the need to **filter and match** objects based on various criteria in a clean and reusable manner. It helps maintain separation of concerns and allows the application to define and apply complex filtering logic without tightly coupling it to the business logic.

&nbsp;

### About

> Encapsulates filtering criteria in objects to enable dynamic composition.

> Promotes separation of concerns by isolating filtering logic.

> Enhances maintainability and reusability of filtering conditions.

> Commonly used in scenarios involving data retrieval, querying, and rule evaluations.

> Enables clients to filter and match objects based on criteria defined in specifications.

&nbsp;

### Model

![Specification Pattern](https://github.com/fabioono25/design-patterns/blob/main/assets/specification1.png)

&nbsp;

### Advantages

- **Modular Filtering Logic**: Encapsulating filtering logic in specifications allows for easy composition of complex conditions.
- **Separation of Concerns**: Separates the responsibility of filtering from other application logic, promoting a more organized codebase.
- **Reusability**: Specifications can be reused across different parts of the application or in different scenarios.
- **Maintenance**: Changes to filtering criteria can be made in a centralized manner without affecting other parts of the code.

&nbsp;

### Disadvantages

- **Complexity**: Can introduce additional complexity compared to simple filtering conditions directly applied in code.
- **Learning Curve**: Developers might need some time to understand the pattern and its benefits.

&nbsp;

### Real-World Examples of Use

- **E-commerce Platforms**: Specifications can be used to filter products based on various attributes like price, category, availability, etc.
- **Employee Management Systems**: Filtering employees based on attributes like department, role, or performance metrics.
- **Content Management Systems**: Filtering content items based on tags, publication dates, or user ratings.

&nbsp;

### Relationship with Other Patterns

- **Composite Pattern**: Composite specifications allow combining simpler specifications to create more complex filtering conditions.
- **Strategy Pattern**: Specifications can be seen as strategies for filtering objects based on certain criteria.

&nbsp;

### How to Replace This Pattern

- **Direct Filtering Logic**: For simple cases, direct application of filtering conditions might be sufficient.
- **Hardcoding Criteria**: In some scenarios, criteria might be hardcoded directly into the code, but this approach lacks flexibility and reusability.

&nbsp;

### Examples of Implementation

#### Simple Implementation

In this example, the Specification interface defines a method IsSatisfiedBy that concrete specifications implement to encapsulate filtering logic. The client can then use the specifications to filter objects:

```csharp
public interface ISpecification<T>
{
    bool IsSatisfiedBy(T item);
}

public class ColorSpecification : ISpecification<Product>
{
    private readonly Color _targetColor;

    public ColorSpecification(Color targetColor)
    {
        _targetColor = targetColor;
    }

    public bool IsSatisfiedBy(Product product)
    {
        // Check if the product's color matches the target color
        return product.Color == _targetColor;
    }
}

// Other specification classes for size, price, etc.

// Composite specification
public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _spec1;
    private readonly ISpecification<T> _spec2;

    public AndSpecification(ISpecification<T> spec1, ISpecification<T> spec2)
    {
        _spec1 = spec1;
        _spec2 = spec2;
    }

    public bool IsSatisfiedBy(T item)
    {
        // Check if both spec1 and spec2 are satisfied
        return _spec1.IsSatisfiedBy(item) && _spec2.IsSatisfiedBy(item);
    }
}

// Usage
var redAndLargeSpec = new AndSpecification<Product>(
    new ColorSpecification(Color.Red),
    new SizeSpecification(Size.Large)
);

List<Product> filteredProducts = products.Where(product => redAndLargeSpec.IsSatisfiedBy(product)).ToList();


<p>&nbsp;</p>

### Links


[Specifications - Martin Fowler](https://martinfowler.com/apsupp/spec.pdf)

