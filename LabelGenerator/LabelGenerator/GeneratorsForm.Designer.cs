namespace LabelGenerator
{
    partial class GeneratorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateStartToEnd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_s2e_end = new System.Windows.Forms.NumericUpDown();
            this.tb_s2e_start = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_s2e_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_s2e_start)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateStartToEnd
            // 
            this.btnGenerateStartToEnd.Location = new System.Drawing.Point(245, 45);
            this.btnGenerateStartToEnd.Name = "btnGenerateStartToEnd";
            this.btnGenerateStartToEnd.Size = new System.Drawing.Size(90, 26);
            this.btnGenerateStartToEnd.TabIndex = 2;
            this.btnGenerateStartToEnd.Text = "Generate";
            this.btnGenerateStartToEnd.UseVisualStyleBackColor = true;
            this.btnGenerateStartToEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "End SN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start SN:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_s2e_end);
            this.groupBox1.Controls.Add(this.tb_s2e_start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGenerateStartToEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate range of serial numbers";
            // 
            // tb_s2e_end
            // 
            this.tb_s2e_end.Location = new System.Drawing.Point(127, 45);
            this.tb_s2e_end.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tb_s2e_end.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.tb_s2e_end.Name = "tb_s2e_end";
            this.tb_s2e_end.Size = new System.Drawing.Size(100, 26);
            this.tb_s2e_end.TabIndex = 7;
            // 
            // tb_s2e_start
            // 
            this.tb_s2e_start.Location = new System.Drawing.Point(10, 46);
            this.tb_s2e_start.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tb_s2e_start.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.tb_s2e_start.Name = "tb_s2e_start";
            this.tb_s2e_start.Size = new System.Drawing.Size(100, 26);
            this.tb_s2e_start.TabIndex = 6;
            // 
            // GeneratorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 127);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "GeneratorsForm";
            this.Text = "SN Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_s2e_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_s2e_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerateStartToEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown tb_s2e_end;
        private System.Windows.Forms.NumericUpDown tb_s2e_start;
    }
}