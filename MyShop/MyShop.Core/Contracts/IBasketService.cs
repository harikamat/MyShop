using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MyShop.Core.ViewModels;

namespace MyShop.Core.Contracts
{
    public interface IBasketService
    {
        void AddtoBasket(HttpContextBase httpContext, string productId);
        void RemoveFromBasket(HttpContextBase httpContext, string productId);
        List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);
        BasketSummaryViewModelcs GetBasketSummary(HttpContextBase httpContext);
    }
}
