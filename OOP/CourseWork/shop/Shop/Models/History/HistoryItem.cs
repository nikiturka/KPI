using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class HistoryItem
    {
        public int ItemID { get; }
        public string ItemName { get; }
        public decimal ItemPrice { get; }

        public HistoryItem(int itemID, string itemName, decimal itemPrice)
        {
            ItemID = itemID;
            ItemName = itemName;
            ItemPrice = itemPrice;
        }
        public String toRow()
        {
            return $"{ItemID}. {ItemName}\nPrice: {ItemPrice}\n";
        }
    }
}
