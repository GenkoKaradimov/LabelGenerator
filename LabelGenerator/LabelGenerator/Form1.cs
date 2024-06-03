using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Text;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Layout;

namespace LabelGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.tb_dateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string pdfPath = "example.pdf";

            using (PdfWriter writer = new PdfWriter(pdfPath))
            {
                // Create a PDF document instance
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    // Create a document to add elements
                    Document document = new Document(pdf);

                    // Add the first row of text
                    document.Add(new Paragraph("This is the first row of text."));

                    // Add the second row of text
                    document.Add(new Paragraph("This is the second row of text."));

                    // Load and add the image
                    // ImageData imageData = ImageDataFactory.Create(imagePath);
                    // Image image = new Image(imageData);

                    // You can set the position and size of the image if needed
                    // image.SetFixedPosition(100, 500);  // Example position
                    // image.ScaleToFit(200, 200);  // Example size

                    // document.Add(image);

                    // Close the document
                    document.Close();
                }
            }
        }
    }
}
