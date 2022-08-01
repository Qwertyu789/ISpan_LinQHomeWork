
namespace LinqLabs
{
    partial class Frm作業_3
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FindChiScore = new System.Windows.Forms.Button();
            this.StudentScore = new System.Windows.Forms.Button();
            this.數學評價 = new System.Windows.Forms.Button();
            this.cbStudentName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindEngScore = new System.Windows.Forms.Button();
            this.FindMathScore = new System.Windows.Forms.Button();
            this.FindScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(327, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(435, 174);
            this.chart1.TabIndex = 151;
            this.chart1.Text = "chart1";
            // 
            // FindChiScore
            // 
            this.FindChiScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindChiScore.Location = new System.Drawing.Point(25, 88);
            this.FindChiScore.Name = "FindChiScore";
            this.FindChiScore.Size = new System.Drawing.Size(250, 50);
            this.FindChiScore.TabIndex = 150;
            this.FindChiScore.Text = "搜尋 班級學生國文成績";
            this.FindChiScore.UseVisualStyleBackColor = false;
            this.FindChiScore.Click += new System.EventHandler(this.button36_Click);
            // 
            // StudentScore
            // 
            this.StudentScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StudentScore.Location = new System.Drawing.Point(25, 299);
            this.StudentScore.Name = "StudentScore";
            this.StudentScore.Size = new System.Drawing.Size(250, 50);
            this.StudentScore.TabIndex = 149;
            this.StudentScore.Text = "每個學生個人成績";
            this.StudentScore.UseVisualStyleBackColor = false;
            this.StudentScore.Click += new System.EventHandler(this.button37_Click);
            // 
            // 數學評價
            // 
            this.數學評價.Location = new System.Drawing.Point(25, 388);
            this.數學評價.Name = "數學評價";
            this.數學評價.Size = new System.Drawing.Size(250, 50);
            this.數學評價.TabIndex = 148;
            this.數學評價.Text = "自己分群";
            this.數學評價.UseVisualStyleBackColor = false;
            this.數學評價.Click += new System.EventHandler(this.button33_Click);
            // 
            // cbStudentName
            // 
            this.cbStudentName.FormattingEnabled = true;
            this.cbStudentName.Location = new System.Drawing.Point(86, 355);
            this.cbStudentName.Name = "cbStudentName";
            this.cbStudentName.Size = new System.Drawing.Size(121, 20);
            this.cbStudentName.TabIndex = 152;
            this.cbStudentName.SelectedValueChanged += new System.EventHandler(this.cbStudentName_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 200);
            this.dataGridView1.TabIndex = 153;
            // 
            // FindEngScore
            // 
            this.FindEngScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindEngScore.Location = new System.Drawing.Point(25, 144);
            this.FindEngScore.Name = "FindEngScore";
            this.FindEngScore.Size = new System.Drawing.Size(250, 50);
            this.FindEngScore.TabIndex = 154;
            this.FindEngScore.Text = "搜尋 班級學生英文成績";
            this.FindEngScore.UseVisualStyleBackColor = false;
            this.FindEngScore.Click += new System.EventHandler(this.FindEngScore_Click);
            // 
            // FindMathScore
            // 
            this.FindMathScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindMathScore.Location = new System.Drawing.Point(25, 200);
            this.FindMathScore.Name = "FindMathScore";
            this.FindMathScore.Size = new System.Drawing.Size(250, 50);
            this.FindMathScore.TabIndex = 155;
            this.FindMathScore.Text = "搜尋 班級學生數學成績";
            this.FindMathScore.UseVisualStyleBackColor = false;
            this.FindMathScore.Click += new System.EventHandler(this.FindMathScore_Click);
            // 
            // FindScore
            // 
            this.FindScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindScore.Location = new System.Drawing.Point(25, 12);
            this.FindScore.Name = "FindScore";
            this.FindScore.Size = new System.Drawing.Size(250, 50);
            this.FindScore.TabIndex = 156;
            this.FindScore.Text = "搜尋 班級學生成績";
            this.FindScore.UseVisualStyleBackColor = false;
            this.FindScore.Click += new System.EventHandler(this.FindScore_Click);
            // 
            // Frm作業_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindScore);
            this.Controls.Add(this.FindMathScore);
            this.Controls.Add(this.FindEngScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbStudentName);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.FindChiScore);
            this.Controls.Add(this.StudentScore);
            this.Controls.Add(this.數學評價);
            this.Name = "Frm作業_3";
            this.Text = "Frm作業_3";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button FindChiScore;
        private System.Windows.Forms.Button StudentScore;
        private System.Windows.Forms.Button 數學評價;
        private System.Windows.Forms.ComboBox cbStudentName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FindEngScore;
        private System.Windows.Forms.Button FindMathScore;
        private System.Windows.Forms.Button FindScore;
    }
}