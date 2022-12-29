﻿namespace StructuralBuilderPattern;

/// <summary>
/// - Constructs and assembles parts of the product by implementing the Builder interface
/// <br></br>
/// - Defines and keeps track of the representation it creates
/// <br></br>
/// - Provides an interface for retrieving the product
/// </summary>
public sealed class ConcreteBuilder2: Builder
{
    private Product _product = new();
    public override void BuildPartA()
    {
        _product.Add("PartX");
    }
    public override void BuildPartB()
    {
        _product.Add("PartY");
    }
    public override Product GetResult()
    {
        return _product;
    }
}