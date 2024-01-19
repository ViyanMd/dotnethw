namespace WinFormsApp.Domain
{
    internal class Order
    {
        private int Id { get; set; }
        private List<Item> OrderList = new List<Item>();
        private int ItemsQuantity { get; set; }
        private int TotalPrice { get; set; }

        private DateTime Date { get; set; }

        public Order(List<Item> orderList, DateTime date)
        {
            Id = (int)new Random().Next(0, Int32.MaxValue);
            OrderList = new List<Item>(orderList);
            Date = date;

            for (int i = 0; i < OrderList.Count; i++)
            {
                ItemsQuantity += OrderList[i].getQuantity();
                TotalPrice += OrderList[i].getTotalPrice();
            }
        }
        public List<Item> getOrderList()
        {
            return OrderList;
        }
        public override string ToString()
        {
            return $"Order Id: {Id}  |  Items Quantity: {ItemsQuantity}  |  TotalPrice: {TotalPrice}  |  Date: {Date}";
        }
    }
}
