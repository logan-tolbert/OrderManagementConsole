using OrderManagementConsole.Enums;

namespace OrderManagementConsole.Abstractions;

public interface IPaymentProcessor
{
    bool ProcessPayment(Order order, decimal amount, PaymentProvider provider = PaymentProvider.None);
}