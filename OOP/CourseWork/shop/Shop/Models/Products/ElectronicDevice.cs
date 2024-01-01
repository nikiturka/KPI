using System;
using System.Text;

namespace Shop
{
    public class ElectronicDevice : Product
    {
        public string OperatingSystem { get; }
        public double ScreenSize { get; }
        public string Processor { get; }
        private string productType = "Electronic Device";

        public ElectronicDevice(int productID, string productName, decimal productPrice, string operatingSystem, double screenSize, string processor) : base(productID, productName, productPrice)
        {
            OperatingSystem = operatingSystem;
            ScreenSize = screenSize;
            Processor = processor;
        }

        public override string toString()
        {
            var info = new StringBuilder();
            info.AppendLine($"ID: {ProductID} Device name: {ProductName} Price: {ProductPrice} OS: {OperatingSystem} Screen size: {ScreenSize} Processor: {Processor}");
            return info.ToString();
        }

        public override string toRow()
        {
            return $"{ProductID}. {ProductName}\nCategory: {productType}\nPrice: {ProductPrice}\n";
        }
    }
}
