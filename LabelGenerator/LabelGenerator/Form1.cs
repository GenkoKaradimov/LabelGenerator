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
using System.Diagnostics;

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
            this.tb_path.Text = Path.Combine(Directory.GetCurrentDirectory(), "example.pdf");
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



            string filePath = this.tb_path.Text;

            _pdf.GeneratePdfPage(data, _parameters, filePath);

            ReportForm report = new ReportForm(filePath);
            report.ShowDialog();
        }

        private void btn_openPathFolder_Click(object sender, EventArgs e)
        {
            string filePath = this.tb_path.Text;

            try
            {
                if (File.Exists(filePath))
                {
                    // Use explorer.exe to open the folder and select the file
                    string argument = "/select, \"" + filePath + "\"";
                    Process.Start("explorer.exe", argument);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btn_changePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf|All (*.*)|*.*";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = saveFileDialog.FileName;
            }
        }

        private void btn_sn1ToEnd_Click(object sender, EventArgs e)
        {

            if (this.tb_sn1.Text != "")
            {
                if (int.TryParse(this.tb_sn1.Text, out int sn1))
                {
                    // MessageBox.Show($"Parsed number: {sn1}");
                    this.tb_sn2.Text = (sn1 + 1).ToString();
                    this.tb_sn3.Text = (sn1 + 2).ToString();
                    this.tb_sn4.Text = (sn1 + 3).ToString();
                    this.tb_sn5.Text = (sn1 + 4).ToString();
                    this.tb_sn6.Text = (sn1 + 5).ToString();
                    this.tb_sn7.Text = (sn1 + 6).ToString();
                    this.tb_sn8.Text = (sn1 + 7).ToString();
                    return;
                }
            }

            // error
            MessageBox.Show(
                    "Value of \"SN1\" must be integer! Subsequent fields will be automatically filled in, each subsequent field being one larger.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btn_clearSN_Click(object sender, EventArgs e)
        {
            this.tb_sn1.Text = "";
            this.tb_sn2.Text = "";
            this.tb_sn3.Text = "";
            this.tb_sn4.Text = "";
            this.tb_sn5.Text = "";
            this.tb_sn6.Text = "";
            this.tb_sn7.Text = "";
            this.tb_sn8.Text = "";
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            PageParametersForm pageParametersForm = new PageParametersForm(_parameters);
            pageParametersForm.ShowDialog();
        }
    }
}
