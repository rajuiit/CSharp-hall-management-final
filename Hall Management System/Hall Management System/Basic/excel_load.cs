using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Hall_Management_System.Basic
{
    class excel_load
    {
        public void saveAsPDF(DataGridView dgv) {

            string path = Environment.CurrentDirectory;
            path = Path.Combine(path, "Report");
            bool IsExists = System.IO.Directory.Exists(path);
            if (!IsExists) System.IO.Directory.CreateDirectory(path);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {


                sfd.InitialDirectory = path;
                sfd.FileName = "report";
                string file = "report.pdf";
                sfd.Filter = "*.pdf|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    file = sfd.FileName;


                   
                
                var doc1 = new Document();

         doc_properties(doc1);
                
                FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
                //int count =  file.IndexOf("\\");
                //MessageBox.Show(file + count.ToString());
              //  PdfWriter.GetInstance(doc1, new FileStream(file, FileMode.Create));

                PdfWriter writer =  PdfWriter.GetInstance(doc1, fs);
                writer.PageEvent = new Report.PDFWriterEvents("IIT,JU", 40f, doc1.PageSize.Width / 2, doc1.PageSize.Height / 2, 30f);
                // calling PDFFooter class to Include in document
                writer.PageEvent = new Report.PDFFooter("yes","no","yes");
                doc1.Open();
            
                
                int rowCount = dgv.Rows.Count;
                int colCount = dgv.Columns.Count;

                
                
                PdfPTable table = new PdfPTable(colCount);
                //for table
               
                table.SpacingBefore = 30f;
                table.SpacingAfter = 30f; 
                table.TotalWidth = doc1.PageSize.Width - (table.SpacingBefore + table.SpacingAfter);
                //fix the absolute width of the table
                table.LockedWidth = true;
                //relative col widths in proportions - 1/3 and 2/3
                float[] widths = new float[] { 2f, 4f, 6f };
                //table.SetWidths(widths);
                table.HorizontalAlignment = 0;
                //leave a gap before and after the table
               
                doc1.Add(new Paragraph("My first PDF"));
    
                PdfPCell cell = new PdfPCell(new Phrase("Header"));
                cell.Colspan = colCount;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                cell.BackgroundColor = BaseColor.BLUE;
                table.AddCell(cell);
                
                // Storing header part in Excel
                for (int i = 1; i < colCount + 1; i++)
                {
                    
                    PdfPCell header = new PdfPCell(new Phrase(dgv.Columns[i - 1].HeaderText));
                    header.BackgroundColor = BaseColor.CYAN;
                    table.AddCell(header);
                    //    ExcelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    
                }

                // Storing Each row and column value to excel sheet               
                for (int l = 0; l < 100; l++)
                {
                    for (int i = 0; i < rowCount; i++)
                    {

                        //this.Text = "Processing: " + dgv.Rows[i].Cells[0].Value.ToString();
                        for (int j = 0; j < colCount; j++)
                        {

                            PdfPCell body = new PdfPCell();
                            body.Phrase = new Phrase(dgv.Rows[i].Cells[j].Value.ToString());
                            if (i % 2 == 0)
                            {
                                body.BackgroundColor = BaseColor.WHITE;

                            }
                            else
                            {
                                body.BackgroundColor = BaseColor.WHITE.Darker(); ;

                            }
                            
                            table.AddCell(body);

                            //      ExcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                
                doc1.Add(table);
                doc1.Close();
                
                

            
                    MessageBox.Show("PDF file created-- " + file, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        
        
        }

        private void doc_properties(Document doc)
        {
            // Setting Document properties e.g.
            // 1. Title
            // 2. Subject
            // 3. Keywords
            // 4. Creator
            // 5. Author
            // 6. Header
            doc.AddTitle("Hall Management System Report");
            doc.AddSubject("This is an Example of Report Generartion");
            doc.AddKeywords("Metadata, iTextSharp 5.4.4, Chapter 1, Tutorial");
            doc.AddCreator("iTextSharp 5.4.4");
            doc.AddAuthor("Sayed Mohsin Reza");
            doc.AddHeader("Report", "Student");
           
            //doc.Add(page);
        }

        
        public void saveAsExcel(DataGridView dgv) {
          

            string fileName = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.ValidateNames = true;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.DefaultExt = ".xls";
            saveFileDialog.Filter = "Microsoft Excel Workbook (*.xls)|*.xls";
            //------------------------------------------------------------------------         

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;

                Excel.ApplicationClass ExcelApp = new Excel.ApplicationClass();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                int rowCount = dgv.Rows.Count;
                int colCount = dgv.Columns.Count;

                // Storing header part in Excel
                for (int i = 1; i < colCount + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                // Storing Each row and column value to excel sheet               
                for (int i = 0; i < rowCount; i++)
                {
                    //this.Text = "Processing: " + dgv.Rows[i].Cells[0].Value.ToString();
                    for (int j = 0; j < colCount; j++)
                    {

                        ExcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                string fileLocation = fileName;

                if (File.Exists(fileLocation))
                {
                    try
                    {
                        File.Delete(fileLocation);
                        ExcelApp.ActiveWorkbook.SaveCopyAs(fileLocation);
                        ExcelApp.ActiveWorkbook.Saved = true;
                        ExcelApp.Quit();

                        MessageBox.Show("Excel file created-- " + fileLocation,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Close the Excel file and Export again..." + ioe.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    ExcelApp.ActiveWorkbook.SaveCopyAs(fileLocation);
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();

                    MessageBox.Show("Excel file created-- " + fileLocation,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }  
        
        
        
        
        }
    }
}
