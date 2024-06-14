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
        private PdfGenerator _pdf { get; set; }
        private PageParametersModel _parameters { get; set; }

        public Form1()
        {
            _pdf = new PdfGenerator();
            _parameters = new PageParametersModel();

            InitializeComponent();
            this.tb_dateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            DataModel data = new DataModel() { 
                CompanyName = this.tb_companyName.Text,
                ProductName = this.tb_productName.Text,
                DisplayDateTime = this.tb_dateTime.Text,
                SerialNumbers = new List<string>()
            };

            data.SerialNumbers.Add(this.tb_sn1.Text);
            data.SerialNumbers.Add(this.tb_sn2.Text);
            data.SerialNumbers.Add(this.tb_sn3.Text);
            data.SerialNumbers.Add(this.tb_sn4.Text);
            data.SerialNumbers.Add(this.tb_sn5.Text);
            data.SerialNumbers.Add(this.tb_sn6.Text);
            data.SerialNumbers.Add(this.tb_sn7.Text);
            data.SerialNumbers.Add(this.tb_sn8.Text);



            string pdfPath = "example.pdf";

            _pdf.GeneratePdfPage(data, _parameters, pdfPath);

            //using (PdfWriter writer = new PdfWriter(pdfPath))
            //{
            //    // Create a PDF document instance
            //    using (PdfDocument pdf = new PdfDocument(writer))
            //    {
            //        // Create a document to add elements
            //        Document document = new Document(pdf);

            //        // Add the first row of text
            //        document.Add(new Paragraph("This is the first row of text."));

            //        // Add the second row of text
            //        document.Add(new Paragraph("This is the second row of text."));

            //        // Load and add the image
            //        // ImageData imageData = ImageDataFactory.Create(imagePath);
            //        // Image image = new Image(imageData);

            //        // You can set the position and size of the image if needed
            //        // image.SetFixedPosition(100, 500);  // Example position
            //        // image.ScaleToFit(200, 200);  // Example size

            //        // document.Add(image);

            //        // Close the document
            //        document.Close();
            //    }
            //}
        }
    }
}
