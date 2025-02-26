namespace XLSconverter
{
    partial class xlsconv
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xlsconv));
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            btnConvert = new Button();
            txtFilePath = new TextBox();
            btnSelectFile = new Button();
            label1 = new Label();
            lblStatus = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 10F);
            btnConvert.Location = new Point(12, 159);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(148, 46);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert to .xlsx";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(166, 102);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(258, 23);
            txtFilePath.TabIndex = 2;
            txtFilePath.TextChanged += textBox1_TextChanged;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(12, 101);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(148, 24);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Select .xls file";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 42F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(354, 74);
            label1.TabIndex = 0;
            label1.Text = "XLSconverter";
            label1.Click += label1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 141);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(342, 49);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 5;
            label2.Text = "by tk_dev";
            label2.Click += label2_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14F);
            linkLabel1.Location = new Point(185, 180);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(247, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/hasderhi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 102);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // xlsconv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(444, 214);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(btnConvert);
            Controls.Add(textBox1);
            Controls.Add(txtFilePath);
            Controls.Add(btnSelectFile);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "xlsconv";
            Text = "xlsConverter by tk_dev";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnConvert;
        private TextBox txtFilePath;
        private Button btnSelectFile;
        private Label label1;
        private Label lblStatus;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
    }
}
