namespace ENEL300_Project_App
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_excel_data_load = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_file_close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_plot_historical_data_show = new System.Windows.Forms.Button();
            this.btn_plot_historical_data_clear = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_data_store_start = new System.Windows.Forms.Button();
            this.btn_data_store_stop = new System.Windows.Forms.Button();
            this.btn_reset_data = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save_plot = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 131);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(513, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 19);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(177, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accelerometre Data Simulator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(495, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 14);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ENEL300_Project_App.Properties.Resources.uniLogo;
            this.pictureBox1.ErrorImage = global::ENEL300_Project_App.Properties.Resources.Capture;
            this.pictureBox1.InitialImage = global::ENEL300_Project_App.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(16, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 86);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please select the port number.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(167, 188);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(72, 21);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-4, 803);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1224, 63);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel5.Location = new System.Drawing.Point(3, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1214, 40);
            this.panel5.TabIndex = 6;
            // 
            // btn_excel_data_load
            // 
            this.btn_excel_data_load.Location = new System.Drawing.Point(19, 58);
            this.btn_excel_data_load.Name = "btn_excel_data_load";
            this.btn_excel_data_load.Size = new System.Drawing.Size(106, 22);
            this.btn_excel_data_load.TabIndex = 6;
            this.btn_excel_data_load.Text = "Open and Read File";
            this.btn_excel_data_load.UseVisualStyleBackColor = true;
            this.btn_excel_data_load.Click += new System.EventHandler(this.btn_excel_data_load_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click the button below to load data set from the excel.";
            // 
            // btn_file_close
            // 
            this.btn_file_close.Location = new System.Drawing.Point(147, 58);
            this.btn_file_close.Name = "btn_file_close";
            this.btn_file_close.Size = new System.Drawing.Size(106, 22);
            this.btn_file_close.TabIndex = 8;
            this.btn_file_close.Text = "Close";
            this.btn_file_close.UseVisualStyleBackColor = true;
            this.btn_file_close.Click += new System.EventHandler(this.btn_file_close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 257);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Historical Data Plot";
            // 
            // btn_plot_historical_data_show
            // 
            this.btn_plot_historical_data_show.Location = new System.Drawing.Point(322, 15);
            this.btn_plot_historical_data_show.Name = "btn_plot_historical_data_show";
            this.btn_plot_historical_data_show.Size = new System.Drawing.Size(72, 21);
            this.btn_plot_historical_data_show.TabIndex = 11;
            this.btn_plot_historical_data_show.Text = "Show";
            this.btn_plot_historical_data_show.UseVisualStyleBackColor = true;
            this.btn_plot_historical_data_show.Click += new System.EventHandler(this.btn_plot_historical_data_show_Click);
            // 
            // btn_plot_historical_data_clear
            // 
            this.btn_plot_historical_data_clear.Location = new System.Drawing.Point(400, 15);
            this.btn_plot_historical_data_clear.Name = "btn_plot_historical_data_clear";
            this.btn_plot_historical_data_clear.Size = new System.Drawing.Size(72, 21);
            this.btn_plot_historical_data_clear.TabIndex = 12;
            this.btn_plot_historical_data_clear.Text = "Clear";
            this.btn_plot_historical_data_clear.UseVisualStyleBackColor = true;
            this.btn_plot_historical_data_clear.Click += new System.EventHandler(this.btn_plot_historical_data_clear_Click);
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(32, 67);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(510, 304);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "App Directory: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_data_store_start
            // 
            this.btn_data_store_start.Location = new System.Drawing.Point(43, 259);
            this.btn_data_store_start.Name = "btn_data_store_start";
            this.btn_data_store_start.Size = new System.Drawing.Size(113, 22);
            this.btn_data_store_start.TabIndex = 16;
            this.btn_data_store_start.Text = "Start to store data";
            this.btn_data_store_start.UseVisualStyleBackColor = true;
            this.btn_data_store_start.Click += new System.EventHandler(this.btn_data_store_start_Click);
            // 
            // btn_data_store_stop
            // 
            this.btn_data_store_stop.Location = new System.Drawing.Point(167, 259);
            this.btn_data_store_stop.Name = "btn_data_store_stop";
            this.btn_data_store_stop.Size = new System.Drawing.Size(113, 22);
            this.btn_data_store_stop.TabIndex = 17;
            this.btn_data_store_stop.Text = " Stop to store data";
            this.btn_data_store_stop.UseVisualStyleBackColor = true;
            this.btn_data_store_stop.Click += new System.EventHandler(this.btn_data_store_stop_Click);
            // 
            // btn_reset_data
            // 
            this.btn_reset_data.Location = new System.Drawing.Point(296, 259);
            this.btn_reset_data.Name = "btn_reset_data";
            this.btn_reset_data.Size = new System.Drawing.Size(113, 22);
            this.btn_reset_data.TabIndex = 18;
            this.btn_reset_data.Text = "Reset the data";
            this.btn_reset_data.UseVisualStyleBackColor = true;
            this.btn_reset_data.Click += new System.EventHandler(this.btn_reset_data_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(0, 768);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(936, 38);
            this.panel7.TabIndex = 19;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Group 12";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_save_plot
            // 
            this.btn_save_plot.Location = new System.Drawing.Point(478, 15);
            this.btn_save_plot.Name = "btn_save_plot";
            this.btn_save_plot.Size = new System.Drawing.Size(72, 21);
            this.btn_save_plot.TabIndex = 20;
            this.btn_save_plot.Text = "Download";
            this.btn_save_plot.UseVisualStyleBackColor = true;
            this.btn_save_plot.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 300);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 411);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_excel_data_load);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_file_close);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_save_plot);
            this.tabPage2.Controls.Add(this.btn_plot_historical_data_show);
            this.tabPage2.Controls.Add(this.btn_plot_historical_data_clear);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(526, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Please use the buttons below to start, stop, or reset data logging in the Excel f" +
    "ile.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 799);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btn_reset_data);
            this.Controls.Add(this.btn_data_store_stop);
            this.Controls.Add(this.btn_data_store_start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_excel_data_load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_file_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_plot_historical_data_show;
        private System.Windows.Forms.Button btn_plot_historical_data_clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_data_store_start;
        private System.Windows.Forms.Button btn_data_store_stop;
        private System.Windows.Forms.Button btn_reset_data;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save_plot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
    }
}

