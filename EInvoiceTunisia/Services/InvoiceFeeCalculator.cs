using EInvoiceTunisia.Fees.Models;
using EInvoiceTunisia.Fees.Pricing;

namespace EInvoiceTunisia.Services
{
    internal class InvoiceFeeCalculator : IInvoiceFeeCalculator
    {
        public decimal CalculateMonthlyFees(
            IReadOnlyCollection<Invoice> invoices,
            bool includeWebSubscription,
            bool includeEdiSubscription)
        {
            decimal total = 0;

            foreach (var invoice in invoices)
            {
                var blocksOf50Kb = (int)Math.Ceiling(invoice.SizeInKb / 50.0);
                total += blocksOf50Kb * FeeRates.ProcessingFeePer50Kb;
            }

            if (includeWebSubscription)
                total += FeeRates.WebSubscription;

            if (includeEdiSubscription)
                total += FeeRates.EdiSubscription;

            total += invoices.Sum(i => i.PaperCopies * FeeRates.PaperCopyFee);

            int totalPdfXmlCopies = invoices.Sum(i => i.PdfXmlCopies);
            total += CalculatePdfXmlCopies(totalPdfXmlCopies);

            return decimal.Round(total, 3);
        }

        private decimal CalculatePdfXmlCopies(int count)
        {
            if (count <= 0)
                return 0;

            if (count <= 10)
                return count * FeeRates.PdfXml_1_To_10;

            if (count <= 100)
                return 10 * FeeRates.PdfXml_1_To_10
                     + (count - 10) * FeeRates.PdfXml_11_To_100;

            return 10 * FeeRates.PdfXml_1_To_10
                 + 90 * FeeRates.PdfXml_11_To_100
                 + (count - 100) * FeeRates.PdfXml_Above_100;
        }
    }
}
