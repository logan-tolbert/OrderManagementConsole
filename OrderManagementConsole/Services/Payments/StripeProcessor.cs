using OrderManagementConsole.Abstractions;
using OrderManagementConsole.Enums;

namespace OrderManagementConsole.Services.Payments;

public class StripePaymentProcessor : IPaymentProcessor
{
    public bool ProcessPayment(Order order, decimal amount, PaymentProvider provider = PaymentProvider.Stripe)
    {
        Console.WriteLine($"[CreditCardProcessor] Charging {amount:C} for Order {order.Id} via Stripe...");

        bool paymentSuccess = true;
        string providerTransactionId = Guid.NewGuid().ToString();

        if (paymentSuccess)
        {
            order.MarkAsPaid(PaymentMethod.CreditCard, provider, providerTransactionId);
            return true;
        }

        return false;
    }
}
