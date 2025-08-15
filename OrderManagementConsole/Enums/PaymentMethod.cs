using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementConsole.Enums;

public enum PaymentMethod
{
    None = 0,
    DebitCard,
    CreditCard,
    BankTransfer,
    DigitalWallet,    
    Cash,            
    Check,            
    Cryptocurrency,   
    GiftCard,
    StoreCredit
}
