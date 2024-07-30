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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_changePath = new System.Windows.Forms.Button();
            this.btn_openPathFolder = new System.Windows.Forms.Button();
            this.btn_clearSN = new System.Windows.Forms.Button();
            this.btn_snAdd = new System.Windows.Forms.Button();
            this.lb_serialNumbers = new System.Windows.Forms.ListBox();
            this.btn_sn_generate = new System.Windows.Forms.Button();
            this.rb_lpu_2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_lpu_4 = new System.Windows.Forms.RadioButton();
            this.rb_lpu_8 = new System.Windows.Forms.RadioButton();
            this.tb_newSN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.btn_generate.Location = new System.Drawing.Point(131, 311);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(431, 60);
            this.btn_generate.TabIndex = 26;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Numbers";
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Location = new System.Drawing.Point(17, 311);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(106, 60);
            this.btn_settings.TabIndex = 24;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.Location = new System.Drawing.Point(17, 275);
            this.tb_path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(306, 26);
            this.tb_path.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 240);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "File path";
            // 
            // btn_changePath
            // 
            this.btn_changePath.Location = new System.Drawing.Point(207, 233);
            this.btn_changePath.Name = "btn_changePath";
            this.btn_changePath.Size = new System.Drawing.Size(116, 34);
            this.btn_changePath.TabIndex = 29;
            this.btn_changePath.Text = "Change path";
            this.btn_changePath.UseVisualStyleBackColor = true;
            this.btn_changePath.Click += new System.EventHandler(this.btn_changePath_Click);
            // 
            // btn_openPathFolder
            // 
            this.btn_openPathFolder.Location = new System.Drawing.Point(94, 233);
            this.btn_openPathFolder.Name = "btn_openPathFolder";
            this.btn_openPathFolder.Size = new System.Drawing.Size(107, 34);
            this.btn_openPathFolder.TabIndex = 30;
            this.btn_openPathFolder.Text = "Open Folder";
            this.btn_openPathFolder.UseVisualStyleBackColor = true;
            this.btn_openPathFolder.Click += new System.EventHandler(this.btn_openPathFolder_Click);
            // 
            // btn_clearSN
            // 
            this.btn_clearSN.Location = new System.Drawing.Point(478, 68);
            this.btn_clearSN.Name = "btn_clearSN";
            this.btn_clearSN.Size = new System.Drawing.Size(84, 36);
            this.btn_clearSN.TabIndex = 31;
            this.btn_clearSN.Text = "Clear All";
            this.btn_clearSN.UseVisualStyleBackColor = true;
            this.btn_clearSN.Click += new System.EventHandler(this.btn_clearSN_Click);
            // 
            // btn_snAdd
            // 
            this.btn_snAdd.Location = new System.Drawing.Point(519, 34);
            this.btn_snAdd.Name = "btn_snAdd";
            this.btn_snAdd.Size = new System.Drawing.Size(43, 26);
            this.btn_snAdd.TabIndex = 32;
            this.btn_snAdd.Text = "+";
            this.btn_snAdd.UseVisualStyleBackColor = true;
            this.btn_snAdd.Click += new System.EventHandler(this.btn_sn1ToEnd_Click);
            // 
            // lb_serialNumbers
            // 
            this.lb_serialNumbers.FormattingEnabled = true;
            this.lb_serialNumbers.ItemHeight = 20;
            this.lb_serialNumbers.Location = new System.Drawing.Point(339, 117);
            this.lb_serialNumbers.Name = "lb_serialNumbers";
            this.lb_serialNumbers.Size = new System.Drawing.Size(223, 184);
            this.lb_serialNumbers.TabIndex = 33;
            // 
            // btn_sn_generate
            // 
            this.btn_sn_generate.Location = new System.Drawing.Point(339, 68);
            this.btn_sn_generate.Name = "btn_sn_generate";
            this.btn_sn_generate.Size = new System.Drawing.Size(133, 36);
            this.btn_sn_generate.TabIndex = 34;
            this.btn_sn_generate.Text = "SN Generate";
            this.btn_sn_generate.UseVisualStyleBackColor = true;
            this.btn_sn_generate.Click += new System.EventHandler(this.btn_sn_generate_Click);
            // 
            // rb_lpu_2
            // 
            this.rb_lpu_2.AutoSize = true;
            this.rb_lpu_2.Location = new System.Drawing.Point(6, 19);
            this.rb_lpu_2.Name = "rb_lpu_2";
            this.rb_lpu_2.Size = new System.Drawing.Size(31, 17);
            this.rb_lpu_2.TabIndex = 35;
            this.rb_lpu_2.Text = "2";
            this.rb_lpu_2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_lpu_4);
            this.groupBox1.Controls.Add(this.rb_lpu_2);
            this.groupBox1.Controls.Add(this.rb_lpu_8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 42);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LABELS PER UNIT";
            // 
            // rb_lpu_4
            // 
            this.rb_lpu_4.AutoSize = true;
            this.rb_lpu_4.Checked = true;
            this.rb_lpu_4.Location = new System.Drawing.Point(43, 19);
            this.rb_lpu_4.Name = "rb_lpu_4";
            this.rb_lpu_4.Size = new System.Drawing.Size(31, 17);
            this.rb_lpu_4.TabIndex = 37;
            this.rb_lpu_4.TabStop = true;
            this.rb_lpu_4.Text = "4";
            this.rb_lpu_4.UseVisualStyleBackColor = true;
            this.rb_lpu_4.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_lpu_8
            // 
            this.rb_lpu_8.AutoSize = true;
            this.rb_lpu_8.Location = new System.Drawing.Point(87, 19);
            this.rb_lpu_8.Name = "rb_lpu_8";
            this.rb_lpu_8.Size = new System.Drawing.Size(31, 17);
            this.rb_lpu_8.TabIndex = 38;
            this.rb_lpu_8.Text = "8";
            this.rb_lpu_8.UseVisualStyleBackColor = true;
            // 
            // tb_newSN
            // 
            this.tb_newSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newSN.Location = new System.Drawing.Point(339, 34);
            this.tb_newSN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_newSN.Name = "tb_newSN";
            this.tb_newSN.Size = new System.Drawing.Size(173, 26);
            this.tb_newSN.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 382);
            this.Controls.Add(this.tb_newSN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sn_generate);
            this.Controls.Add(this.lb_serialNumbers);
            this.Controls.Add(this.btn_snAdd);
            this.Controls.Add(this.btn_clearSN);
            this.Controls.Add(this.btn_openPathFolder);
            this.Controls.Add(this.btn_changePath);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tb_dateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_companyName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Label Generator - IBPhotonics Ltd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_changePath;
        private System.Windows.Forms.Button btn_openPathFolder;
        private System.Windows.Forms.Button btn_clearSN;
        private System.Windows.Forms.Button btn_snAdd;
        private System.Windows.Forms.ListBox lb_serialNumbers;
        private System.Windows.Forms.Button btn_sn_generate;
        private System.Windows.Forms.RadioButton rb_lpu_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_lpu_4;
        private System.Windows.Forms.RadioButton rb_lpu_8;
        private System.Windows.Forms.TextBox tb_newSN;
    }
}

