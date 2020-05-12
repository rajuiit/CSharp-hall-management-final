﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Hall_Management_System.Report
{
    class PDFWriterEvents : IPdfPageEvent
    {
        string watermarkText;
        float fontSize = 80f;
        float xPosition = 300f;
        float yPosition = 800f;
        float angle = 45f;

        public PDFWriterEvents(string watermarkText, float fontSize = 80f,
           float xPosition = 300f, float yPosition = 400f, float angle = 45f)
        {
            this.watermarkText = watermarkText;
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.fontSize = fontSize;
            this.angle = angle;
        }

        public void OnOpenDocument(PdfWriter writer, Document document) { }
        public void OnCloseDocument(PdfWriter writer, Document document) { }
        public void OnStartPage(PdfWriter writer, Document document)
        {
            try
            {
                PdfContentByte cb = writer.DirectContentUnder;
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.EMBEDDED);
                cb.BeginText();
                cb.SetColorFill(BaseColor.LIGHT_GRAY);
                cb.SetFontAndSize(baseFont, fontSize);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, watermarkText, xPosition, yPosition, angle);
                cb.EndText();
            }
            catch (DocumentException docEx)
            {
                throw docEx;
            }
        }
        public void OnEndPage(PdfWriter writer, Document document) { }
        public void OnParagraph(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnParagraphEnd(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnChapter(PdfWriter writer, Document document, float paragraphPosition, Paragraph title) { }
        public void OnChapterEnd(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnSection(PdfWriter writer, Document document, float paragraphPosition, int depth, Paragraph title) { }
        public void OnSectionEnd(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnGenericTag(PdfWriter writer, Document document, Rectangle rect, String text) { }
    }
}
