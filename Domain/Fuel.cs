namespace WinFormsApp.Domain
{
    internal class FuelCollection
    {
        public Dictionary<string, Fuel> fuelsList;

        public FuelCollection()
        {
            fuelsList = new Dictionary<string, Fuel>();
        }

        public void AddFuel(Fuel fuel)
        {
            fuelsList.Add(fuel.GetType(), fuel);
        }

        public void RemoveFuel(Fuel fuel)
        {
            fuelsList.Remove(fuel.GetType());
        }
    }

    internal class Fuel
    {
        public string Type { get; private set; }
        public double Price { get; private set; }

        public Fuel(string type, double price)
        {
            Type = type;
            Price = price;
        }

        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
        }

        public string GetType()
        {
            return Type;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
