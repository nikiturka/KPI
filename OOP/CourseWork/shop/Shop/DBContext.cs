using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class DBContext
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public List<History> HistoryList { get; set; }

        public DBContext()
        {
            Users = new List<User>
            {
                new User() { ID = 1, UserLogin = "nikiturka", UserName = "nikita", UserSurname = "turda", Budget = 20000, Password = "0000" },
                new User() { ID = 2, UserLogin = "admin", UserName = "admin_name", UserSurname = "admin_surname",Budget = 9999999, Password = "admin" },
            };
            Products = new List<Product>
            {
                new ElectronicDevice(1, "Samsung Galaxy S22", 999, "Android", 6.2, "Snapdragon 8cx"),
                new ElectronicDevice(2, "MacBook Pro 14", 1999, "macOS Monterey", 14, "Apple M1 Pro"),
                new ElectronicDevice(3, "Fitbit Sense", 299, "Fitbit OS", 1.58, "Custom Fitbit Chip"),
                new ElectronicDevice(4, "Microsoft Surface Pro 8", 1099, "Windows 11", 12.3, "Intel Core i5"),
                new HouseholdAppliance(5, "Samsung Refrigerator", 1200, "Refrigerator", "Samsung", "A+"),
                new HouseholdAppliance(6, "LG Microwave Oven", 299, "Microwave Oven", "LG", "A"),
                new HouseholdAppliance(7, "Whirlpool Dishwasher", 899, "Dishwasher", "Whirlpool", "A++"),
                new HouseholdAppliance(8, "Bosch Washing Machine", 699, "Washing Machine", "Bosch", "A+++")
        };
            BasketItems = new List<BasketItem> { };
            HistoryList = new List<History> { };
        }
    }
}
