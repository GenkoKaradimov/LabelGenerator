using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;
using iText.IO.Image;
using Image = iTextSharp.text.Image;


namespace LabelGenerator
{
    public class PdfGenerator
    {
        public PdfGenerator() { }

        public void GenerateMultiPagePdf(DataModel data, PageParametersModel param, string filePath)
        {
            Document document = new Document(PageSize.A4);

            // Create a PdfWriter instance
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Open the document to enable writing
            document.Open();

            int labelRowsPerUnit = data.LabelsPerUnit / 2;

            List<string> serialNumbers = new List<string>();

            foreach(string u in data.SerialNumbers)
            {
                for(int i = 0; i < labelRowsPerUnit; i++)
                serialNumbers.Add(u);
            }

            int toAdd = 8 - (serialNumbers.Count % 8);
            if (toAdd == 8) toAdd = 0;

            for(int i = 0; i <toAdd; i++)
            {
                serialNumbers.Add(""); // no text - SN can be write manualy
            }

            for(int pg = 0; pg < serialNumbers.Count / 8; pg++)
            {
                // each of 8 rows on page
                for (int row = 0; row < 8; row++)
                {
                    // each of 2 columns
                    for (int col = 0; col < 2; col++)
                    {
                        float x = param.CellWidth * col + param.ContentToLeftCellBorder;
                        float y = param.CellHeight * row + param.ContentToBottomCellBorder;

                        AddText(writer, data.CompanyName, x + param.ImageSize + param.DistanceImageToText, y);
                        AddText(writer, data.ProductName, x + param.ImageSize + param.DistanceImageToText, y - param.TextHeight);
                        AddText(writer, data.DisplayDateTime, x + param.ImageSize + param.DistanceImageToText, y - 2 * param.TextHeight);
                        AddText(writer, "Serial Number: " + serialNumbers[row + pg * 8], x + param.ImageSize + param.DistanceImageToText, y - 3 * param.TextHeight);

                        string qrText = data.CompanyName + System.Environment.NewLine + data.ProductName + System.Environment.NewLine;
                        qrText += data.DisplayDateTime + System.Environment.NewLine + "Serial Number: " + serialNumbers[row + pg * 8];

                        AddQRCode(document, x, y + param.CorrectionImageVerticalPosition, param.ImageSize, qrText);

                    }
                }

                document.NewPage();
            }

           

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

        private void AddQRCode(Document document, float x, float y, float imgSize, string text)
        {
            Image img = Image.GetInstance(GenerateQRCode(text));
            img.SetAbsolutePosition(x, y); // Set the coordinates for the image
            img.ScaleAbsolute(imgSize, imgSize);
            document.Add(img);
        }

        private byte[] GenerateQRCode(string text)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeBitmap = qrCode.GetGraphic(20);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        qrCodeBitmap.Save(ms, ImageFormat.Png); 
                        return ms.ToArray();
                    }
                }
            }
        }
    }
}
