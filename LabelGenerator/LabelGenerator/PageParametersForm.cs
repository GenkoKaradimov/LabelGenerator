using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGenerator
{
    public partial class PageParametersForm : Form
    {
        private PageParametersModel _parameters;

        public PageParametersForm(PageParametersModel parameters)
        {
            InitializeComponent();

            _parameters = parameters;
            loadParamsOnForm();
        }

        private void loadParamsOnForm()
        {
            tb_contentToLeftCellBorder.Text = _parameters.ContentToLeftCellBorder.ToString("F1");
            tb_contentToBottomCellBorder.Text = _parameters.ContentToBottomCellBorder.ToString("F1");
            tb_cellWidth.Text = _parameters.CellWidth.ToString("F1");
            tb_cellHeight.Text = _parameters.CellHeight.ToString("F1");

            tb_textHeight.Text = _parameters.TextHeight.ToString("F1");
            tb_imageSize.Text = _parameters.ImageSize.ToString("F1");
            tb_distanceImageToText.Text = _parameters.DistanceImageToText.ToString("F1");
            tb_imageVerticalPosition.Text = _parameters.CorrectionImageVerticalPosition.ToString("F1");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            // restore default value`s of fields
            _parameters = new PageParametersModel();
            loadParamsOnForm();
        }

        private void btn_saveAndExit_Click(object sender, EventArgs e)
        {
            // save this value and close form

            if (float.TryParse(tb_contentToLeftCellBorder.Text, out float number1))
                _parameters.ContentToLeftCellBorder = number1;
            else
                MessageBox.Show("Invalid number format of: ContentToLeftCellBorder");

            if (float.TryParse(tb_contentToBottomCellBorder.Text, out float number2))
                _parameters.ContentToBottomCellBorder = number2;
            else
                MessageBox.Show("Invalid number format of: ContentToBottomCellBorder");

            if (float.TryParse(tb_cellWidth.Text, out float number3))
                _parameters.CellWidth = number3;
            else
                MessageBox.Show("Invalid number format of: ContentToLeftCellBorder");

            if (float.TryParse(tb_cellHeight.Text, out float number4))
                _parameters.CellHeight = number4;
            else
                MessageBox.Show("Invalid number format of: CellHeight");

            if (float.TryParse(tb_textHeight.Text, out float number5))
                _parameters.TextHeight = number5;
            else
                MessageBox.Show("Invalid number format of: TextHeight");

            if (float.TryParse(tb_imageSize.Text, out float number6))
                _parameters.ImageSize = number6;
            else
                MessageBox.Show("Invalid number format of: ImageSize");

            if (float.TryParse(tb_distanceImageToText.Text, out float number7))
                _parameters.DistanceImageToText = number7;
            else
                MessageBox.Show("Invalid number format of: DistanceImageToText");

            if (float.TryParse(tb_imageVerticalPosition.Text, out float number8))
                _parameters.CorrectionImageVerticalPosition = number8;
            else
                MessageBox.Show("Invalid number format of: CorrectionImageVerticalPosition");

            this.Close();
        }

        private void btn_loadParamsFromFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function not working yet");
        }

        private void btn_saveParamsToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function not working yet");
        }
    }
}
