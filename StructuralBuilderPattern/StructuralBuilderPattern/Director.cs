namespace StructuralBuilderPattern;

/// <summary>
/// Constructs an object using the Builder interface
/// </summary>
public sealed class Director
{
    // Builder uses a complex series of steps
    public void Construct(Builder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}