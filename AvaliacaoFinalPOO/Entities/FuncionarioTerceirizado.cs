
namespace AvaliacaoFinalPOO.Entities
{
    class FuncionarioTerceirizado : Funcionario
    {
        public string EmpresaOrigem { get; set; }
        public double TaxaServico { get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico) 
            : base(nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }

        public override double CalculaSalario() 
        {
            return (double)CargaHoraria * ValorHora * (1.0 + TaxaServico/100);
        }

    }
}
