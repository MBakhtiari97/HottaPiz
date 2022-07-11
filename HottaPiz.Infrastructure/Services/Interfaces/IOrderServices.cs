using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.DataLayer.Entities.Order;
using HottaPiz.DataLayer.Entities.Pizza;

namespace HottaPiz.Infrastructure.Services.Interfaces
{
    public interface IOrderServices
    {
        #region Create First Customer Open Order

        public Task<bool> CreateFirstCustomerOpenOrderAsync(Order newOrder);

        #endregion

        #region Add Order To Order Basket

        public Task<bool> AddToOrderBasket(AddToOrderVM order);

        #endregion

        #region Check Customer Has Open Order

        public bool CheckCustomerHaveAnOpenOrder(int customerId);

        #endregion

        #region Get Customer Open Order Id 

        public int GetCustomerOpenOrderId(int customerId);

        #endregion

        #region Check Specific Order Has Specific Pizza

        public bool CheckOrderHaveSpecificPizza(int orderId, int pizzaId);

        #endregion

        #region Get Order Details By Order Id And Pizza Id

        public OrderDetails GetOrderDetailsByOrderIdAndPizzaId(int orderId, int pizzaId);

        #endregion

        #region Get Order By Order Id

        public Order GetOrderByOrderId(int orderId);

        #endregion

        #region Get Order Basket Items

        public Task<List<ShowOrderBasketVM>> GetOrderBasketItems(int customerId);

        #endregion

        #region Ger Pizza By Pizza Id

        public Pizza GetPizzaByPizzaId(int pizzaId);

        #endregion

        #region Remove Pizza From Order Basket 

        public Task<bool> RemovePizzaFromOrderBasket(int customerId, int pizzaId);

        #endregion

        #region Get Order Total Price

        public decimal GetOrderPrice(int customerId);

        #endregion

        #region Get Customer Name By Customer Id

        public string GetCustomerNameByCustomerId(int customerId);

        #endregion

        #region Finize Customer Order

        public Task FinalizeCustomerOrder(int customerId);

        #endregion

        #region Related To Admin Methods

        #region Get Customer Order By Customer Id

        public Task<List<Order>> GetCustomerOrdersAsync(int customerId);

        #endregion

        #region Get All Orders

        public Task<List<Order>> GetAllOrdersAsync();

        #endregion

        #region Get Total Orders Prices

        public decimal GetTotalOrdersPrices();

        #endregion

        #region Remove Order From History

        public Task<bool> RemoveOrderFromHistory(int orderId);

        #endregion

        #endregion
    }
}
