using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_CurrencyExchange
{
    class ExchangeMonitor
    {
        private int total_exchanges;
        private decimal total_money_converted_usd;

        public ExchangeMonitor()
        {
            // Set to 0 initially
            total_exchanges = 0;
            total_money_converted_usd = 0;
        }

        public void increment_total_exchanges()
        {
            ++total_exchanges;
        }

        public int get_total_exchanges()
        {
            return total_exchanges;
        }

        public void update_total_money(decimal addition)
        {
            total_money_converted_usd += addition;
        }

        public decimal get_total_money()
        {
            return Decimal.Round(total_money_converted_usd, 2);
        }
    }
}
