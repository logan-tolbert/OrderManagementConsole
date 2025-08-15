// See https://aka.ms/new-console-template for more information
using OrderManagementConsole.Enums;
using System.Data;

public class Order
{
    public int? Id { get; set; }
    public int CustomerId { get; set; }
    public decimal Total { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public bool IsPaid { get; private set; }
    public DateTime? PaymentDate { get; private set; }
    public PaymentMethod PaymentMethod { get; private set; } = PaymentMethod.None;
    public PaymentProvider PaymentProvider { get; private set; } = PaymentProvider.None;
    public Guid? InternalTransactionId { get; private set; }
    public string? ProviderTransactionId { get; private set; }
    public DateTime? LastUpdated { get; private set; }
    public bool AllowLatePayment { get; private set; } = false;
    public bool AllowCOD { get; private set; } = false;
    public Order() { }
    public Order(int? id, int customerId, decimal total, DateTime orderDate, OrderStatus status = OrderStatus.Pending, bool allowLatePayment = false, bool allowCOD = false)
    {
        Id = id;
        CustomerId = customerId;
        Total = total;
        OrderDate = orderDate;
        Status = Status;
        AllowLatePayment = allowLatePayment;
        AllowCOD = allowCOD;
        LastUpdated = Touch();
    }

    public void MarkAsPaid(PaymentMethod paymentMethod, PaymentProvider paymentProvider, string? providerTransactionId = null)
    {
        if (IsPaid)
            throw new InvalidOperationException("Order is already marked as paid");

        // Allow payment if: Pending OR late payment allowed OR COD allowed
        bool canAcceptPayment = Status == OrderStatus.Pending || AllowLatePayment || AllowCOD;

        if (!canAcceptPayment)
            throw new InvalidOperationException($"Cannot mark order as paid when status is {Status}.");

        PaymentDate = DateTime.UtcNow;
        PaymentMethod = paymentMethod;
        PaymentProvider = paymentProvider;
        InternalTransactionId = Guid.NewGuid();
        ProviderTransactionId = providerTransactionId;

        if (Status == OrderStatus.Pending)
        {
            Status = OrderStatus.PaymentReceived;
            
        }

        IsPaid = true;
        LastUpdated = Touch();
    }

    private DateTime Touch()
    {
        return DateTime.UtcNow;
    }
}
