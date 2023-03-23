using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Receipt
    {
        public List<Product> Products { get; private set; } = new List<Product>();
        public double TotalPrice { get; set; } = 0.00;
        
        public int ProductCount(Product product)
        {
            return Products.Count(s => s.Id == product.Id);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            TotalPrice += product.Price;
        }

        public void DelItem(Product product)
        {
            Products.Remove(product);
        }

        public void DelAllItems(Product product)
        {
            bool AllDeleted = false;
            while (!AllDeleted)
            {
                if (Products.Contains(product))
                {
                    Products.Remove(product);
                }
                else
                {
                    AllDeleted = true;
                }
            }
        }

        public void ClearList()
        {
            Products.Clear();
        }

    }
}
