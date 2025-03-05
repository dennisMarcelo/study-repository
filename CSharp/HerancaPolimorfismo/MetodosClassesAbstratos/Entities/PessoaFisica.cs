namespace MetodosClassesAbstratos.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GasotComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gasotComSaude) : base(nome, rendaAnual)
        {
            GasotComSaude = gasotComSaude;
        }

        public override double CalcularImpostoAnual()
        {
            double imposto;
            if(RendaAnual < 20000)
            {
                imposto = RendaAnual * 1.5;
            }
            else
            {
                imposto = RendaAnual * 2.5;

            }

            if (GasotComSaude > 0)
            {
                return imposto - (GasotComSaude * 5.0);
            }
            else
            {
                return imposto;
            }
        }
    }
}
