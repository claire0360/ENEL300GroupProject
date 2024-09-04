using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO.Ports;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;
using System.Management;
using IronXL;
using ZedGraph;
using System.Windows.Forms.DataVisualization.Charting;
using Color = System.Drawing.Color;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace ENEL300_Project_App
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort serialPort;
        private string excelFilePath;

        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        private bool isLogging = false;
        private DateTime startTime;

        public Form1()
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600; // maybe need to change baudrate
            InitializeComponent();
            ScanComPorts();

            tabPage1.Text = "Data Grid";
            tabPage2.Text = "Historical Data Chart";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Set label6 to display the directory path
            label6.Text = $"Application Directory: {appDirectory}";
            excelFilePath = System.IO.Path.Combine(appDirectory, "accel_data.xlsx");
            // Optionally create the Excel file if it does not exist
            CreateNewExcelFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);
            Series series = new Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Line

            };
            chart1.Series.Add(series);
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            //chart1.ChartAreas[0].AxisX.Title("x");
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //btn_connect.Text = "Connected";
            //btn_connect.BackColor = Color.LightGreen;

            string selectedPort = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Please select a COM port from the list.");
                btn_connect.BackColor = Color.LightCoral;
                return;
            }

            string deviceName = GetDeviceNameForComPort(selectedPort);

            if (!string.IsNullOrEmpty(deviceName))// && deviceName.Contains("CH340")) // need to change string depends on the usb cable we use
            {
                serialPort.PortName = selectedPort;
                serialPort.DataReceived += SerialPort_DataReceived; // Attach event handler ADDED 01-09-2024
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    btn_connect.BackColor = Color.LightGreen;
                    btn_connect.Text = "Connected";
                    //MessageBox.Show("Connected");
                }
                else
                {
                    MessageBox.Show("Error: Valid COM Port but connection failed");
                    btn_connect.BackColor = Color.LightCoral;
                    btn_connect.Text = "Connect";
                    //errorProvider3.SetError=(comboBox1,)
                }
            }
            else
            {
                //errorProvider3.SetError = (comboBox1, "Error: Device not found or incorrect device.");
                MessageBox.Show("Error: Device not found or incorrect device.");
                btn_connect.BackColor = Color.LightCoral;
                btn_connect.Text = "Connect";
            }

            /*
            flag_panel *= -1;
            if (flag_panel == 1)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ScanComPorts()
        {
            // Get all available COM ports
            string[] comPorts = SerialPort.GetPortNames();

            //use a ComboBox to list the COM ports
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(comPorts);
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }


        private string GetDeviceNameForComPort(string comPort)
        {
            string query = "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(" + comPort + ")%'";
            using (var searcher = new ManagementObjectSearcher(query))
            {
                foreach (var device in searcher.Get())
                {
                    return device.GetPropertyValue("Name") as string;
                }
            }
            return null; // Return null if the device is not found
        }

        private DataTable ReadExcel (string fileName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            WorkSheet sheet = workbook.DefaultWorkSheet;
            return sheet.ToDataTable(true);
        }
        private void btn_excel_data_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileExt = Path.GetExtension(file.FileName);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = ReadExcel(file.FileName);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a valid file type.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_file_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_plot_historical_data_show_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                MessageBox.Show("No Excel file loaded. Please load an Excel file first.");
                return;
            }

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(excelFilePath);
                worksheet = workbook.Worksheets[1] as Excel.Worksheet;

                // Clear existing points
                chart1.Series.Clear(); // Clear existing series
                Series series = new Series
                {
                    Name = "Data Series",
                    Color = Color.Blue,
                    ChartType = SeriesChartType.Line
                };
                chart1.Series.Add(series);

                // Read data from the Excel file
                int row = 2; // Start from row 2 to skip headers
                int index = 1; // X-axis index
                while (worksheet.Cells[row, 2].Value != null)
                {
                    var dataCell = worksheet.Cells[row, 2]?.Value2;

                    if (dataCell != null)
                    {
                        if (double.TryParse(dataCell.ToString(), out double dataValue))
                        {
                            // Add data point to chart
                            series.Points.AddXY(index, dataValue);
                            index++;
                        }
                        else
                        {
                            MessageBox.Show($"Invalid data at row {row}. Skipping this row.");
                        }
                    }
                    row++;
                }

                // Format chart
                chart1.ChartAreas[0].AxisX.Title = "Index";
                chart1.ChartAreas[0].AxisY.Title = "Data";

                // Cleanup
                workbook.Close(false);
                excelApp.Quit();
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();

                MessageBox.Show("Data plotted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while plotting data: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    //serialPort.WriteLine("check_connection");
                    string response = serialPort.ReadLine().Trim();
                    label5.Text = response;
                }
                else
                {
                    MessageBox.Show("Serial port is not open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error communicating with serial port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            

        }

        private void CreateNewExcelFile()
        {
            // Check if the file already exists
            if (!System.IO.File.Exists(excelFilePath))
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];


                // Optionally, set some headers or initial content
                worksheet.Cells[1, 1] = "Timestamp";
                worksheet.Cells[1, 2] = "Data";

                // Save the workbook
                workbook.SaveAs(excelFilePath);

                // Clean up
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }

        //ADDED 01-09-2024
        private void btn_data_store_start_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Serial port is not open.");
                return;
            }

            isLogging = true;
            startTime = DateTime.Now;
            MessageBox.Show("Data logging started.");
        }

        private void btn_data_store_stop_Click(object sender, EventArgs e)
        {
            isLogging = false;
            SaveAndCloseExcelFile();
            MessageBox.Show("Data logging stopped.");
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isLogging) return;

            string data = serialPort.ReadLine();
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");

            // Append data to Excel
            if (excelApp == null) InitializeExcel();
            int row = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row + 1;
            worksheet.Cells[row, 1] = timestamp;
            worksheet.Cells[row, 2] = data;
        }

        private void InitializeExcel()
        {
            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Open(excelFilePath);
            worksheet = (Excel.Worksheet)workbook.Worksheets[1];
        }



        private void SaveAndCloseExcelFile()
        {
            if (excelApp != null)
            {
                workbook.Save();
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
                excelApp = null;
            }
        }

        private void btn_reset_data_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the Excel application
                if (excelApp == null)
                {
                    excelApp = new Excel.Application();
                }

                // Open the existing workbook
                if (File.Exists(excelFilePath))
                {
                    workbook = excelApp.Workbooks.Open(excelFilePath);
                    worksheet = workbook.Worksheets[1] as Excel.Worksheet;

                    // Determine the last used row and delete rows below the header
                    int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                    if (lastRow > 1) // Assuming row 1 is the header
                    {
                        Excel.Range range = worksheet.Rows["2:" + lastRow];
                        range.Delete();
                    }

                    // Save and close the workbook
                    workbook.Save();
                    workbook.Close();
                    excelApp.Quit();

                    // Release COM objects
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);

                    worksheet = null;
                    workbook = null;
                    excelApp = null;

                    MessageBox.Show("Excel file contents have been reset. Header preserved.");
                }
                else
                {
                    MessageBox.Show("Excel file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while resetting the Excel file: {ex.Message}");
            }
        }

        private void btn_plot_historical_data_clear_Click(object sender, EventArgs e)
        {
            // Clear existing points
            chart1.Series[0].Points.Clear();
            MessageBox.Show("Plot cleared.");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the directory where the application is running
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Generate a timestamp for the filename
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                // Construct the filename
                string fileName = $"dataplot_{timestamp}.png";
                string filePath = Path.Combine(appDirectory, fileName);

                // Save the chart as a PNG file
                chart1.SaveImage(filePath, ChartImageFormat.Png);

                // Notify the user
                MessageBox.Show($"Plot saved successfully at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the plot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }



}

