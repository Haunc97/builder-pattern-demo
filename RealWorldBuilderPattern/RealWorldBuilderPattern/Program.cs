using RealWorldBuilderPattern;

VehicleBuilder builder;

// Create shop with vehicle builders
Shop shop = new();

// Construct and display vehicles
builder = new ScooterBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new CarBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new MotorCycleBuilder();
shop.Construct(builder);
builder.Vehicle.Show();


// Wait for user
Console.ReadKey();