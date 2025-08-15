using OrderManagementConsole.Abstractions;
using OrderManagementConsole.Enums;

namespace OrderManagementConsole.Services.Payments;

public class PayPalProcessor : IPaymentProcessor
{
    public bool ProcessPayment(Order order, decimal amount, PaymentProvider provider = PaymentProvider.PayPal)
    {
        Console.WriteLine($"[PayPalProcessor] Charging {amount:C} for Order {order.Id} via PayPal...");

        // Simulate API call
        bool paymentSuccess = true;
        string providerTransactionId = "PP-" + Guid.NewGuid().ToString();

        if (paymentSuccess)
        {
            order.MarkAsPaid(PaymentMethod.DigitalWallet, provider, providerTransactionId);
            return true;
        }

        return false;
    }
}
