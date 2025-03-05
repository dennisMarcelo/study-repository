namespace Projeto.LendoArquivosCSV.Entities
{
    class Sale
    {
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Sale()
        {
        }

        public Sale(string product, double price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            return Price*Quantity;
        }
    }
}