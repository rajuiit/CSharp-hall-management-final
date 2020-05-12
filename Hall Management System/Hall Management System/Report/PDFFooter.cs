using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Hall_Management_System.Report 
{
    class PDFFooter : PdfPageEventHelper
    {
        string header_all_page;
        string header_1st_page;
        string footer;

        public PDFFooter(string header_all_page,string header_1st_page, string footer)
        {

            this.header_all_page = header_all_page;
            this.header_1st_page = header_1st_page;
            this.footer = footer;
        }
        


        // write on top of document
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            if (header_1st_page == "yes")
            {
                base.OnOpenDocument(writer, document);
                set_header_image(writer,document);
            }
        }

        public void set_header_image(PdfWriter writer, Document document)
        {
            PdfPTable tabFot = new PdfPTable(1);
            tabFot.TotalWidth = document.PageSize.Width - 30f;
            tabFot.LockedWidth = true;
            iTextSharp.text.Image header_image = iTextSharp.text.Image.GetInstance("need/header.jpg");
            header_image.ScaleToFit(document.PageSize.Width - 30f, 200f);
            header_image.Alignment = 1;
            PdfPCell cell = new PdfPCell(header_image); ;
            cell.HorizontalAlignment = 1;
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            tabFot.AddCell(cell);
            
            //tabFot.WriteSelectedRows(0, -1, 0, document.Top, writer.DirectContent);
            document.Add(tabFot);

        }

        // write on start of each page
        public override void OnStartPage(PdfWriter writer, Document document)
        {
            if (header_all_page == "yes")
            {
                base.OnStartPage(writer, document);
                set_header_image(writer, document);
            }
        }

        // write on end of each page
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            


            base.OnEndPage(writer, document);
            PdfPTable tabFot = new PdfPTable(1);
            tabFot.HorizontalAlignment = 1;
            PdfPCell cell;
            tabFot.TotalWidth = document.PageSize.Width - 60f;
            cell = new PdfPCell(new Phrase("Service By: Institute of Information Technology, Jahangirnagar University."));
            cell.HorizontalAlignment = 1;
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            tabFot.AddCell(cell);
            tabFot.WriteSelectedRows(0, -1, 0, document.Bottom, writer.DirectContent);
            
           
            
        }

        //write on close of document
        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
        }        
    }
}
