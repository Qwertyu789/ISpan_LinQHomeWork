using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class Frm作業_1 : Form
    {
        //=================================     property　　　=================================
        //當前頁面
        int CurrentPage = 0;
        //總頁數
        int TotalPage = 0;
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

        public Frm作業_1()
        {
            InitializeComponent();
            students_scores = new List<Student>()
                                         {
                                            new Student{ Name = "aaa", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Male" },
                                            new Student{ Name = "bbb", Class = "CS_102", Chi = 80, Eng = 80, Math = 100, Gender = "Male" },
                                            new Student{ Name = "ccc", Class = "CS_101", Chi = 60, Eng = 50, Math = 75, Gender = "Female" },
                                            new Student{ Name = "ddd", Class = "CS_102", Chi = 80, Eng = 70, Math = 85, Gender = "Female" },
                                            new Student{ Name = "eee", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Female" },
                                            new Student{ Name = "fff", Class = "CS_102", Chi = 80, Eng = 80, Math = 80, Gender = "Female" },

                                          };
        }
        //=================================     method　　　=================================
        //預載資料
        private void Frm作業_1_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            this.order_DetailsTableAdapter1.Fill(this.nwDataSet1.Order_Details);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            comboboxload();
            deleteDBNull();
            CheckTotalPages();
        }
        //檢查最大頁數
        private void CheckTotalPages()
        {
            TotalPage = nwDataSet1.Products.Rows.Count / Convert.ToInt32(tbPiece.Text);
            if (nwDataSet1.Products.Rows.Count % Convert.ToInt32(tbPiece.Text) > 0) TotalPage += 1;
        }
        //去除NULL檔案
        void deleteDBNull()
        {
            foreach (DataRow s in nwDataSet1.Orders.Rows)
            {
                foreach (DataColumn c in nwDataSet1.Orders.Columns)
                {
                    if (s.IsNull(c))
                    {
                        s.Delete();
                        break;
                    }
                }
            }
            nwDataSet1.AcceptChanges();
        }
        //combobox匯入
        void comboboxload()
        {
            var date = from orders in nwDataSet1.Orders
                           //group r by r.OrderDate.Year into a
                           //select a.Key;
                       select orders.OrderDate.Year;

            foreach (int item in date.Distinct())
            {
                combobox.Items.Add(item);
            }
        }
        //翻頁
        void page()
        {

            this.dataGridView1.Columns.Clear();
            bool isInt = int.TryParse(tbPiece.Text, out int Takepage);
            if (!isInt)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            int Skippage = (CurrentPage - 1) * Takepage;
            //做錯做成ORDERS了
            //var orders = from ods in this.nwDataSet1.Orders.Skip(Skippage).Take(Takepage)
            //                 //where ods.OrderDate.Year == Convert.ToInt32(combobox.Text)
            //             select ods;
            //this.dataGridView1.DataSource = orders.ToList();
            //var order_details = from odt in this.nwDataSet1.Order_Details
            //                    join ods in orders
            //                    on odt.OrderID equals ods.OrderID
            //                    select odt;
            //this.dataGridView2.DataSource = order_details.ToList();
            var product = from pro in this.nwDataSet1.Products.Skip(Skippage).Take(Takepage)
                          select pro;
            this.dataGridView2.DataSource = product.ToList();
            CheckTotalPages();
        }
        //=================================     FileInfo[]　　　=================================
        //全資料
        private void btnALLdata(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView1.DataSource = files;
        }
        //找檔案型態為LOG
        private void btnlogextension(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView1.DataSource = files;
            var f_data = from datas in files
                         where datas.Extension == ".log"
                         select datas;
            this.dataGridView1.DataSource = f_data.ToList();
        }
        //2017 ORGER BY
        private void btn2017dataoderby(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView1.DataSource = files;
            var f_data = from datas in files
                         where datas.CreationTime.Year - 2017 >= 0
                         orderby datas.CreationTime
                         select datas;
            dataGridView1.DataSource = f_data.ToList();
        }
        //大單位
        private void btnHugedata(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView1.DataSource = files;
            var f_data = from datas in files
                         where datas.Length >= 1000000
                         select datas;
            dataGridView1.DataSource = f_data.ToList();
        }
        //=================================     Orders　　　=================================
        //ALL ORDER
        private void btnAllOrders(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            var orders = from ods in this.nwDataSet1.Orders
                         select ods;
            //for (int i=0;i<dataGridView1.Rows.Count;i++)
            //{
            //    if (Convert.IsDBNull(dataGridView1.Rows[i])) { dataGridView1.Rows[i] = "NA"; }
            //}
            this.dataGridView1.DataSource = orders.ToList();
        }
        //找年分
        private void btnYearOrder(object sender, EventArgs e)
        {
            var orders = from ods in this.nwDataSet1.Orders
                         where ods.OrderDate.Year == Convert.ToInt32(combobox.Text)
                         select ods;
            this.dataGridView1.DataSource = orders.ToList();

            List<LinqLabs.NWDataSet.Order_DetailsRow> temp = new List<LinqLabs.NWDataSet.Order_DetailsRow>();
            foreach (var ods in orders)
            {
                var order_details = from odt in this.nwDataSet1.Order_Details
                                        //join ods in orders on odt.OrderID equals ods.OrderID
                                    where odt.OrderID == ods.OrderID
                                    select odt;
                //this.dataGridView2.DataSource = order_details.ToList();
                temp.AddRange(order_details);
            }
            this.dataGridView2.DataSource = temp;
        }
        //=================================     Products　　　=================================
        //下一頁
        private void btnNxtPg_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPage)
            {
                CurrentPage++;
                //this.nwDataSet1.Orders.Take(10);//Top 10 Skip(10)
                page();
            }
            //Distinct()
        }
        //上一頁
        private void btnLstPg_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                page();
            }
        }
        //==============================     Students Score　　　==============================
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            #region 搜尋 班級學生成績

            // 
            // 共幾個 學員成績 ?						

            // 找出 前面三個 的學員所有科目成績					
            // 找出 後面兩個 的學員所有科目成績					

            // 找出 Name 'aaa','bbb','ccc' 的學成績						

            // 找出學員 'bbb' 的成績	                          

            // 找出除了 'bbb' 學員的學員的所有成績 ('bbb' 退學)	


            // 數學不及格 ... 是誰 
            #endregion
            this.dataGridView2.Columns.Clear();
            this.dataGridView1.DataSource = students_scores;

        }

        private void btnHowmany_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            this.dataGridView1.DataSource = students_scores;
            MessageBox.Show("共 " + students_scores.Count + " 個學員成績");
        }

        private void btnFront3_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            var student = from i in students_scores.Take(3)
                          select i;

            this.dataGridView1.DataSource = student.ToList();
            this.dataGridView2.DataSource = students_scores.Take(3).ToList();
        }

        private void btnLast2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            var student = from i in students_scores.Skip(students_scores.Count - 2)
                          select i;

            this.dataGridView1.DataSource = student.ToList();

            this.dataGridView2.DataSource = students_scores.Skip(students_scores.Count - 2).ToList();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            var student = from i in students_scores
                          where i.Name == "aaa" || i.Name == "bbb" || i.Name == "ccc"
                          select i;

            this.dataGridView1.DataSource = student.ToList();
            this.dataGridView2.DataSource = students_scores.Where(i => (i.Name == "aaa" || i.Name == "bbb" || i.Name == "ccc")).ToList();
        }

        private void brnFindbbb_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            var student = from i in students_scores
                          where i.Name == "bbb"
                          select i;

            this.dataGridView1.DataSource = student.ToList();
            this.dataGridView2.DataSource = students_scores.Where(i => (i.Name == "bbb")).ToList();
        }

        private void btnNobbb_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            var student = from i in students_scores
                          where i.Name != "bbb"
                          select i;

            this.dataGridView1.DataSource = student.ToList();
            this.dataGridView2.DataSource = students_scores.Where(i => (i.Name != "bbb")).ToList();
        }

        private void btnMathnopass_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns.Clear();
            var student = from i in students_scores
                          where i.Math < 60
                          select i;

            this.dataGridView1.DataSource = student.ToList();
            this.dataGridView2.DataSource = students_scores.Where(i => (i.Math<60)).ToList();
        }

        #region 0727新題目
        //new {.....  Min=33, Max=34.}
        // 找出 'aaa', 'bbb' 'ccc' 學員 國文數學兩科 科目成績  |		
        //個人 所有科的  sum, min, max, avg
        #endregion
    }
}
