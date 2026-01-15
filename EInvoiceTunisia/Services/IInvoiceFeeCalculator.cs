using EInvoiceTunisia.Fees.Models;

namespace EInvoiceTunisia.Services
{
    internal interface IInvoiceFeeCalculator
    {
        decimal CalculateMonthlyFees(
            IReadOnlyCollection<Invoice> invoices,
            bool includeWebSubscription,
            bool includeEdiSubscription);
    }
}
