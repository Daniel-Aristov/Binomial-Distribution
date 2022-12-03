namespace teorVer_4
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelInput = new System.Windows.Forms.Panel();
            this.TestsInSeriesInput = new System.Windows.Forms.TextBox();
            this.ProbabilityInput = new System.Windows.Forms.TextBox();
            this.labelTestsInSeries = new System.Windows.Forms.Label();
            this.labelProbability = new System.Windows.Forms.Label();
            this.TitleBinomialDistribution = new System.Windows.Forms.Label();
            this.btn_modelling = new System.Windows.Forms.Button();
            this.CountSeriesInput = new System.Windows.Forms.TextBox();
            this.labelCountSeries = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.labelInputData = new System.Windows.Forms.Label();
            this.ChartDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panelInput.Controls.Add(this.labelInputData);
            this.panelInput.Controls.Add(this.btn_clear);
            this.panelInput.Controls.Add(this.CountSeriesInput);
            this.panelInput.Controls.Add(this.labelCountSeries);
            this.panelInput.Controls.Add(this.btn_modelling);
            this.panelInput.Controls.Add(this.TestsInSeriesInput);
            this.panelInput.Controls.Add(this.ProbabilityInput);
            this.panelInput.Controls.Add(this.labelTestsInSeries);
            this.panelInput.Controls.Add(this.labelProbability);
            this.panelInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.panelInput.Location = new System.Drawing.Point(18, 44);
            this.panelInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(346, 477);
            this.panelInput.TabIndex = 5;
            // 
            // TestsInSeriesInput
            // 
            this.TestsInSeriesInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.TestsInSeriesInput.Location = new System.Drawing.Point(251, 135);
            this.TestsInSeriesInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TestsInSeriesInput.Name = "TestsInSeriesInput";
            this.TestsInSeriesInput.Size = new System.Drawing.Size(85, 26);
            this.TestsInSeriesInput.TabIndex = 3;
            this.TestsInSeriesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProbabilityInput
            // 
            this.ProbabilityInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ProbabilityInput.Location = new System.Drawing.Point(220, 62);
            this.ProbabilityInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProbabilityInput.Name = "ProbabilityInput";
            this.ProbabilityInput.Size = new System.Drawing.Size(91, 26);
            this.ProbabilityInput.TabIndex = 2;
            this.ProbabilityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTestsInSeries
            // 
            this.labelTestsInSeries.AutoSize = true;
            this.labelTestsInSeries.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTestsInSeries.Location = new System.Drawing.Point(16, 138);
            this.labelTestsInSeries.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTestsInSeries.Name = "labelTestsInSeries";
            this.labelTestsInSeries.Size = new System.Drawing.Size(225, 19);
            this.labelTestsInSeries.TabIndex = 1;
            this.labelTestsInSeries.Text = "Число испытаний в серии:";
            // 
            // labelProbability
            // 
            this.labelProbability.AutoSize = true;
            this.labelProbability.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProbability.Location = new System.Drawing.Point(16, 65);
            this.labelProbability.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProbability.Name = "labelProbability";
            this.labelProbability.Size = new System.Drawing.Size(194, 19);
            this.labelProbability.TabIndex = 0;
            this.labelProbability.Text = "Вероятность события:";
            // 
            // TitleBinomialDistribution
            // 
            this.TitleBinomialDistribution.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleBinomialDistribution.AutoSize = true;
            this.TitleBinomialDistribution.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.TitleBinomialDistribution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleBinomialDistribution.Location = new System.Drawing.Point(393, 9);
            this.TitleBinomialDistribution.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TitleBinomialDistribution.Name = "TitleBinomialDistribution";
            this.TitleBinomialDistribution.Size = new System.Drawing.Size(306, 22);
            this.TitleBinomialDistribution.TabIndex = 4;
            this.TitleBinomialDistribution.Text = "Биномиальное распределение";
            // 
            // btn_modelling
            // 
            this.btn_modelling.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_modelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modelling.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_modelling.FlatAppearance.BorderSize = 0;
            this.btn_modelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modelling.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_modelling.Location = new System.Drawing.Point(20, 307);
            this.btn_modelling.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_modelling.Name = "btn_modelling";
            this.btn_modelling.Size = new System.Drawing.Size(136, 35);
            this.btn_modelling.TabIndex = 3;
            this.btn_modelling.Text = "Моделировать";
            this.btn_modelling.UseVisualStyleBackColor = false;
            this.btn_modelling.Click += new System.EventHandler(this.btn_modelling_Click);
            // 
            // CountSeriesInput
            // 
            this.CountSeriesInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.CountSeriesInput.Location = new System.Drawing.Point(188, 202);
            this.CountSeriesInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CountSeriesInput.Name = "CountSeriesInput";
            this.CountSeriesInput.Size = new System.Drawing.Size(85, 26);
            this.CountSeriesInput.TabIndex = 5;
            this.CountSeriesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCountSeries
            // 
            this.labelCountSeries.AutoSize = true;
            this.labelCountSeries.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCountSeries.Location = new System.Drawing.Point(16, 205);
            this.labelCountSeries.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCountSeries.Name = "labelCountSeries";
            this.labelCountSeries.Size = new System.Drawing.Size(162, 19);
            this.labelCountSeries.TabIndex = 4;
            this.labelCountSeries.Text = "Количество серий:";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(188, 307);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 35);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInputData.Location = new System.Drawing.Point(111, 11);
            this.labelInputData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(117, 19);
            this.labelInputData.TabIndex = 7;
            this.labelInputData.Text = "Ввод данных";
            // 
            // ChartDistribution
            // 
            this.ChartDistribution.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChartDistribution.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChartDistribution.BorderlineColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea";
            this.ChartDistribution.ChartAreas.Add(chartArea1);
            this.ChartDistribution.Location = new System.Drawing.Point(382, 44);
            this.ChartDistribution.Name = "ChartDistribution";
            this.ChartDistribution.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            series2.Name = "Series2";
            this.ChartDistribution.Series.Add(series1);
            this.ChartDistribution.Series.Add(series2);
            this.ChartDistribution.Size = new System.Drawing.Size(659, 477);
            this.ChartDistribution.TabIndex = 6;
            this.ChartDistribution.Text = "Диаграмма биномиального распределения";
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "TitleText";
            title1.Text = "График биномиального распределения";
            this.ChartDistribution.Titles.Add(title1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1055, 540);
            this.Controls.Add(this.ChartDistribution);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.TitleBinomialDistribution);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №4. Биномиальное распределние";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox TestsInSeriesInput;
        private System.Windows.Forms.TextBox ProbabilityInput;
        private System.Windows.Forms.Label labelTestsInSeries;
        private System.Windows.Forms.Label labelProbability;
        private System.Windows.Forms.Label TitleBinomialDistribution;
        private System.Windows.Forms.Button btn_modelling;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox CountSeriesInput;
        private System.Windows.Forms.Label labelCountSeries;
        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDistribution;
    }
}

