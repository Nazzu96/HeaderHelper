using System.Collections.Generic;
using System.Net;
using OfficeOpenXml;

namespace Header.Services;

public class ExcelConnection
{
    List<string> students = new List<string>(30);
    List<string> disciplines = new List<string>();
    private int studentCount;
    private int disciplineCount;
    private string filePath = "Header/Files/Sheet(sample).xltx";
    private string groupName;
    private string charectedMonth = "Month";

    enum Month
    {
    }

    public ExcelConnection()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var package = new ExcelPackage(filePath);
        ExcelWorkbook workbook = package.Workbook;
        ExcelWorksheet worksheet = workbook.Worksheets[0];
        Meeting(studentCount, package, workbook);

        package.SaveAs($"Header/Files/{groupName}.xltx");
    }

    void Meeting(int n, ExcelPackage package, ExcelWorkbook workbook)
    {
        ExcelWorksheet worksheetMonth = workbook.Worksheets[0];
        ExcelWorksheet worksheetQuarter = workbook.Worksheets["РК-1"];
        ExcelWorksheet worksheet = workbook.Worksheets["Семестр"];
        worksheetMonth.Cells["B6:B35"].LoadFromCollection(students, PrintHeaders: false);
        worksheetQuarter.Cells["C6:R6"].LoadFromCollection(disciplines, PrintHeaders: false);
        for (int i = 0; i < 10; i++) // Ведомость
        {
            worksheetMonth = workbook.Worksheets[i];
            worksheetMonth.Cells[$"B{n + 5}:AK35"].Clear();
        }

        for (int i = 0; i < 5; i++) // РК
        {
            worksheetQuarter = workbook.Worksheets[$"РК-{i + 1}"];
            worksheetQuarter.Cells[$"B{n + 7}:Y37"].Clear();
        }


        worksheet.Cells[$"B{n + 3}:AB33"].Clear(); // Семестр

        int col = 6;
        // TODO: Сделать для выбранного месяца
        for (int i = 0; i < n; i++) // Заполнение уважительной для студентов одного месяца
        {
            int missingHours = 0;
            foreach (var cell in worksheet.Cells[$"C{col}:AG{col}"])
            {
                if (cell.Style.Font.Bold) missingHours += 2;
            }

            worksheet.Cells[$"AI{col}"].Value = missingHours;
            col++;
        }
    }
}