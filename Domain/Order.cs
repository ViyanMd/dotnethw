using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    internal class Order
    {
        public int Id { get; private set; }
        public double TotalAmount { get; set; }
        public Order(double totalAmount) 
        {
            Id = new Random().Next();
            TotalAmount = totalAmount;
        }
    }
}
