using System.Globalization;

namespace Interface_CSharp.Entites
{
    class Invoice
    {
        public double BasicPay { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPay, double tax)
        {
            BasicPay = basicPay;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPay + Tax;  }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPay.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
