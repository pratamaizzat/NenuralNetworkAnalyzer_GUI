namespace NeuralNetwork_2._0
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.HiddenLabel = new System.Windows.Forms.Label();
            this.HiddenPValue = new System.Windows.Forms.TextBox();
            this.EpochLabel = new System.Windows.Forms.Label();
            this.EpochValue = new System.Windows.Forms.ComboBox();
            this.Output2Value = new System.Windows.Forms.TextBox();
            this.Output1Value = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Target2Value = new System.Windows.Forms.TextBox();
            this.Input2Value = new System.Windows.Forms.TextBox();
            this.TrainButton = new System.Windows.Forms.Button();
            this.Target1Value = new System.Windows.Forms.TextBox();
            this.Target1Label = new System.Windows.Forms.Label();
            this.Input1Value = new System.Windows.Forms.TextBox();
            this.Input1Label = new System.Windows.Forms.Label();
            this.LoadRawButton = new System.Windows.Forms.Button();
            this.OpenSourceLabel = new System.Windows.Forms.Label();
            this.ErrorTotalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTotalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.White;
            this.Sidebar.Controls.Add(this.HiddenLabel);
            this.Sidebar.Controls.Add(this.HiddenPValue);
            this.Sidebar.Controls.Add(this.EpochLabel);
            this.Sidebar.Controls.Add(this.EpochValue);
            this.Sidebar.Controls.Add(this.Output2Value);
            this.Sidebar.Controls.Add(this.Output1Value);
            this.Sidebar.Controls.Add(this.OutputLabel);
            this.Sidebar.Controls.Add(this.Target2Value);
            this.Sidebar.Controls.Add(this.Input2Value);
            this.Sidebar.Controls.Add(this.TrainButton);
            this.Sidebar.Controls.Add(this.Target1Value);
            this.Sidebar.Controls.Add(this.Target1Label);
            this.Sidebar.Controls.Add(this.Input1Value);
            this.Sidebar.Controls.Add(this.Input1Label);
            this.Sidebar.Controls.Add(this.LoadRawButton);
            this.Sidebar.Location = new System.Drawing.Point(-2, -5);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(415, 705);
            this.Sidebar.TabIndex = 2;
            // 
            // HiddenLabel
            // 
            this.HiddenLabel.AutoSize = true;
            this.HiddenLabel.Location = new System.Drawing.Point(28, 128);
            this.HiddenLabel.Name = "HiddenLabel";
            this.HiddenLabel.Size = new System.Drawing.Size(162, 20);
            this.HiddenLabel.TabIndex = 19;
            this.HiddenLabel.Text = "Hidden Perseptron";
            // 
            // HiddenPValue
            // 
            this.HiddenPValue.Location = new System.Drawing.Point(196, 125);
            this.HiddenPValue.Name = "HiddenPValue";
            this.HiddenPValue.Size = new System.Drawing.Size(191, 25);
            this.HiddenPValue.TabIndex = 18;
            // 
            // EpochLabel
            // 
            this.EpochLabel.AutoSize = true;
            this.EpochLabel.Location = new System.Drawing.Point(28, 92);
            this.EpochLabel.Name = "EpochLabel";
            this.EpochLabel.Size = new System.Drawing.Size(54, 20);
            this.EpochLabel.TabIndex = 17;
            this.EpochLabel.Text = "EPOCH";
            // 
            // EpochValue
            // 
            this.EpochValue.FormattingEnabled = true;
            this.EpochValue.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000",
            "100000"});
            this.EpochValue.Location = new System.Drawing.Point(196, 88);
            this.EpochValue.Name = "EpochValue";
            this.EpochValue.Size = new System.Drawing.Size(191, 28);
            this.EpochValue.TabIndex = 16;
            this.EpochValue.Text = "Select Epoch";
            // 
            // Output2Value
            // 
            this.Output2Value.Location = new System.Drawing.Point(209, 234);
            this.Output2Value.Name = "Output2Value";
            this.Output2Value.Size = new System.Drawing.Size(178, 25);
            this.Output2Value.TabIndex = 15;
            // 
            // Output1Value
            // 
            this.Output1Value.Location = new System.Drawing.Point(209, 203);
            this.Output1Value.Name = "Output1Value";
            this.Output1Value.Size = new System.Drawing.Size(178, 25);
            this.Output1Value.TabIndex = 14;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(275, 180);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(63, 20);
            this.OutputLabel.TabIndex = 13;
            this.OutputLabel.Text = "Output";
            // 
            // Target2Value
            // 
            this.Target2Value.Location = new System.Drawing.Point(118, 234);
            this.Target2Value.Name = "Target2Value";
            this.Target2Value.Size = new System.Drawing.Size(76, 25);
            this.Target2Value.TabIndex = 12;
            this.Target2Value.Text = "0,99";
            // 
            // Input2Value
            // 
            this.Input2Value.Location = new System.Drawing.Point(28, 234);
            this.Input2Value.Name = "Input2Value";
            this.Input2Value.Size = new System.Drawing.Size(76, 25);
            this.Input2Value.TabIndex = 11;
            this.Input2Value.Text = "0,10";
            // 
            // TrainButton
            // 
            this.TrainButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TrainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.TrainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.TrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainButton.Location = new System.Drawing.Point(18, 23);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(97, 30);
            this.TrainButton.TabIndex = 10;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // Target1Value
            // 
            this.Target1Value.Location = new System.Drawing.Point(118, 203);
            this.Target1Value.Name = "Target1Value";
            this.Target1Value.Size = new System.Drawing.Size(76, 25);
            this.Target1Value.TabIndex = 4;
            this.Target1Value.Text = "0,01";
            // 
            // Target1Label
            // 
            this.Target1Label.AutoSize = true;
            this.Target1Label.Location = new System.Drawing.Point(124, 180);
            this.Target1Label.Name = "Target1Label";
            this.Target1Label.Size = new System.Drawing.Size(63, 20);
            this.Target1Label.TabIndex = 3;
            this.Target1Label.Text = "Target";
            // 
            // Input1Value
            // 
            this.Input1Value.Location = new System.Drawing.Point(28, 203);
            this.Input1Value.Name = "Input1Value";
            this.Input1Value.Size = new System.Drawing.Size(76, 25);
            this.Input1Value.TabIndex = 2;
            this.Input1Value.Text = "0,05";
            // 
            // Input1Label
            // 
            this.Input1Label.AutoSize = true;
            this.Input1Label.Location = new System.Drawing.Point(37, 180);
            this.Input1Label.Name = "Input1Label";
            this.Input1Label.Size = new System.Drawing.Size(54, 20);
            this.Input1Label.TabIndex = 1;
            this.Input1Label.Text = "Input";
            // 
            // LoadRawButton
            // 
            this.LoadRawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadRawButton.FlatAppearance.BorderSize = 0;
            this.LoadRawButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoadRawButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoadRawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadRawButton.Location = new System.Drawing.Point(118, 26);
            this.LoadRawButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoadRawButton.Name = "LoadRawButton";
            this.LoadRawButton.Size = new System.Drawing.Size(97, 25);
            this.LoadRawButton.TabIndex = 0;
            this.LoadRawButton.Text = "Add Data";
            this.LoadRawButton.UseVisualStyleBackColor = true;
            this.LoadRawButton.Click += new System.EventHandler(this.LoadRawButton_Click);
            // 
            // OpenSourceLabel
            // 
            this.OpenSourceLabel.AutoSize = true;
            this.OpenSourceLabel.Font = new System.Drawing.Font("Cascadia Code PL", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSourceLabel.Location = new System.Drawing.Point(652, 9);
            this.OpenSourceLabel.Name = "OpenSourceLabel";
            this.OpenSourceLabel.Size = new System.Drawing.Size(629, 46);
            this.OpenSourceLabel.TabIndex = 3;
            this.OpenSourceLabel.Text = "Open Source Free Contribution";
            // 
            // ErrorTotalChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ErrorTotalChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ErrorTotalChart.Legends.Add(legend1);
            this.ErrorTotalChart.Location = new System.Drawing.Point(436, 83);
            this.ErrorTotalChart.Name = "ErrorTotalChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ErrorTotalChart.Series.Add(series1);
            this.ErrorTotalChart.Size = new System.Drawing.Size(1079, 284);
            this.ErrorTotalChart.TabIndex = 4;
            this.ErrorTotalChart.Text = "Error Total Chart";
            title1.Font = new System.Drawing.Font("Cascadia Code PL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Errot Total MSE";
            this.ErrorTotalChart.Titles.Add(title1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1538, 386);
            this.Controls.Add(this.ErrorTotalChart);
            this.Controls.Add(this.OpenSourceLabel);
            this.Controls.Add(this.Sidebar);
            this.Font = new System.Drawing.Font("Cascadia Code PL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Neural Network Analyzer";
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTotalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button LoadRawButton;
        private System.Windows.Forms.TextBox Target1Value;
        private System.Windows.Forms.Label Target1Label;
        private System.Windows.Forms.TextBox Input1Value;
        private System.Windows.Forms.Label Input1Label;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.TextBox Output2Value;
        private System.Windows.Forms.TextBox Output1Value;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox Target2Value;
        private System.Windows.Forms.TextBox Input2Value;
        private System.Windows.Forms.ComboBox EpochValue;
        private System.Windows.Forms.Label EpochLabel;
        private System.Windows.Forms.Label OpenSourceLabel;
        private System.Windows.Forms.Label HiddenLabel;
        private System.Windows.Forms.TextBox HiddenPValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart ErrorTotalChart;
    }
}

