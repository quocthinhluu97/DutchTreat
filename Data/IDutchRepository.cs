using DutchTreat.Data.Entities;
using System.Collections.Generic;

namespace DutchTreat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        IEnumerable<Product> GetProductsByCategory(string category);
        bool SaveChanges();
        Order GetOrderById(string username, int id);
        void AddEntity(Order model);
    }
}