# EInvoiceTtnFeesCalculator
#EN
`InvoiceFeesTunisia` is a .NET SDK that allows you to accurately calculate a company’s monthly electronic invoicing fees, based on a defined pricing scheme (electronic processing, subscriptions, paper copies, and PDF/XML copies).

### Quick Start
```csharp
using InvoiceFeesTunisia.Fees;
using InvoiceFeesTunisia.Fees.Models;

// Define the invoices for the month
var invoices = new List<Invoice>
{
    new Invoice { SizeInKb = 120, PdfXmlCopies = 2, PaperCopies = 1 },
    new Invoice { SizeInKb = 45,  PdfXmlCopies = 1, PaperCopies = 0 }
};

// Initialize the SDK client
var client = new InvoiceFeesClient();

// Calculate the total monthly fees
decimal totalFees = client.CalculateMonthlyFees(invoices);

Console.WriteLine($"Total monthly fees: {totalFees} DT");
```
#FR
`InvoiceFeesTunisia` est un SDK .NET qui permet de calculer avec précision les frais mensuels de facturation électronique d’une entreprise, selon une grille tarifaire définie (traitement électronique, abonnements, copies papier et PDF/XML).

```csharp
using InvoiceFeesTunisia.Fees;
using InvoiceFeesTunisia.Fees.Models;

// Définir les factures du mois
var invoices = new List<Invoice>
{
    new Invoice { SizeInKb = 120, PdfXmlCopies = 2, PaperCopies = 1 },
    new Invoice { SizeInKb = 45,  PdfXmlCopies = 1, PaperCopies = 0 }
};

// Initialiser le client du SDK
var client = new InvoiceFeesClient();

// Calculer le total des frais mensuels
decimal totalFees = client.CalculateMonthlyFees(invoices);

Console.WriteLine($"Total des frais mensuels : {totalFees} DT");
```

#AR InvoiceFeesTunisia هو SDK لـ .NET يتيح لك حساب رسوم الفواتير الإلكترونية الشهرية للشركة بدقة، وفقًا لنظام التسعير المحدد (المعالجة الإلكترونية، الاشتراكات، النسخ الورقية ونسخ PDF/XML).

```csharp
using InvoiceFeesTunisia.Fees;
using InvoiceFeesTunisia.Fees.Models;

// تعريف الفواتير الخاصة بالشهر
var invoices = new List<Invoice>
{
    new Invoice { SizeInKb = 120, PdfXmlCopies = 2, PaperCopies = 1 },
    new Invoice { SizeInKb = 45,  PdfXmlCopies = 1, PaperCopies = 0 }
};

// تهيئة العميل الخاص بالـ SDK
var client = new InvoiceFeesClient();

// حساب إجمالي الرسوم الشهرية
decimal totalFees = client.CalculateMonthlyFees(invoices);

Console.WriteLine($"إجمالي الرسوم الشهرية: {totalFees} DT");

```
