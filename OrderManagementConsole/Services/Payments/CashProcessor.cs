using OrderManagementConsole.Abstractions;
using OrderManagementConsole.Enums;


namespace OrderManagementConsole.Services.Payments;

public class CashProcessor : IPaymentProcessor
{
    public bool ProcessPayment(Order order, decimal amount, PaymentProvider provider = PaymentProvider.Manual)
    {
        Console.WriteLine($"[CashProcessor] Accepting {amount:C} cash for Order {order.Id}...");

        order.MarkAsPaid(PaymentMethod.Cash, provider);
        return true;
    }
}
