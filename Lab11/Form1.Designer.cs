namespace Lab11
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toGo = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(26, 147);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = " ";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(672, 373);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of experiments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prob1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prob2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prob3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prob5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prob4";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 2;
            this.prob1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob1.Location = new System.Drawing.Point(68, 47);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(83, 20);
            this.prob1.TabIndex = 8;
            this.prob1.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 2;
            this.prob2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob2.Location = new System.Drawing.Point(68, 78);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(83, 20);
            this.prob2.TabIndex = 9;
            this.prob2.Value = new decimal(new int[] {
            13,
            0,
            0,
            131072});
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 2;
            this.prob4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob4.Location = new System.Drawing.Point(211, 64);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(83, 20);
            this.prob4.TabIndex = 11;
            this.prob4.Value = new decimal(new int[] {
            17,
            0,
            0,
            131072});
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 2;
            this.prob3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob3.Location = new System.Drawing.Point(68, 109);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(83, 20);
            this.prob3.TabIndex = 10;
            this.prob3.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // prob5
            // 
            this.prob5.Location = new System.Drawing.Point(211, 94);
            this.prob5.Name = "prob5";
            this.prob5.ReadOnly = true;
            this.prob5.Size = new System.Drawing.Size(81, 20);
            this.prob5.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Variance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Average";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(396, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Chi-squared  is";
            // 
            // toGo
            // 
            this.toGo.Location = new System.Drawing.Point(554, 28);
            this.toGo.Name = "toGo";
            this.toGo.Size = new System.Drawing.Size(121, 34);
            this.toGo.TabIndex = 18;
            this.toGo.Text = "Generate";
            this.toGo.UseVisualStyleBackColor = true;
            this.toGo.Click += new System.EventHandler(this.toGo_Click);
            // 
            // tbN
            // 
            this.tbN.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbN.Location = new System.Drawing.Point(133, 12);
            this.tbN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(83, 20);
            this.tbN.TabIndex = 19;
            this.tbN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(537, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(644, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 20);
            this.textBox5.TabIndex = 26;
            this.textBox5.Text = "9.488";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(613, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(613, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 532);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.toGo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.TextBox prob5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button toGo;
        private System.Windows.Forms.NumericUpDown tbN;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

