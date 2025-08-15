namespace OrderManagementConsole.Enums;

public enum PaymentProvider
{
    None = 0,
    Stripe,
    PayPal,
    Square,
    Authorize,        // Authorize.Net
    Braintree,
    Adyen,
    WorldPay,
    Internal,         // For cash drawer, checks, internal ledger entries handled internally
    Manual            // Consumer bank, wire transfer, money order, etc.
}
