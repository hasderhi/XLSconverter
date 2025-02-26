namespace XLSconverter
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using NPOI.HSSF.UserModel; // For reading .xls
    using NPOI.SS.UserModel;   // For handling Excel sheets
    using ClosedXML.Excel;     // For writing .xlsx

    public partial class xlsconv : Form
    {
        public xlsconv()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel 97-2003 (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Please select a valid .xls file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask the user where to save the .xlsx file
            saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(txtFilePath.Text) + ".xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                ConvertXlsToXlsx(txtFilePath.Text, saveFileDialog1.FileName);
                lblStatus.Text = "Conversion successful!";
                MessageBox.Show("File converted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Conversion failed!";
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConvertXlsToXlsx(string xlsPath, string xlsxPath)
        {
            Console.WriteLine("Started");
            using (FileStream file = new FileStream(xlsPath, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new HSSFWorkbook(file); // Read .xls
                using (var newWorkbook = new XLWorkbook())  // Create .xlsx
                {
                    for (int i = 0; i < workbook.NumberOfSheets; i++)
                    {
                        ISheet sheet = workbook.GetSheetAt(i);
                        var newSheet = newWorkbook.Worksheets.Add(sheet.SheetName);

                        for (int row = 0; row <= sheet.LastRowNum; row++)
                        {
                            IRow sourceRow = sheet.GetRow(row);
                            if (sourceRow != null)
                            {
                                for (int col = 0; col < sourceRow.LastCellNum; col++)
                                {
                                    ICell cell = sourceRow.GetCell(col);
                                    if (cell != null)
                                    {
                                        newSheet.Cell(row + 1, col + 1).Value = cell.ToString();
                                    }
                                }
                            }
                        }
                    }

                    newWorkbook.SaveAs(xlsxPath);
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
