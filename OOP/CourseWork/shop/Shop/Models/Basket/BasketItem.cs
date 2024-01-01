using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
	public class BasketItem
	{
		public Product Product { get; set; }
		public int ProductID { get; set; }
		public DateTime DateCreated { get; set; }
		public int CustomerID { get; set; }


		public String toRow()
		{
            return $"ID:{ProductID}\nProduct: {Product.ProductName}\nPrice: {Product.ProductPrice}\nDate: {DateCreated}\n";
        }
    }
}
