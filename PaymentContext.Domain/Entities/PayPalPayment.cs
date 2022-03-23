namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(string number, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, string document, string address, string email, string transactionCode) : base(number, paidDate, expireDate, total, totalPaid, owner, document, address, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
}