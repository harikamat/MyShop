using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyShop.Core.ViewModels
{
    public class BasketSummaryViewModelcs
    {
        public int BasketCount { get; set; }
        public decimal BasketTotal { get; set; }

        public BasketSummaryViewModelcs()
        {
        }

        public BasketSummaryViewModelcs(int basketCount, decimal basketTotal)
        {
            this.BasketCount = basketCount;
            this.BasketTotal = basketTotal;
        }

        
    }
}
