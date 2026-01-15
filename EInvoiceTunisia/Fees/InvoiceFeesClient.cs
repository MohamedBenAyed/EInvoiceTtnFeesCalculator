namespace EInvoiceTunisia.Fees
{
    public sealed class InvoiceFeesClient
    {
        private readonly MonthlyBillingEngine _engine;

        public InvoiceFeesClient()
        {
            _engine = new MonthlyBillingEngine();
        }

        public decimal CalculateMonthlyFees(
            IReadOnlyCollection<Models.Invoice> invoices)
        {
            return _engine.Run(invoices);
        }
    }
}
