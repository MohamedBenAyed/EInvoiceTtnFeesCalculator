using EInvoiceTunisia.Services;

namespace EInvoiceTunisia.Fees
{
    internal sealed class MonthlyBillingEngine
    {
        private readonly IInvoiceFeeCalculator _calculator;

        internal MonthlyBillingEngine()
        {
            _calculator = new InvoiceFeeCalculator();
        }

        internal decimal Run(IReadOnlyCollection<Models.Invoice> invoices)
        {
            return _calculator.CalculateMonthlyFees(
                invoices,
                includeWebSubscription: true,
                includeEdiSubscription: true);
        }
    }
}
