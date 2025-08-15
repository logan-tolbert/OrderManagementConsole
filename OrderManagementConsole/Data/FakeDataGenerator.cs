using Bogus;
using OrderManagementConsole.Models;
using System;
using System.Collections.Generic;

public static class FakeDataGenerator
{
    public static IEnumerable<Customer> GenerateFakeCustomers(int count)
    {
        var customerFaker = new Faker<Customer>()
            .RuleFor(c => c.Id, f => f.IndexFaker)
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName))
            .RuleFor(c => c.DateOfBirth, f => f.Date.Past(50, DateTime.Now.AddYears(-18)));

        return customerFaker.Generate(count);
    }

    public static IEnumerable<Order> GenerateFakeOrders(int count)
    {
        var orderFaker = new Faker<Order>()
            .RuleFor(o => o.Id, f => f.IndexFaker)
            .RuleFor(o => o.CustomerId, f => f.Random.Int(1, 100))
            .RuleFor(o => o.Total, f => f.Random.Decimal(10, 1000)) 
            .RuleFor(o => o.Date, f => f.Date.Past(2)) 
            .RuleFor(o => o.Status, f => f.PickRandom<OrderStatus>());

        return orderFaker.Generate(count);
    }

    
    public static IEnumerable<Order> GenerateFakeOrdersForCustomers(IEnumerable<Customer> customers, int ordersPerCustomer = 3)
    {
        var orders = new List<Order>();
        var orderIdCounter = 1;

        foreach (var customer in customers)
        {
            var orderFaker = new Faker<Order>()
                .RuleFor(o => o.Id, f => orderIdCounter++)
                .RuleFor(o => o.CustomerId, f => customer.Id)
                .RuleFor(o => o.Total, f => f.Random.Decimal(10, 1000))
                .RuleFor(o => o.Date, f => f.Date.Past(2))
                .RuleFor(o => o.Status, f => f.PickRandom<OrderStatus>());

            orders.AddRange(orderFaker.Generate(ordersPerCustomer));
        }

        return orders;
    }
}