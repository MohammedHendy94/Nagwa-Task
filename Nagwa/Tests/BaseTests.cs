
using OfficeOpenXml;
using System;
using System.IO;

namespace Nagwa.Tests
{
	public class BaseTests
	{        
        private static string GetExcelValue(string cellNumber, string sheetName)
        {
            string excelValue;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo("TestData.xlsx")))
            {
                var firstSheet = package.Workbook.Worksheets[sheetName];
                excelValue = firstSheet.Cells[cellNumber].Text;
            }
            return excelValue;
        }
        public readonly int numOfSearchResultsToBeClicked = Convert.ToInt32( GetExcelValue("A2", "Sheet1"));
        public readonly string searchKeyWord = GetExcelValue("B2", "Sheet1");
    }
}
