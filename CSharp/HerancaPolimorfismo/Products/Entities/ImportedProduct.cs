namespace Products.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFree { get; set; }

        public ImportedProduct(string name, double price, double customFree) : base(name, price)
        {
            CustomFree = customFree;
        }

        public double TotalPrice()
        {
            return price + CustomFree;
        }

        public override string PriceTag()
        {
            return $"{Name} ${TotalPrice().ToString("N2")} (Custom Free: ${CustomFree.ToString("N2")})";
        }
    }
}
