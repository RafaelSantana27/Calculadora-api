namespace Calculadora_api.Services
{
    public class CalculadoraService
    {
        public decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }
        public decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }
        public decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }
        public decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            if (segundoNumero == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            return primeiroNumero / segundoNumero;
        }
        public decimal Media(decimal primeiroNumero, decimal segundoNumero)
        {
            return (primeiroNumero + segundoNumero) / 2;
        }
    }
}
