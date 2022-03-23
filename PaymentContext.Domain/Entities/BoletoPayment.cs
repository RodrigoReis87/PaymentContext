namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string number, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, string document, string address, string email, string barcode, string boletoNumber) : base(number, paidDate, expireDate, total, totalPaid, owner, document, address, email)
        {
            Barcode = barcode;
            BoletoNumber = boletoNumber;
        }
        
        public string Barcode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}