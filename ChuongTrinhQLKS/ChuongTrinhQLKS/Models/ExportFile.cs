using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ChuongTrinhQLKS.Models
{
    internal class ExportFile
    {
        public void ExportToExcel(DataTable dataTable, string sheetName, string title)
        {
            var excel = new Excel.Application();
            var workbook = excel.Workbooks.Add(Type.Missing);
            var worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = sheetName;

            try
            {
                
                var titleRange = worksheet.get_Range("A1", Type.Missing);
                titleRange.MergeCells = true;
                titleRange.Value2 = title;
                titleRange.Font.Size = 20;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[2, i + 1] = dataTable.Columns[i].ColumnName;
                }

               
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 3, j + 1] = dataTable.Rows[i][j];
                    }
                }

                
                worksheet.Columns.AutoFit();

                
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string savePath = System.IO.Path.Combine(projectDirectory, "C:\\Users\\nguye\\OneDrive - vinhuni.edu.vn\\Documents\\GitHub\\doannam2hk2\\ChuongTrinhQLKS\\Data\\" + title + ".xlsx");
                workbook.SaveAs(savePath);
                workbook.Close();
                excel.Quit();

                Console.WriteLine("Tệp Excel đã được tạo thành công tại: " + savePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                // Giải phóng tài nguyên
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excel);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Xảy ra lỗi khi giải phóng đối tượng: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public DataTable GetDataTableFromDataGridView(DataGridView dataGridView)
        {
            var dt = new DataTable();

            // Thêm các cột vào DataTable
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Type columnType = column.ValueType ?? typeof(object);
                dt.Columns.Add(column.HeaderText, columnType);
            }

            // Thêm các hàng vào DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var dataRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value ?? DBNull.Value;
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }
    }
}
