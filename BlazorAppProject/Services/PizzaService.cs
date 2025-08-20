public class PizzaService
{
    private static readonly PizzaData[] _pizzas = new[]
    {
        new PizzaData
        {
            PizzaId = 1,
            Name = "Margherita",
            Description = "Classic pizza with tomato, mozzarella and basil.",
            Price = 8.99m,
            Vegetarian = true,
            Vegan = false
        },
        new PizzaData
        {
            PizzaId = 2,
            Name = "Pepperoni",
            Description = "Spicy pepperoni with tomato sauce and mozzarella.",
            Price = 10.49m,
            Vegetarian = false,
            Vegan = false
        },
        new PizzaData
        {
            PizzaId = 3,
            Name = "Vegan Delight",
            Description = "Dairy-free cheese, tomato sauce, and fresh vegetables.",
            Price = 9.99m,
            Vegetarian = true,
            Vegan = true
        }
    };

    public Task<PizzaData[]> GetPizzasAsync()
    {
        // Simulate async data retrieval
        return Task.FromResult(_pizzas);
    }
}
