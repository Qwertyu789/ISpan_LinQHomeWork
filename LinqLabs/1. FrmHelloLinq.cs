using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmHelloLinq : Form
    {
        public FrmHelloLinq()
        {
            InitializeComponent();

        }

        private void button49_Click(object sender, EventArgs e)
        {
//            #region 組件 System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
//            // C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.2\System.Core.dll
//            #endregion

//            using System.Collections;
//            using System.Collections.Generic;

//namespace System.Linq
//    {
//        //
//        // 摘要:
//        //     提供一組 static (Shared 在 Visual Basic 中) 方法來查詢物件實作 System.Collections.Generic.IEnumerable`1。
//        public static class Enumerable
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //            public interface IEnumerable<T>
            //    System.Collections.Generic 的成員

            //摘要:
            //公開支援指定類型集合上簡單反覆運算的列舉值。

            //類型參數:
            //T: 要列舉之物件的類型。

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //syntax sugar   string.format(.....)  vs  $"{abc} ---- {11}{134}"
            foreach (int n in nums)
            {
                this.listBox1.Items.Add(n);
            }
            //=====================
            this.listBox1.Items.Add("======================");

            //C# compiler 轉譯
            System.Collections.IEnumerator en = nums.GetEnumerator();

            while (en.MoveNext())
            {
                this.listBox1.Items.Add(en.Current);
            }



            //=============
            //            int www;
            //            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
            //錯誤  CS1579 因為 'int' 不包含 'GetEnumerator' 的公用執行個體或延伸模組定義，所以 foreach 陳述式無法在型別 'int' 的變數上運作 LinqLabs    C:\shared\LINQ\LinqLabs(Solution)\LinqLabs\1.FrmHelloLinq.cs  46  作用中

            //            foreach (int n in www)
            //            {

            //            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 };
            foreach (int n in list)
            {
                this.listBox1.Items.Add(n);
            }
            //==============================
            this.listBox1.Items.Add("========================");
            //C# compiler 轉譯
            var w = 100;

            List<int>.Enumerator en = list.GetEnumerator();
            while (en.MoveNext())
            {
                this.listBox1.Items.Add(en.Current);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //step1. define data source object
            //step2: define query
            //step3: execute query
            //=======================

            //step1:
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //step2:
            //IEnumerable<int> q -  公開支援指定型別集合上簡單反覆運算的列舉值。
            //define query  (IEnumerable<int> q 是一個  Iterator 物件)　, 如陣列集合一般 (陣列集合也是一個  Iterator 物件)
            IEnumerable<int> q = from n in nums
                                     //where n % 2 == 0
                                     //where n>=5 && n<=10
                                 where n < 3 || n > 10
                                 select n;
            //step3; 
            //execute query(執行 iterator - 逐一查看集合的item)
            foreach (int n in q)
            {
                this.listBox1.Items.Add(n);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool result = false && A();

            MessageBox.Show("result = " + result);

        }
        bool A()
        {
            //...........long time
            MessageBox.Show("call A()");
            return true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //F11  Debug

            //step1. define data source object
            //step2: define query
            //step3: execute query
            //=======================

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            IEnumerable<int> q = from n in nums
                                 where IsEven(n)
                                 select n;

            foreach (int n in q)
            {
                this.listBox1.Items.Add(n);
            }
        }

        bool IsEven(int n)
        {
            //if (n % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (n % 2) == 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //step1. define data source object
            //step2: define query
            //step3: execute query
            //=======================

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            IEnumerable<Point> q = from n in nums
                                   where IsEven(n)
                                   select new Point(n, n * n);

            //exectue query - foreach( ..)
            foreach (Point n in q)
            {
                this.listBox1.Items.Add(n);
            }
            //=======================
            //execute query - ToXXX()
            List<Point> list = q.ToList();  //背後 執行 foreach (...){    }=> return list
            this.dataGridView1.DataSource = list;

            //=================================st
            //const  double PI = 3.14;
            this.chart1.DataSource = list;
            this.chart1.Series[0].XValueMember = "X";     //point  X 屬性
            this.chart1.Series[0].YValueMembers = "Y";   //point  Y 屬性
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            this.chart1.Series[0].Color = Color.Green;
            this.chart1.Series[0].BorderWidth = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = { "aaa", "pineApple", "apple", "xxxApple", "yyyapple", "sdfklsdkfldks", "sdfdsf" };

            IEnumerable<string> q = from w in words
                                    where w.Length > 5 && w.ToLower().Contains("apple")
                                    orderby w descending
                                    select w;

            foreach (string w in q)
            {
                this.listBox1.Items.Add(w);
            }

            //
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] words = { "aaa", "pineApple", "apple", "xxxApple", "yyyapple", "sdfklsdkfldks", "sdfdsf" };

           // var q1 = words.Where(delegateobj.).Select(.....);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //DataSet Model - class ....
            //SqlConnection Open()=> SqlCommand  ExecuteReader > While (SqlDataReader.Read())......=>this.nwDataSet1.Products===>Close()

            //DataSet ds = new DataSet();
            //ds.Tables[0].AsEnumerable();

            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);

            var q = from p in this.nwDataSet1.Products                    
                    where p.UnitPrice > 30
                    select p;

           this.dataGridView1.DataSource =   q.ToList();  //foreach (...in q)


        }
    }
}
