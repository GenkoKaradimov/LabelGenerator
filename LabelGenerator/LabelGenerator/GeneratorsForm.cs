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
    public partial class GeneratorsForm : Form
    {
        private Form1 _parent;
        public GeneratorsForm(Form1 parent)
        {
            _parent = parent;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generate serial numbers from start number to end number
            int startNumber = (int)tb_s2e_start.Value;
            int endNumber = (int)tb_s2e_end.Value;

            if(endNumber == startNumber)
            {
                MessageBox.Show("No numbers between!");
                return;
            }

            if (endNumber < startNumber)
            {
                MessageBox.Show("End number smaller than start number!");
                return;
            }

            int count = endNumber - startNumber;
            List<string> sns = new List<string>();

            for(int i = startNumber; i <= count + startNumber; i++)
            {
                sns.Add(i.ToString());
            }

            _parent.addSerialNumbers(sns);

            this.Close();
        }

    }
}
