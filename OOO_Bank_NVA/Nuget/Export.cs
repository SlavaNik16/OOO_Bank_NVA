using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace OOO_Bank_NVA.Nuget
{
    public class Export
    {
        public static void CreateExcelSheet(DataGridView dataGridView, string name = "OOO Банк NVA")
        {
            int i = 1;
            var xlApp = new Excel.Application();

            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 30;


            xlSheet = (Excel.Worksheet)wBook.Sheets[1];

            xlSheet.Name = name;

            for (int k = 0; k < dataGridView.ColumnCount; k++)
            {
                xlSheet.Cells[i, k + 1] = dataGridView.Columns[k].HeaderCell.Value;
            }

            i++;
            for (int k = 0; k < dataGridView.RowCount; k++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    xlSheet.Cells[k + i, j + 1] = dataGridView.Rows[k].Cells[j].Value?.ToString();
                }
            }
            xlSheet.Cells.HorizontalAlignment = 3;
            xlApp.Visible = true;
        }
    }
}
