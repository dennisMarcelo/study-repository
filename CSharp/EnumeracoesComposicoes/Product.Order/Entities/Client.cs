namespace Product.Order.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirhDate { get; set; }

        public Client(string name, string email, DateTime birhDate)
        {
            Name = name;
            Email = email;
            BirhDate = birhDate;
        }
    }
}
