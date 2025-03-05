namespace Product.Order.Entities
{
    class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
