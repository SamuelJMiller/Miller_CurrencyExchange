using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_CurrencyExchange
{
    static class Exchanger
    {
        // This method converts USD to the target currency
        public static decimal USD_convert(decimal amount, string convert_to)
        {
            switch (convert_to)
            {
                // Make conversions based on argument:
                case "gbp":
                    return Decimal.Round(amount * (decimal) 0.72523, 2);
                case "can":
                    return Decimal.Round(amount * (decimal) 1.25427, 2);
                case "eur":
                    return Decimal.Round(amount * (decimal) 0.83572, 2);
                default:
                    // If bad argument:
                    throw new ArgumentException("Invalid currency", "convert_to");
            }
        }

        // This method converts GBP to the target currency
        public static decimal GBP_convert(decimal amount, string convert_to)
        {
            switch (convert_to)
            {
                case "usd":
                    return Decimal.Round(amount * (decimal) 1.37887, 2);
                case "can":
                    return Decimal.Round(amount * (decimal) 1.72947, 2);
                case "eur":
                    return Decimal.Round(amount * (decimal) 1.15195, 2);
                default:
                    throw new ArgumentException("Invalid currency", "convert_to");
            }
        }

        // This method converts CAN to the target currency
        public static decimal CAN_convert(decimal amount, string convert_to)
        {
            switch (convert_to)
            {
                case "usd":
                    return Decimal.Round(amount * (decimal) 0.79728, 2);
                case "gbp":
                    return Decimal.Round(amount * (decimal) 0.57848, 2);
                case "eur":
                    return Decimal.Round(amount * (decimal) 0.66645, 2);
                default:
                    throw new ArgumentException("Invalid currency", "convert_to");
            }
        }

        // This method converts EUR to the target currency
        public static decimal EUR_convert(decimal amount, string convert_to)
        {
            switch (convert_to)
            {
                case "usd":
                    return Decimal.Round(amount * (decimal) 1.19648, 2);
                case "gbp":
                    return Decimal.Round(amount * (decimal) 0.86826, 2);
                case "can":
                    return Decimal.Round(amount * (decimal) 1.50040, 2);
                default:
                    throw new ArgumentException("Invalid currency", "convert_to");
            }
        }
    }
}
