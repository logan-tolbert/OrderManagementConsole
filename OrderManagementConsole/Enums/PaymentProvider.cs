using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    Internal,         // For cash, checks handled internally
    Manual
}
