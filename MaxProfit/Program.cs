// See https://aka.ms/new-console-template for more information
using MaxProfit;




Stock besttimeBuySell = new Stock();

int[] prices = new int[] {7,1,5,3,6,4 };

Console.WriteLine(besttimeBuySell.MaxProfit(prices) == 5);

prices = new int[] { 7, 6, 4, 3, 1 };

Console.WriteLine(besttimeBuySell.MaxProfit(prices) == 0);

prices = new int[] { 2,4,1 };

Console.WriteLine(besttimeBuySell.MaxProfit(prices) == 2);

Console.ReadLine();