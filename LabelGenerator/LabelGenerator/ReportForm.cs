using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGenerator
{
    public partial class ReportForm : Form
    {
        private string _filePath { get; set; }

        public ReportForm(string filePath)
        {
            _filePath = filePath;

            InitializeComponent();

            lb_created.Text = "Created: " + DateTime.Now.ToString("HH:mm:ss dd-MMM-yyyy");
            lb_filePath.Text = _filePath;
        }

        private void btn_openPdf_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(_filePath);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while trying to open the PDF file: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    // Use explorer.exe to open the folder and select the file
                    string argument = "/select, \"" + _filePath + "\"";
                    Process.Start("explorer.exe", argument);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
