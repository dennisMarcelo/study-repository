namespace MetodosClassesAbstratos.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImpostoAnual()
        {
            if(NumeroFuncionarios >= 10)
            {
                return RendaAnual * 1.4;
            }
            else
            {
                return RendaAnual * 1.6;
            }
        }
    }
}
