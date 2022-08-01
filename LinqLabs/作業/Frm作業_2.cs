using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class Frm作業_2 : Form
    {
        public Frm作業_2()
        {
            InitializeComponent();
            //=========載入Dataset
            productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
            //=========載入日期
            setDatetime();
            //=========載入年、季
            setCombobox();


        }
        //============================ function
        // Datetime
        private void setDatetime()
        {
            var datesave = from date in awDataSet1.ProductPhoto
                           orderby date.ModifiedDate ascending
                           select date.ModifiedDate;
            DateTime latestday, newestday = new DateTime();
            latestday = (datesave.ToArray())[0];
            newestday = (datesave.ToArray())[(datesave.ToArray().Length) - 1];
            dpFrom.Value = latestday;
            dpFrom.MinDate = latestday;
            dpFrom.MaxDate = newestday;
            dpTo.MinDate = latestday;
            dpTo.MaxDate = newestday;
        }
        // Year
        private void setCombobox()
        {
            var comboYear = from year in awDataSet1.ProductPhoto
                            orderby year.ModifiedDate ascending
                            select year.ModifiedDate.Year;
            foreach (int item in comboYear.Distinct())
            {
                cbYear.Items.Add(item);
            }
            cbYear.Text = (comboYear.ToArray()[(comboYear.Count()) - 1]).ToString();
            cbSeason.Text = cbSeason.Items[0].ToString();
        }
        //============================ 
        private void button12_Click(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = awDataSet1.ProductPhoto.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = awDataSet1.ProductPhoto.Where(i => i.ModifiedDate >= dpFrom.Value && i.ModifiedDate <= dpTo.Value).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var findYear = from y in awDataSet1.ProductPhoto
                           where y.ModifiedDate.Year == Convert.ToInt32(cbYear.Text)
                           orderby y.ModifiedDate ascending
                           select y;
            this.dataGridView2.DataSource = findYear.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string gettxt = cbSeason.Text;
            int seasoncount = 0;
            switch (gettxt)
            {
                case"第一季":
                    seasoncount = 0;
                    break;
                case"第二季":
                    seasoncount = 1;
                    break;
                case"第三季":
                    seasoncount = 2;
                    break;
                case"第四季":
                    seasoncount = 3;
                    break;
            }
            var fs1 = from s in awDataSet1.ProductPhoto
                         where s.ModifiedDate.Year == Convert.ToInt32(cbYear.Text)
                         select s;
            var fs2 = from s2 in fs1
                      where (s2.ModifiedDate.Month - 1) / 3 == seasoncount
                      select s2;

            this.dataGridView2.DataSource = fs2.ToList();
            this.txtSeasonbike.Text = $"{cbYear.Text}年{cbSeason.Text}的腳踏車共有：{fs2.ToList().Count()}台";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            //取得imgID
            int _index =Convert.ToInt32( this.dataGridView2.CurrentRow.Cells[0].Value);
            //byte[] bytes =new byte[]{Convert.ToByte(awDataSet1.ProductPhoto.Where(i => i.ProductPhotoID == _index).Select(i => i.LargePhoto)) };

            var r = from b in awDataSet1.ProductPhoto
                    where b.ProductPhotoID == _index
                    select b.LargePhoto;
            byte[] result = r.SelectMany(i => i).ToArray();
            if (_index!=-1) { 
            pictureBox2.Image = ByteArrayToImage(result);
            }

        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Image image = Image.FromStream(ms);
            return image;
        }
    }
}
