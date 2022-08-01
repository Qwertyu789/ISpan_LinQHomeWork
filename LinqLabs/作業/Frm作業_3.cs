using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class Frm作業_3 : Form
    {
        List<Student> students_scores;
        public class Student
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Chi { get; set; }
            public int Eng { get; internal set; }
            public int Math { get; set; }
            public string Gender { get; set; }
        }
        public Frm作業_3()
        {
            InitializeComponent();
            students_scores = new List<Student>()
            {
                new Student{ Name = "aaa", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Male" },
                new Student{ Name = "bbb", Class = "CS_102", Chi = 80, Eng = 80, Math = 100, Gender = "Male" },
                new Student{ Name = "ccc", Class = "CS_101", Chi = 60, Eng = 50, Math = 65, Gender = "Female" },
                new Student{ Name = "ddd", Class = "CS_102", Chi = 80, Eng = 70, Math = 85, Gender = "Female" },
                new Student{ Name = "eee", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Female" },
                new Student{ Name = "fff", Class = "CS_102", Chi = 80, Eng = 80, Math = 75, Gender = "Female" },
            };
            getName();
        }

        private void getName()
        {
            var name = from n in students_scores
                       select n.Name;
            foreach (string studentName in name)
            {
                cbStudentName.Items.Add(studentName);
            }
            cbStudentName.Text = students_scores[0].Name;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //for (int idx = 0; idx < chart1.Series.Count(); idx++)
            //{
            //    this.chart1.Series.RemoveAt(idx);
            //};

            chart1.Series.Clear();
            // split=> 數學成績 分成 三群 '待加強'(60~69) '佳'(70~89) '優良'(90~100) 
            var query = from m in students_scores
                        group m by splitMath(m.Math) into g
                        select new { StudentCount = g.Count(), Evaluate = g.Key };
            this.chart1.DataSource = query;
            //todo#2 作業3
            this.chart1.Series.Add("0");
            this.chart1.Series[0].Name = "數學評價";
            this.chart1.Series[0].XValueMember = "Evaluate";
            this.chart1.Series[0].YValueMembers = "StudentCount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[0].BorderWidth = 3;

            dataGridView1.DataSource = query.ToList();

        }
        string splitMath(int n)
        {
            if (n < 60) return "直接電死";
            else if (n < 70) return "待加強";
            else if (n < 90) return "佳";
            else return "優良";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var scorequery = from s in students_scores
                             select new { Name = s.Name, Chinese = s.Chi};
            dataGridView1.DataSource = scorequery.ToList();
            chart1.DataSource = scorequery.ToList();
            chart1.Series.Add("0");
            chart1.Series[0].LegendText = "國文";
            chart1.Series[0].XValueMember = "Name";
            chart1.Series[0].YValueMembers = "Chinese";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Color = Color.Green;
            this.chart1.Series[0].BorderWidth = 3;

        }

        private void button37_Click(object sender, EventArgs e)
        {
            var studentquery = from s in students_scores
                               where s.Name == cbStudentName.Text
                               select new { Name = s.Name, Chinese = s.Chi,English = s.Eng,Math=s.Math};
            dataGridView1.DataSource = studentquery.ToList();
            chart1.Series.Clear();
            //chart1.Series
            chart1.DataSource = studentquery.ToList();
            chart1.Series.Add("0");
            chart1.Series[0].LegendText = "國文";
            chart1.Series[0].XValueMember = "Name";
            chart1.Series[0].YValueMembers = "Chinese";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Color = Color.Green;
            this.chart1.Series[0].BorderWidth = 3;

            chart1.Series.Add("1");
            chart1.Series[1].LegendText = "英文";
            chart1.Series[1].XValueMember = "Name";
            chart1.Series[1].YValueMembers = "English";
            this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[1].Color = Color.Blue;
            this.chart1.Series[1].BorderWidth = 3;

            chart1.Series.Add("2");
            chart1.Series[2].LegendText = "數學";
            chart1.Series[2].XValueMember = "Name";
            chart1.Series[2].YValueMembers = "Math";
            this.chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[2].Color = Color.Red;
            this.chart1.Series[2].BorderWidth = 3;


        }

        private void FindEngScore_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var scorequery = from s in students_scores
                             select new { Name = s.Name, English = s.Eng };
            dataGridView1.DataSource = scorequery.ToList();
            chart1.DataSource = scorequery.ToList();
            chart1.Series.Add("0");
            chart1.Series[0].LegendText = "英文";
            chart1.Series[0].XValueMember = "Name";
            chart1.Series[0].YValueMembers = "English";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Color = Color.Blue;
            this.chart1.Series[0].BorderWidth = 3;
        }

        private void FindMathScore_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var scorequery = from s in students_scores
                             select new { Name = s.Name, Math = s.Math };
            dataGridView1.DataSource = scorequery.ToList();
            chart1.DataSource = scorequery.ToList();
            chart1.Series.Add("0");
            chart1.Series[0].LegendText = "數學";
            chart1.Series[0].XValueMember = "Name";
            chart1.Series[0].YValueMembers = "Math";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[0].BorderWidth = 3;
        }

        private void cbStudentName_SelectedValueChanged(object sender, EventArgs e)
        {
            StudentScore.PerformClick();
        }

        private void FindScore_Click(object sender, EventArgs e)
        {
            var studentquery = from s in students_scores
                               select new { Name = s.Name, Chinese = s.Chi, English = s.Eng, Math = s.Math };
            dataGridView1.DataSource = studentquery.ToList();
            chart1.Series.Clear();
            //chart1.Series
            chart1.DataSource = studentquery.ToList();
            chart1.Series.Add("0");
            chart1.Series[0].LegendText = "國文";
            chart1.Series[0].XValueMember = "Name";
            chart1.Series[0].YValueMembers = "Chinese";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Color = Color.Green;
            this.chart1.Series[0].BorderWidth = 3;

            chart1.Series.Add("1");
            chart1.Series[1].LegendText = "英文";
            chart1.Series[1].XValueMember = "Name";
            chart1.Series[1].YValueMembers = "English";
            this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[1].Color = Color.Blue;
            this.chart1.Series[1].BorderWidth = 3;

            chart1.Series.Add("2");
            chart1.Series[2].LegendText = "數學";
            chart1.Series[2].XValueMember = "Name";
            chart1.Series[2].YValueMembers = "Math";
            this.chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[2].Color = Color.Red;
            this.chart1.Series[2].BorderWidth = 3;
        }
    }
}
