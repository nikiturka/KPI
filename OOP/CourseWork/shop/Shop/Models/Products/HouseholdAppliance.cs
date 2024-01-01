using System;
using System.Text;

namespace Shop
{
    public class HouseholdAppliance : Product
    {
        public string ApplianceType { get; }
        public string Brand { get; }
        public string EnergyEfficiencyClass { get; }
        private string productType = "Household Appliance";

        public HouseholdAppliance(int productID, string productName, decimal productPrice, string applianceType, string brand, string energyEfficiencyClass) : base(productID, productName, productPrice)
        {
            ApplianceType = applianceType;
            Brand = brand;
            EnergyEfficiencyClass = energyEfficiencyClass;
        }

        public override string toString()
        {
            var info = new StringBuilder();
            info.AppendLine($"ID: {ProductID} Appliance name: {ProductName} Price: {ProductPrice} Type: {ApplianceType} Brand: {Brand} Energy Class: {EnergyEfficiencyClass}");
            return info.ToString();
        }

        public override string toRow()
        {
            return $"{ProductID}. {ProductName}\nCategory: {productType}\nPrice: {ProductPrice}\n";
        }
    }
}