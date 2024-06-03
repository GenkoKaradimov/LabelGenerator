using System;

namespace LabelGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_companyName = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dateTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.tb_sn1 = new System.Windows.Forms.TextBox();
            this.tb_sn2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sn4 = new System.Windows.Forms.TextBox();
            this.tb_sn3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_sn8 = new System.Windows.Forms.TextBox();
            this.tb_sn7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_sn6 = new System.Windows.Forms.TextBox();
            this.tb_sn5 = new System.Windows.Forms.TextBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // tb_companyName
            // 
            this.tb_companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_companyName.Location = new System.Drawing.Point(17, 34);
            this.tb_companyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_companyName.Name = "tb_companyName";
            this.tb_companyName.Size = new System.Drawing.Size(306, 26);
            this.tb_companyName.TabIndex = 1;
            this.tb_companyName.Text = "IBPhotonics";
            // 
            // tb_productName
            // 
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productName.Location = new System.Drawing.Point(17, 90);
            this.tb_productName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(306, 26);
            this.tb_productName.TabIndex = 3;
            this.tb_productName.Text = "LDX220C-250u-10H-C3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // tb_dateTime
            // 
            this.tb_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dateTime.Location = new System.Drawing.Point(17, 146);
            this.tb_dateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_dateTime.Name = "tb_dateTime";
            this.tb_dateTime.Size = new System.Drawing.Size(306, 26);
            this.tb_dateTime.TabIndex = 5;
            this.tb_dateTime.Text = "03-Jun-2024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Display Date Time";
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(104, 452);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(219, 60);
            this.btn_generate.TabIndex = 26;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // tb_sn1
            // 
            this.tb_sn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn1.Location = new System.Drawing.Point(17, 248);
            this.tb_sn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn1.Name = "tb_sn1";
            this.tb_sn1.Size = new System.Drawing.Size(133, 26);
            this.tb_sn1.TabIndex = 7;
            // 
            // tb_sn2
            // 
            this.tb_sn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn2.Location = new System.Drawing.Point(190, 248);
            this.tb_sn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn2.Name = "tb_sn2";
            this.tb_sn2.Size = new System.Drawing.Size(133, 26);
            this.tb_sn2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Numbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SN 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "SN 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "SN 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "SN 3";
            // 
            // tb_sn4
            // 
            this.tb_sn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn4.Location = new System.Drawing.Point(190, 304);
            this.tb_sn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn4.Name = "tb_sn4";
            this.tb_sn4.Size = new System.Drawing.Size(133, 26);
            this.tb_sn4.TabIndex = 13;
            // 
            // tb_sn3
            // 
            this.tb_sn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn3.Location = new System.Drawing.Point(17, 304);
            this.tb_sn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn3.Name = "tb_sn3";
            this.tb_sn3.Size = new System.Drawing.Size(133, 26);
            this.tb_sn3.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 391);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "SN 8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 391);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "SN 7";
            // 
            // tb_sn8
            // 
            this.tb_sn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn8.Location = new System.Drawing.Point(190, 416);
            this.tb_sn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn8.Name = "tb_sn8";
            this.tb_sn8.Size = new System.Drawing.Size(133, 26);
            this.tb_sn8.TabIndex = 21;
            // 
            // tb_sn7
            // 
            this.tb_sn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn7.Location = new System.Drawing.Point(17, 416);
            this.tb_sn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn7.Name = "tb_sn7";
            this.tb_sn7.Size = new System.Drawing.Size(133, 26);
            this.tb_sn7.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(186, 335);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "SN 6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 335);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "SN 5";
            // 
            // tb_sn6
            // 
            this.tb_sn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn6.Location = new System.Drawing.Point(190, 360);
            this.tb_sn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn6.Name = "tb_sn6";
            this.tb_sn6.Size = new System.Drawing.Size(133, 26);
            this.tb_sn6.TabIndex = 17;
            // 
            // tb_sn5
            // 
            this.tb_sn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sn5.Location = new System.Drawing.Point(17, 360);
            this.tb_sn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sn5.Name = "tb_sn5";
            this.tb_sn5.Size = new System.Drawing.Size(133, 26);
            this.tb_sn5.TabIndex = 16;
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Location = new System.Drawing.Point(17, 452);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(60, 60);
            this.btn_settings.TabIndex = 24;
            this.btn_settings.Text = "S";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 525);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_sn8);
            this.Controls.Add(this.tb_sn7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_sn6);
            this.Controls.Add(this.tb_sn5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_sn4);
            this.Controls.Add(this.tb_sn3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_sn2);
            this.Controls.Add(this.tb_sn1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tb_dateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_companyName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_companyName;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox tb_sn1;
        private System.Windows.Forms.TextBox tb_sn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_sn4;
        private System.Windows.Forms.TextBox tb_sn3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_sn8;
        private System.Windows.Forms.TextBox tb_sn7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_sn6;
        private System.Windows.Forms.TextBox tb_sn5;
        private System.Windows.Forms.Button btn_settings;
    }
}

