namespace Exercise.Classes.Attributes.Methods.Entities
{
    public static class CurrencyConverter
    {
        private static readonly double IOF = 6.00;

        public static double ConvertDollarToReal(double dollarExchangeRate, double amount)
        {
            var amountConverted = amount * dollarExchangeRate;

            return amountConverted + (amountConverted * IOF) / 100;
        }
    }
}