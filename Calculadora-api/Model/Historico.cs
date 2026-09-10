namespace Calculadora_api.Model
{
    public class Historico
    {
        public string Operacao { get; set; }
        public decimal PrimeiroNumero { get; set; }
        public decimal SegundoNumero { get; set; }
        public decimal Resultado { get; set; }
        public DateTime DataHoraOperacao { get; set; }

        public Historico(string operacao, decimal primeiroNumero, decimal segundoNumero, decimal resultado, DateTime dataHoraOperacao)
        {
            Operacao = operacao;
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
            Resultado = resultado;
            DataHoraOperacao = dataHoraOperacao;
        }
    }
}
