namespace EInvoiceTunisia.Fees.Pricing
{
    public class FeeRates
    {
        // Traitement électronique
        public const decimal ProcessingFeePer50Kb = 0.190m;

        // Abonnements mensuels
        public const decimal WebSubscription = 10.000m;
        public const decimal EdiSubscription = 10.000m;

        // Copies
        public const decimal PaperCopyFee = 1.000m;

        public const decimal PdfXml_1_To_10 = 1.000m;
        public const decimal PdfXml_11_To_100 = 0.500m;
        public const decimal PdfXml_Above_100 = 0.250m;
    }
}
