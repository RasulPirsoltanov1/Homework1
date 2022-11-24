namespace Enums
{
    public enum Currency
    {
        Usd,
        Eur,
        TRY,
        Rub
    }
    class GetValue
    {
        public static double getCurrency(Currency money, double value)
        {
            if (money==Currency.Usd)
            {
                return value * 0.59;
            }
            else if (money == Currency.Eur)
            {
                return (value * 0.53);
            }
            else if (money == Currency.TRY)
            {
                return (value * 8.73);
            }
            else if(money == Currency.Rub)
            {
                return value * 52.21;
            }
            return 0;
        }

    }
}
