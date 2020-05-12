using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Hall_Management_System.Report
{
    class single_student_reportpdf
    {
        Database.DBConnect db = new Database.DBConnect();
        public void single_PDF(int hall_std_id,String[] info_opt,string start_date, string end_date,int remark_no) {
            
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


                    String[] onoff = info_opt;
                    string start = start_date;
                    string end = end_date;
                    int remark = remark_no;

                    string[] pdf_settings = { "yes","no","yes","IIT,JU"};
                    
                    string header_all = pdf_settings[0];
                    string header_first = pdf_settings[1];
                    string footer_all = pdf_settings[2];

                    string watermark_text = pdf_settings[3];

                    // `degree`, `mobile`, `phone`, `email`, `blood_group`, `hall_id`, `dept_id`, `faculty_id`, `qouta_id`, `added_by`, `status`
                    String need_query = "SELECT `hall_std_id`, `session`, `name`, `class_roll`, `degree`, `registration_no`,`mobile`  FROM `student_info` WHERE `hall_std_id` = " + hall_std_id;
                    String basic_query = "SELECT  `name`,`f_name`, `m_name`, `address`, `sex`, `religion`  FROM `student_info` WHERE `hall_std_id` = " + hall_std_id;

                    String contact_query = "SELECT `mobile`, `phone`, `email` , `alloted_room` FROM `student_info` WHERE `hall_std_id` = " + hall_std_id;
                    String academic_query = "SELECT  s.`degree`,  h.hall_name , d.dept_name,f.faculty_name ,q.qouta_name FROM student_info as s,dept_info as d,faculty_info as f,hall_info as h,qouta as q WHERE s.dept_id = d.dept_id and s.faculty_id = f.faculty_id and s.hall_id = h.hall_id and s.qouta_id = q.qouta_id and s.`hall_std_id` = " + hall_std_id;

                    String attendance_all_query = " SELECT count(*)  FROM `att_set` WHERE `from_date` >= '"+start+"' AND `to_date` <= '"+end+"' ";
                    String attendance_student_query = "SELECT count(*) FROM `attendance` WHERE  `date_time` >= '" + start + "' AND `date_time` <= '" + end + "' AND `hall_std_id` =" + hall_std_id + " ";
                    String attendance_query = "SELECT (" + attendance_all_query + ") as day_all,(" + attendance_student_query + ") as day_student,((" + attendance_student_query + ")/(" + attendance_all_query + "))*100 as result  ";
                    string remark_header_query = "SELECT  `author`  FROM `remark` WHERE `hall_std_id` = " + hall_std_id + " ORDER BY `remark`.`date_time` DESC LIMIT 0, " + remark + "";

                    string remark_query = "SELECT concat(`remarks`, '-----' ,`date_time` ) FROM `remark` WHERE `hall_std_id` = " + hall_std_id + " ORDER BY `remark`.`date_time` DESC LIMIT 0, " + remark + "";


                    String[] table_header = { "Basic Information", "Contact Information", "Academic Information", "Attendance", "Remark" };

                    String[] basic_row = { "Name", "Father Name", "Mother Name", "Address", "Sex", "Religion" };
                    String[] contact_row = { "Mobile No", "Phone", "Email", "Allted Room No" };
                    String[] academic_row = { "Degree", "Hall Name", "Department Name", "Daculty Name", "Qouta" };
                    String[] attendance_row = { "No. of Day", "Presence", "IN PERCENTAGE(%)" };
                    String[] remark_row = db.multi_select_array(remark_header_query);

                    String[][] row = { basic_row, contact_row, academic_row, attendance_row, remark_row };
                    //MessageBox.Show(row[0][2]+row[1][2]);

                    String[] need_row_data = db.multi_select_array(need_query);

                    String[] basic_row_data = db.multi_select_array(basic_query);
                    String[] contact_row_data = db.multi_select_array(contact_query);
                    String[] academic_row_data = db.multi_select_array(academic_query);
                    String[] attendance_row_data = db.multi_select_array(attendance_query);
                    String[] remark_row_data = db.multi_select_array(remark_query);

                    String[][] row_data = { basic_row_data, contact_row_data, academic_row_data, attendance_row_data, remark_row_data };


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
                        iTextSharp.text.Font font12 = new iTextSharp.text.Font(basefont, 12, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font font10 = new iTextSharp.text.Font(basefont, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font font8italicblue = new iTextSharp.text.Font(basefont, 8, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLUE);



                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
                        //calling watermarks
                        writer.PageEvent = new PDFWriterEvents(watermark_text, 40f, doc.PageSize.Width / 2, doc.PageSize.Height / 2, 30f);
                        // calling PDFFooter class to Include in document

                        writer.PageEvent = new PDFFooter(header_all, header_first, footer_all);

                        doc.Open();
                        //doc.Add(new Paragraph("GIF"));


                        Paragraph ass = new Paragraph("Student Report", font16boldblue);
                        ass.Alignment = 1;
                        ass.SpacingAfter = 30f;
                        doc.Add(ass);




                        PdfPTable table = new PdfPTable(3);
                        table.TotalWidth = doc.PageSize.Width - 60f;

                        //fix the absolute width of the table

                        table.LockedWidth = true;
                        PdfPCell rc11 = new PdfPCell(new Phrase("Student ID : " + need_row_data[0], font12));
                        rc11.Border = iTextSharp.text.Rectangle.NO_BORDER;

                        table.AddCell(rc11);

                        PdfPCell rc12 = new PdfPCell(new Phrase("Session : " + need_row_data[1], font12));
                        rc12.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        rc12.HorizontalAlignment = 2;
                        table.AddCell(rc12);


                        iTextSharp.text.Image std_pic = iTextSharp.text.Image.GetInstance("images/" + need_row_data[6] + ".jpg");
                        std_pic.ScaleToFit(100f, 100f);


                        PdfPCell image = new PdfPCell(std_pic);
                        image.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        image.HorizontalAlignment = 2;
                        image.Rowspan = 3;
                        table.AddCell(image);

                        PdfPCell rc21 = new PdfPCell(new Phrase("Student Name : " + need_row_data[2], font12));
                        rc21.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        table.AddCell(rc21);

                        PdfPCell rc22 = new PdfPCell(new Phrase("Class Roll : " + need_row_data[3], font12));
                        rc22.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        rc22.HorizontalAlignment = 2;
                        table.AddCell(rc22);

                        PdfPCell rc31 = new PdfPCell(new Phrase("Degree: " + need_row_data[4], font12));
                        rc31.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        table.AddCell(rc31);

                        PdfPCell rc32 = new PdfPCell(new Phrase("Registration No : " + need_row_data[5], font12));
                        rc32.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        rc32.HorizontalAlignment = 2;
                        table.AddCell(rc32);

                        table.SpacingAfter = 30f;

                        doc.Add(table);



                        //start table2
                        PdfPTable table2 = new PdfPTable(1);
                        table2.TotalWidth = doc.PageSize.Width - 60f;
                        table2.LockedWidth = true;
                        int i = 0;
                        while (i < 5)
                        {

                            if (onoff[i] == "yes")
                            {
                                PdfPCell t2header = new PdfPCell(new Phrase(table_header[i], font14bold));
                                t2header.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                                t2header.PaddingTop = 10f;
                                table2.AddCell(t2header);
                                int j = 0;
                                while (j < row[i].Length)
                                {

                                    //Name, Father Name , Mother Name ,address , sex ,religion, Blood Group
                                    PdfPCell t2row = new PdfPCell(new Phrase(row[i][j] + " : " + row_data[i][j], font10));
                                    t2row.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                    table2.AddCell(t2row);

                                    j++;
                                }
                            }
                            i++;

                        }
                        doc.Add(table2);
                        //end table2



                        doc.Close();
                        MessageBox.Show("PDF Creation is Successful. Location is "+file,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
