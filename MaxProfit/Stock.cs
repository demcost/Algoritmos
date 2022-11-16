using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProfit
{
    public class Stock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
                return 0;

            if (prices.Length == 2)
            {
                if (prices[1] > prices[0])
                    return prices[1] - prices[0];
                else
                    return 0;
            }

            int IndexMin = 0;
            int MaxProfit = 0;

            for (int IndexMax = 1; IndexMax < prices.Length; IndexMax++)
            {
                if (prices[IndexMin] > prices[IndexMax])
                {
                    IndexMin = IndexMax;
                }

                if (prices[IndexMax] - prices[IndexMin] > MaxProfit)
                {
                    MaxProfit = prices[IndexMax] - prices[IndexMin];
                }
            }

            return MaxProfit;
        }
    }
}
