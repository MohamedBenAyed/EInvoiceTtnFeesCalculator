namespace EInvoiceTunisia.Fees.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        /// <summary>
        /// Taille de la facture en kilo-octets
        /// </summary>
        public double SizeInKb { get; set; }

        /// <summary>
        /// Nombre de copies PDF/XML
        /// </summary>
        public int PdfXmlCopies { get; set; }

        /// <summary>
        /// Nombre de copies papier
        /// </summary>
        public int PaperCopies { get; set; }
    }
}
