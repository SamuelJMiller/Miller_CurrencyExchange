using System;

namespace Miller_CurrencyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            string start_c = null; // Convert from
            string end_c = null; // Convert to
            string received_amount = null;
            decimal amount = 0;

            ExchangeMonitor em = new ExchangeMonitor(); // Will keep track of required metrics

            // Get starting currency to see if we should even proceed:
            Console.WriteLine("Enter starting currency (usd, gbp, can, eur, or c to cancel):");
            start_c = Console.ReadLine();

            while (start_c != "c") // While user input is not 'c'
            {
                Console.WriteLine("Enter a currency to convert to:");
                end_c = Console.ReadLine(); // Get output preference

                Console.WriteLine("Enter amount of currency to convert");
                received_amount = Console.ReadLine(); // Get amount to convert

                amount = Decimal.Parse(received_amount); // Convert string to decimal

                try {
                    // Depending on start_currency, make appropriate conversions:
                    switch (start_c)
                    {
                        case "usd":
                            Console.WriteLine("Your resulting quantity is " + Exchanger.USD_convert(amount, end_c) + " " + end_c);
                            em.update_total_money(amount);
                            break;
                        case "gbp":
                            Console.WriteLine("Your resulting quantity is " + Exchanger.GBP_convert(amount, end_c) + " " + end_c);
                            em.update_total_money(amount * (decimal) 1.37887); // Convert each currency before adding
                            break;
                        case "can":
                            Console.WriteLine("Your resulting quantity is " + Exchanger.CAN_convert(amount, end_c) + " " + end_c);
                            em.update_total_money(amount * (decimal) 0.79728);
                            break;
                        case "eur":
                            Console.WriteLine("Your resulting quantity is " + Exchanger.EUR_convert(amount, end_c) + " " + end_c);
                            em.update_total_money(amount * (decimal) 1.19648);
                            break;
                        // If not valid, break and restart process:
                        default:
                            Console.WriteLine("Bad starting currency. Starting over...");
                            break;
                    }
                } catch (ArgumentException ae)
                {
                    Console.WriteLine("Bad conversion target. Starting over...");
                }

                Console.WriteLine();
                em.increment_total_exchanges(); // Add at the end of exchange

                Console.WriteLine("Enter next starting currency (usd, gbp, can, eur, or c to cancel):");
                start_c = Console.ReadLine(); // Read new currency, if user decides to
            }

            Console.WriteLine("You made " + em.get_total_exchanges() + " exchanges with a total volume of "
                               + em.get_total_money() + " usd traded."); // Concluding output

            
        }
    }
}
