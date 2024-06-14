using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace LabelGenerator
{
    public class PdfGenerator
    {
        public PdfGenerator() { }

        public void GeneratePdfPage(DataModel data, PageParametersModel param, string filePath)
        {
            Document document = new Document(PageSize.A4);

            // Create a PdfWriter instance
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Open the document to enable writing
            document.Open();

            // each of 8 rows
            for(int row = 0; row < 8; row++)
            {
                // each of 2 columns
                for(int col = 0; col < 2; col++)
                {
                    float x = param.CellWidth * col + param.ContentToLeftCellBorder;
                    float y = param.CellHeight * row + param.ContentToBottomCellBorder;


                    AddText(writer, data.CompanyName, x, y);
                    AddText(writer, data.ProductName, x, y - param.TextHeight);
                    AddText(writer, data.DisplayDateTime, x, y - 2 * param.TextHeight);
                    AddText(writer, "Serial Number: " + data.SerialNumbers[row], x, y - 3 * param.TextHeight);
                }
            }

            //AddText(writer, "(x, y)", 100f, 800f);
            //AddText(writer, "(200, 800)", 200f, 800f);
            //AddText(writer, "(300, 800)", 300f, 800f);
            //AddText(writer, "(100, 700)", 100f, 700f);
            //AddText(writer, "(200, 700)", 200f, 700f);
            //AddText(writer, "(300, 700)", 300f, 700f);
            //AddText(writer, "(100, 600)", 100f, 600f);
            //AddText(writer, "(200, 600)", 200f, 600f);
            //AddText(writer, "(300, 600)", 300f, 600f);
            //AddText(writer, "(100, 500)", 100f, 500f);
            //AddText(writer, "(200, 500)", 200f, 500f);
            //AddText(writer, "(300, 500)", 300f, 500f);
            //AddText(writer, "(100, 400)", 100f, 400f);
            //AddText(writer, "(200, 400)", 200f, 400f);
            //AddText(writer, "(300, 400)", 300f, 400f);
            //AddText(writer, "(100, 300)", 100f, 300f);
            //AddText(writer, "(200, 300)", 200f, 300f);
            //AddText(writer, "(300, 300)", 300f, 300f);
            //AddText(writer, "(100, 200)", 100f, 200f);
            //AddText(writer, "(200, 200)", 200f, 200f);
            //AddText(writer, "(300, 200)", 300f, 200f);
            //AddText(writer, "(100, 100)", 100f, 100f);
            //AddText(writer, "(200, 100)", 200f, 100f);
            //AddText(writer, "(300, 100)", 300f, 100f);
            //AddText(writer, "(0, 0)", 0f, 0f);

            document.Close();
        }

        private void AddText(PdfWriter writer, string text, float x, float y)
        {
            // Add text to the PDF at specific coordinates
            PdfContentByte cb = writer.DirectContent;
            cb.BeginText();
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetFontAndSize(bf, 12);
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, text, x, y, 0);

            cb.EndText();
        }
    }
}
