using AbstractMethod.Interfaces;

namespace AbstractMethod.Generators;

public class PdfReportGenerator : IReportGenerator
{
    private readonly IDataFormatter _formatter;

    public PdfReportGenerator(IDataFormatter formatter)
    {
        _formatter = formatter;
    }
    
    public void GenerateReport(decimal amount, DateTime date)
    {
        Console.WriteLine("=== PDF REPORT ===");
        Console.WriteLine($"Amount: {_formatter.FormatAmount(amount)}");
        Console.WriteLine($"Date: {_formatter.FormatDateTime(date)}");
        Console.WriteLine("==================");
    }
}