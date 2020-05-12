using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Hall_Management_System.Special
{
    class couponpdf
    {
        Database.DBConnect db = new Database.DBConnect();
        Basic.information_load il = new Basic.information_load();
        public void pdf_c(String hall_name,String session, String title){
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



                    string[] copy = { "OFFICE", "STUDENT" };
                    string hallname = hall_name;
                    int hallid = il.get_id("SELECT hall_id FROM `hall_info` WHERE `hall_name` = '" + hallname + "'");
                    
                    

                    String end_query = " FROM `student_info` WHERE `session` = '" + session + "' AND `hall_id` =" + hallid + " AND `status` =0";
                    String class_roll_query = "SELECT `class_roll` " + end_query;
                    String name_query = "SELECT `name` " + end_query;
                    String alloted_room_query = "SELECT `alloted_room`  " + end_query;

                    String[] class_roll_result = db.select_multi_array(class_roll_query);
                    String[] name_result = db.select_multi_array(name_query);
                    String[] alloted_room_result = db.select_multi_array(alloted_room_query);



                    Document doc = new Document();

                    try
                    {
                        string fontpath = "font/times.ttf";
                        BaseFont basefont = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, true);
                        //for end of font
                        //set font size
                        iTextSharp.text.Font font16 = new iTextSharp.text.Font(basefont, 16, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font font16boldblue = new iTextSharp.text.Font(basefont, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);

                        iTextSharp.text.Font font16bold = new iTextSharp.text.Font(basefont, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

                        iTextSharp.text.Font font14bold = new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

                        iTextSharp.text.Font font14 = new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font font12bold = new iTextSharp.text.Font(basefont, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font font12 = new iTextSharp.text.Font(basefont, 12, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font font10 = new iTextSharp.text.Font(basefont, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font font8italicblue = new iTextSharp.text.Font(basefont, 8, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLUE);



                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
                        //calling watermarks
                        writer.PageEvent = new Report.PDFWriterEvents("IIT,JU", 40f, doc.PageSize.Width / 2, doc.PageSize.Height / 2, 30f);
                        // calling PDFFooter class to Include in document

                        writer.PageEvent = new Report.PDFFooter("yes", "no", "yes");

                        doc.Open();
                        //doc.Add(new Paragraph("GIF"));


                        Paragraph ass = new Paragraph("Couopn for ".ToUpper()+title +", Session : ".ToUpper()+ session+" , Hall Name : ".ToUpper()+ hallname, font14bold);
                        ass.Alignment = 1;
                        ass.SpacingAfter = 30f;
                        doc.Add(ass);

                        PdfPTable bosstable = new PdfPTable(2);
                        bosstable.TotalWidth = doc.PageSize.Width - 60f;
                        bosstable.LockedWidth = true;

                        for (int i = 0; i < class_roll_result.Length; i++)
                        {
                            for (int k = 0; k < 2; k++)
                            {

                                PdfPTable table = new PdfPTable(2);
                                PdfPCell rc11 = new PdfPCell(new Phrase(copy[k] + " COPY".ToUpper(), font8italicblue));
                                rc11.Colspan = 2;
                                rc11.HorizontalAlignment = 2;
                                rc11.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                table.AddCell(rc11);

                                PdfPCell rc12 = new PdfPCell(new Phrase(hallname.ToUpper(), font12bold));
                                rc12.Colspan = 2;
                                rc12.Border = iTextSharp.text.Rectangle.NO_BORDER;
                               
                                table.AddCell(rc12);


                                PdfPCell rc21 = new PdfPCell(new Phrase("NAME : "+name_result[i], font10));
                                rc21.Colspan = 2;
                                rc21.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                table.AddCell(rc21);

                                PdfPCell rc22 = new PdfPCell(new Phrase("CLASS ROLL : " + class_roll_result[i], font10));
                                rc22.Colspan = 2;
                                rc22.Border = iTextSharp.text.Rectangle.NO_BORDER;

                                table.AddCell(rc22);

                                PdfPCell rc31 = new PdfPCell(new Phrase("ALLOTED ROOM : "+alloted_room_result[i], font10));
                                rc31.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                table.AddCell(rc31);

                                PdfPCell rc32 = new PdfPCell(new Phrase("SESSION : " + session, font10));
                                rc32.HorizontalAlignment = 2;
                                rc32.Border = iTextSharp.text.Rectangle.NO_BORDER;

                                table.AddCell(rc32);

                                PdfPCell rc41 = new PdfPCell(new Phrase("COUPON FOR " + title, font10));
                                rc41.Colspan = 2;
                                rc41.Border = iTextSharp.text.Rectangle.NO_BORDER;

                                table.AddCell(rc41);


                                table.SpacingAfter = 10f;

                                //  doc.Add(table);


                                PdfPCell boss11 = new PdfPCell(table);

                                bosstable.AddCell(boss11);

                            }

                        }


                        doc.Add(bosstable);


                        



                        doc.Close();
                        MessageBox.Show("success");
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {

                        //doc.Close();

                    }


                }
            }
    
    }
    }
}
