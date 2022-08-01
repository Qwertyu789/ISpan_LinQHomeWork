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
    public partial class Frm作業_4 : Form
    {
        NorthwindEntities dbConnect = new NorthwindEntities();
        public Frm作業_4()
        {
            InitializeComponent();
        }
        private void _Refresh()
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            treeView1.Nodes.Clear();
        }
        private string _fileLengh(int n)
        {
            if (n > 100000) return "大檔案";
            else return "小檔案";
        }
        private string _MyKey(int n)
        {
            if (n < 5) return "小";
            else if (n < 10) return "中";
            else return "大";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _Refresh();
            this.treeView1.Nodes.Clear();
            string s1 = "";
            string s2 = "";
            string s3 = "";

            int[] practice = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            for (int idx = 0; idx < practice.Length; idx++)
            {
                if (_MyKey(idx) == "小")
                {
                    s1 += idx +" ";
                }
                else if (_MyKey(idx) == "中")
                {
                    s2 += idx + " "; ;
                }
                else
                {
                    s3 += idx + " "; ;
                }
            }
            MessageBox.Show("小：" + s1 + "\r\n中：" + s2 + "\r\n大：" + s3);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            _Refresh();
            this.dataGridView2.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            var grouptest = from f in files
                            orderby f.Length descending
                            group f by _fileLengh((int)f.Length) into g
                            select new {Key= g.Key, Name = g };
            this.dataGridView1.DataSource = files.OrderByDescending(f => f.Length).ToList();
            foreach(var i in grouptest)
            {
                string s = $"{i.Key}";
                TreeNode x = this.treeView1.Nodes.Add(s);
                foreach(var item in i.Name)
                {
                    string b =$"{item} ({item.Length})";
                    x.Nodes.Add(b);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _Refresh();
            this.dataGridView2.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            var grouptest = from f in files
                            orderby f.CreationTime descending
                            group f by f.CreationTime.Year into g
                            select new { Key = g.Key, Name = g, };
            this.dataGridView1.DataSource = files.ToList();
            foreach (var i in grouptest)
            {
                string s = $"{i.Key}";
                TreeNode x = this.treeView1.Nodes.Add(s);
                foreach (var item in i.Name)
                {
                    string b = $"{item} ({item.CreationTime})";
                    x.Nodes.Add(b);
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            _Refresh();
            var query = from price in dbConnect.Products.AsEnumerable()
                        orderby price.UnitPrice ascending
                        group price by _findPrice(price.UnitPrice) into g
                        select new { Key = g.Key, ProductName = g,Count = g.Count() };
            dataGridView1.DataSource = dbConnect.Products.ToList();
            foreach (var i in query)
            {                
                TreeNode x = this.treeView1.Nodes.Add($"{i.Key} ({i.Count})");
                foreach (var item in i.ProductName)
                {
                    string b = $"{item.ProductName} ({item.UnitPrice})";
                    x.Nodes.Add(b);
                }
            }
        }
        private string _findPrice(decimal? d )
        {
            if (d < 50) return "低價產品";
            else if (d < 100) return "中價產品";
            else return "高價產品";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _Refresh();
            var query = from o in dbConnect.Orders.AsEnumerable()
                        group o by o.OrderDate.Value.Year into g
                        select new { Year = g.Key, ID = g,Count = g.Count() };
            foreach(var i in query)
            {
                TreeNode x = treeView1.Nodes.Add($"{i.Year} ({i.Count})");
                foreach(var item in i.ID)
                {
                    x.Nodes.Add($"{item.OrderID} ({item.OrderDate})");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _Refresh();
            var query = from o in dbConnect.Orders.AsEnumerable()
                        group o by o.OrderDate.Value.Year+"/"+o.OrderDate.Value.Month into g
                        select new { Year = g.Key, ID = g, Count = g.Count() };
            foreach (var i in query)
            {
                TreeNode x = treeView1.Nodes.Add($"{i.Year} ({i.Count})");
                foreach (var item in i.ID)
                {
                    x.Nodes.Add($"{item.OrderID} ({item.OrderDate})");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //decimal res = 0;
            //_Refresh();
            //var totalp = from p in dbConnect.Order_Details.AsEnumerable()
            //             select new { total = p.UnitPrice * (decimal)(1 - p.Discount) * p.Quantity };
            //foreach (var i in totalp)
            //{
            //    res += i.total;
            //}
            //MessageBox.Show(res.ToString("0.00"));
            var q = from p in dbConnect.Order_Details
                    select p;
            MessageBox.Show($"{q.Sum(i => (double)(i.UnitPrice) * i.Quantity * (1 - i.Discount)):n2}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var best5seller = from s in dbConnect.Orders
                              group s by s.EmployeeID into g
                              select new { Seller = g.Key, Count = g.Count()};
            dataGridView1.DataSource = best5seller.OrderByDescending(i => i.Count).Take(5).ToList();
        }
    }
}
