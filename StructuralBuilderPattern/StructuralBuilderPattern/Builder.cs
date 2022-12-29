namespace StructuralBuilderPattern;

/// <summary>
/// Specifies an abstract interface for creating parts of a Product object
/// </summary>
public abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
}