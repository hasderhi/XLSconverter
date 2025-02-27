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
            label3 = new Label();
            btnSelectFolder = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 10F);
            btnConvert.Location = new Point(8, 218);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(148, 46);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert to .xlsx";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(162, 132);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(216, 23);
            txtFilePath.TabIndex = 2;
            txtFilePath.TextChanged += textBox1_TextChanged;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(8, 130);
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
            label1.Font = new Font("Segoe UI", 46F);
            label1.Location = new Point(116, 14);
            label1.Name = "label1";
            label1.Size = new Size(393, 84);
            label1.TabIndex = 0;
            label1.Text = "XLSconverter";
            label1.Click += label1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStatus.ForeColor = Color.DarkGreen;
            lblStatus.Location = new Point(74, 187);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(487, 60);
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
            linkLabel1.Location = new Point(322, 243);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(247, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/hasderhi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(379, 218);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 7;
            label3.Text = "Version 1.0.1 (Release)";
            label3.Click += label3_Click_1;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(8, 160);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(148, 24);
            btnSelectFolder.TabIndex = 5;
            btnSelectFolder.Text = "Select and convert Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(162, 163);
            label4.Name = "label4";
            label4.Size = new Size(201, 19);
            label4.TabIndex = 8;
            label4.Text = "Conversion starts automatically";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(8, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 98);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(384, 133);
            label5.Name = "label5";
            label5.Size = new Size(127, 19);
            label5.TabIndex = 10;
            label5.Text = "Conversion manual";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.Location = new Point(12, 187);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 11;
            label6.Text = "State:";
            // 
            // xlsconv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(581, 273);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnSelectFolder);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(btnConvert);
            Controls.Add(txtFilePath);
            Controls.Add(btnSelectFile);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "xlsconv";
            Text = "xlsConverter by tk_dev";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label3;
        private Button btnSelectFolder;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
    }
}
