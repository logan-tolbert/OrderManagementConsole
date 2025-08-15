using System.Collections.Generic;
using System.Linq;

var qr = new QueryRunner();


//var result = qr.FilterOrdersByPrice(100);

//foreach (var order in result)
//{
//    Console.WriteLine($"{order.Id}: Date:{order.Date} - Total: {order.Total.ToString("c2")} -  Order Status: {order.Status}");
//}

//var result = qr.CountOrdersByStatus();
//foreach (var status in result)
//{
//    Console.WriteLine(status);
//}

//var result = qr.GetOrdersByCustomerLastName("Boehm");
//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Customer.LastName} Order Id: {item.Order.Id}: Date:{item.Order.Date} - Total: {item.Order.Total.ToString("c2")} -  Order Status: {item.Order.Status}");
//}

var result = qr.FilterCustomerOrdersByMinimumTotal(150);
foreach (var group in result)
{
    string key = group.Key;
    Console.WriteLine($"Customer Name: {key}");

    foreach (var item in group)
    {
        Console.WriteLine($"{item.OrderId} - {item.Total:c2}");
    }
}

//var result = qr.GetMostRecentOrder("Boehm");
//Console.WriteLine($"{result.FullName}'s Last Order Placed:\nId: {result.OrderId} - {result.Date} -\nTotal: {result.Total:c2}\nStatus: {result.Status}");