using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    internal class Order
    {
        private int Id { get; set; }
        private DateTime Date { get; set; }
        private List<Item> OrderList = new List<Item>();


    }
}
