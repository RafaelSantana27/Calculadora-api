namespace Calculadora_api.Services
{
    public class CalculadoraService
    {
        private readonly HistoricoService _historicoService;

        public CalculadoraService(HistoricoService historicoService)
        {
            _historicoService = historicoService;
        }

        public decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            var resultado = primeiroNumero + segundoNumero;

            //_historicoService.AdicionarHistorico($"Soma: {primeiroNumero} + {segundoNumero} = {resultado}");
            _historicoService.AdicionarHistorico($"Soma,{primeiroNumero},{segundoNumero},{resultado}");

            return resultado;
        }
        public decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            var resultado = primeiroNumero - segundoNumero;
            _historicoService.AdicionarHistorico($"Subtração,{primeiroNumero},{segundoNumero},{resultado}");
            return resultado;
        }
        public decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            var resultado = primeiroNumero * segundoNumero;
            _historicoService.AdicionarHistorico($"Multiplicação,{primeiroNumero},{segundoNumero},{resultado}");
            return resultado;
        }
        public decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            if (segundoNumero == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");

            var resultado = primeiroNumero / segundoNumero;
            _historicoService.AdicionarHistorico($"Divisão,{primeiroNumero},{segundoNumero},{resultado}");
            return resultado;
        }
        public decimal Media(decimal primeiroNumero, decimal segundoNumero)
        {
            var resultado = (primeiroNumero + segundoNumero) / 2;
            _historicoService.AdicionarHistorico($"Média,{primeiroNumero},{segundoNumero},{resultado}");
            return resultado;
        }
    }
}
