namespace Products.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.price = price;
        }

        public virtual string PriceTag()
        {
            return $"{Name} ${price.ToString("N2")}";
        }
    }
}
