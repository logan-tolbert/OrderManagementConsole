using OrderManagementConsole.Data;
using OrderManagementConsole.Models;


public class QueryRunner
{
    public IEnumerable<Customer> Customers = new CustomerData().Customers;
    public IEnumerable<Order> Orders = new OrderData().Orders;

    public IEnumerable<Order> FilterOrdersByPrice(decimal price)
    {
        var query = Orders
            .Where(o => o.Total > price)
            .OrderByDescending(o => o.OrderDate);
        return query;
    }

    public IEnumerable<(OrderStatus Status, int Count)> CountOrdersByStatus()
    {
        var query = Orders
            //.Where (o => o.Status == status)
            .GroupBy(o => o.Status)
            .Select(g => (Status: g.Key, Count: g.Count()));

        return query;
    }

    public IEnumerable<(Customer Customer, Order Order)> GetOrdersByCustomerLastName(string lastName)
    {
        var query = Customers
        .Where(c => c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
        .Join(
            Orders,
            c => c.Id,
            o => o.CustomerId,
            (c, o) => (Customer: c, Order: o)
        );

        return query;

    }

    public IEnumerable<IGrouping<string, (string FullName, int? OrderId, decimal Total)>> FilterCustomerOrdersByMinimumTotal(decimal total)
    {
        var query = Orders
            .Where(o => o.Total > total)
            .Join(
               Customers,
               o => o.CustomerId,
               c => c.Id,
               (o, c) => (FullName: $"{c.FirstName} {c.LastName}", OrderId: o.Id, o.Total))
            .GroupBy(c => c.FullName);

        return query;
    }

    public (string FullName, int? OrderId, DateTime Date, decimal Total, OrderStatus Status) GetMostRecentOrder(string lastName)
    {
        var query = Customers
            .Where(c => c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
            .Join(
                Orders,
                c => c.Id,
                o => o.CustomerId,
                (c, o) => (FullName: $"{c.FirstName} {c.LastName}", OrderId: o.Id, o.OrderDate, o.Total, o.Status))
            .OrderByDescending(o => o.OrderDate).First();
        return query;
    }


}