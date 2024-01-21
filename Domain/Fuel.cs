using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    internal class Fuel
    {
        private Dictionary<string, double> FuelCollection;

        public Fuel() 
        {
            FuelCollection = new Dictionary<string, double>();
        }
        
        public void Add(string key, double value)
        {
            FuelCollection.Add(key, value);
        }

        public void Remove(string key)
        {
            FuelCollection.Remove(key);
        }

        public void ChangeValue(string key, double value)
        {
            FuelCollection.Remove(key);
            FuelCollection.Add(key, value);
        }

        public double GetPrice(string key)
        {
            return FuelCollection[key];
        }
    }
}
