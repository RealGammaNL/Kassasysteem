using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Artikel
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        
        public Artikel(string _name, double _price) 
        { 
            Name = _name;
            Price = _price;
        }
    }
}
