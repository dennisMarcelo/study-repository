using System;

public class Program
{
	public record Cliente
	{
		public int ID { get; private set; }
		public String Name { get; set; }
		public String Email { get; set; }

		public Cliente(int id)
		{
			ID = id;
		}

		public override string ToString()
		{
			return $"{ID} \t {Name} \t {Email}";
		}

		public void Deconstruct(out int id, out string name, out string email) // desconstrutor
        {
			id = ID;
			name = Name;
			email = Email;
        }
	}

	public static void Main()
	{
		Cliente p = new Cliente(1);
		p.Name = "Dennis Marcelo";
		p.Email = "denism@gmail.com";

		Cliente p2 = new Cliente(2);
		p2.Name = "Liza B";
		p2.Email = "lizab@gmail.com";


		Console.WriteLine(p);
		Console.WriteLine(p2);

		// utilizando o with
		var pessoa = p with { Email = "dennisMarcelo23@hotmail.com" };
		Console.WriteLine(pessoa);

		// desconstruindo
		var (id, testeNome, _) = p; 
		Console.WriteLine($"{id}, {testeNome}");
	}
}