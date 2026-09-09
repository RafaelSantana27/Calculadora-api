namespace Calculadora_api.Utils
{
    public class HelperNumero
    {
        public static bool EhNumero(string strNumero)
        {
            decimal numero;

            return decimal.TryParse(strNumero, out numero);
        }

        public static decimal ConverterParaDecimal(string strNumero)
        {
            decimal numero;

            if (decimal.TryParse(strNumero, out numero))
                return numero;
            return 0;
        }
    }
}
