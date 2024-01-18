using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    internal class Item
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }
        private int Quantity { get; set; }
        private int TotalPrice { get; set; }
        private DateTime Date { get; set; }

        public Item(string name, string description, int price, int quantity, DateTime date)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            TotalPrice = quantity * price;
            Date = date;
        }
        private void updateTotalPrice()
        {
            TotalPrice = Price * Quantity;
        }
        public override string ToString()
        {
            return $"{Name}  |  {Description}  |  {Price}  |  {Quantity}  |  {TotalPrice}  |  {Date}";
        }

        public void ChangeName(string newName)
        {
            if (String.IsNullOrEmpty(newName))
                throw new Exception("Name can't be empty");
            else
                Name = newName;
        }

        public void ChangeDescription(string newDescription)
        {
            if (String.IsNullOrEmpty(newDescription))
                throw new Exception("Description can't be empty");
            else
                Description = newDescription;
        }

        public void ChangePrice(int newPrice)
        {
            if (newPrice <= 0)
                throw new Exception("Price can't be less or equal to zero");
            else
            {
                Price = newPrice;
                updateTotalPrice();
            }
        }

        public void ChangeQuantity(int newQuantity)
        {
            if (newQuantity <= 0)
                throw new Exception("Quantity can't be less or equal to zero");
            else
            {
                Quantity = newQuantity;
                updateTotalPrice();
            }
        }

        public void ChangeDate(DateTime newOrderDate)
        {
            if (newOrderDate > DateTime.Today)
                throw new Exception("Date can't be in the future");
            else
                Date = newOrderDate;
        }

    }
}
