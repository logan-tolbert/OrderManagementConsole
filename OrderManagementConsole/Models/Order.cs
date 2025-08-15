// See https://aka.ms/new-console-template for more information
public class Order
{
    public int Id { get; set; }
    public int  CustomerId { get; set; }
    public decimal Total { get; set; }
    public DateTime Date { get; set; }
    public OrderStatus Status { get; set; }

    public Order() { }

    public Order(int id, int customerId, decimal total, DateTime date, OrderStatus status)
    {
        Id = id;
        CustomerId = customerId;
        Total = total;
        Date = date;
        Status = status;
    }
}
