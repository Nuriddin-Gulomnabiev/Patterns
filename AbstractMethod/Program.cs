using AbstractMethod.Factories;
using AbstractMethod.Services;

var reportService = new ReportService(new GermanFactory());

reportService.Report(23, new DateTime(2025,6,13));

reportService = new ReportService(new UsaFactory());

reportService.Report(65, new DateTime(2022,6,13));

























