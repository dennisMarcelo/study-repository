using MetodosClassesAbstratos.Entities;

namespace MetodosClassesAbstratos
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new PessoaFisica("Alex", 50000.00, 2000.00));
            pessoas.Add(new PessoaJuridica("SoftTech", 400000.00, 25));
            pessoas.Add(new PessoaFisica("Bob", 120000.00, 1000.00));


            Console.WriteLine("TAXES PAID:");

            double totalJurosArrecadado = 0.0;
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome}: ${pessoa.CalcularImpostoAnual().ToString("N2")}");
                totalJurosArrecadado += pessoa.CalcularImpostoAnual();
            }

            Console.WriteLine($"Valor Total de Imposto Arrecadado: {totalJurosArrecadado.ToString("N2")}");
        }
    }
}
