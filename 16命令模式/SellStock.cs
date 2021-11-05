using System;
using System.Collections.Generic;
using System.Text;

namespace _16命令模式
{
    public class SellStock : IOrder
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Excute()
        {
            abcStock.Sell();
        }
    }
}
