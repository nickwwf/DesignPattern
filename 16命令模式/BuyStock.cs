using System;
using System.Collections.Generic;
using System.Text;

namespace _16命令模式
{
    public class BuyStock : IOrder
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Excute()
        {
            abcStock.Buy();
        }
    }
}
