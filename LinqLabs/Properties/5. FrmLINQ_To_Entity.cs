using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LinqLabs;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq.Dynamic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Common;

namespace Starter
{
    public partial class FrmLINQ_To_Entity : Form
    {
        public FrmLINQ_To_Entity()
        {
            InitializeComponent();

            //Debug Only , 否則影響效能
            db.Database.Log = Console.Write;

            //test 如 adapter fill 一次 test performane ?  lazy loading
            db.Categories.Load();
            db.Products.Load();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
  
        NorthwindEntities db = new NorthwindEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            //Note : IQueryable<T> (IQuerable 會 轉譯 為 T-SQL)

            IQueryable<Product> q = from p in db.Products
                                    where p.UnitsInStock > 30
                                    select p;

             var q1 = from p in db.Products
                                    where p.UnitsInStock > 30                       
                                    select new { p.ProductName, p.UnitsInStock, p.UnitPrice, totalPrice=p.UnitPrice*p.UnitsInStock};

        

            this.dataGridView1.DataSource = q.ToList();
            this.dataGridView2.DataSource = q1.ToList();


            //call stored procedure
            this.dataGridView3.DataSource = db.SalesByCategory("Beverages", "1996");

          

        }

        private void button22_Click(object sender, EventArgs e)
        {
            var q = from p in db.Products
                    orderby p.UnitsInStock descending,  p.ProductID
                    select p;

            this.dataGridView1.DataSource = q.ToList();

            var q2 = from p in db.Products
                     let orderKey = Guid.NewGuid()
                     orderby orderKey ascending
                     select new { p.ProductID, p.ProductName, orderKey };

            this.dataGridView2.DataSource = q2.ToList();
        }

        private void button20_Click(object sender, EventArgs e)
        {  
            // linq to Entity 再看
            //linq to DataSet CategoryID 是 null 就很麻煩, 但 Linq to Entity => TSQL會處理 掉

            //var q = from p in db.Products
            //           select p;
            //this.dataGridView1.DataSource = q.ToList();


            //inner join (不包括 categoryID 9)
            var q1 = from c in db.Categories
                     join p in db.Products
                     on c.CategoryID equals p.CategoryID
                     select new { xxx = c.CategoryID, c.CategoryName, p.ProductID, p.ProductName, p.UnitsInStock };
            
            this.dataGridView1.DataSource = q1.ToList();


            //lefter outer join
            //==================================

            //var q2 = from c in db.Categories
            //         join p in db.Products
            //         on c.CategoryID equals p.CategoryID into js
            //         select new {c.CategoryID,c.CategoryName, js};


            //this.dataGridView2.DataSource = q2.ToList();


            //lefter outer join (包括 categoryID 9)
            //==================================
           
            var q3 = from c in db.Categories
                     join p in db.Products
                     on c.CategoryID equals p.CategoryID into js
                     select new {c.CategoryID, c.CategoryName, js , MyCount=js.Count(), MyGroup=js,
                         MyAvg2 =js.DefaultIfEmpty().Average(p=>p.UnitsInStock), //用 DefaultIfEmpty , UnitsIsStock 是 Nullable
                         MyAvg = js.Average(p=>p.UnitPrice)};


            //======================
            this.dataGridView2.DataSource = q3.ToList();

            foreach (var group in q3)
            {
                string s = string.Format("{0}  ({1})", group.CategoryName, group.MyCount);

                TreeNode x = this.treeView1.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                {
                    x.Nodes.Add(item.ToString());
                }
            }

            //======================
            //test DefaultIfEmpty();

            IEnumerable<Product> products = db.Categories.AsEnumerable().Last().Products;
            int count1 = products.Count();
            var list = products.DefaultIfEmpty();
            int count2 = products.DefaultIfEmpty().Count();

            var q4 = from c in db.Categories
                     join p in db.Products
                     on c.CategoryID equals p.CategoryID into js
                     //from p1 in js                         //test
                     from p1 in js.DefaultIfEmpty()  //js.DefaultIfEmpty() 有一個物件的集合, 才會 gen 出  left outer join 的 categoryName, 但 是 p1 會是 null
                     select new
                     {
                         c.CategoryID,
                         c.CategoryName,
                         MyCount = js.Count(),
                         MyCount_DefaultIfEmpty = js.DefaultIfEmpty().Count(),
                         ProductName = p1 ==null? "NO Product"  : p1.ProductName//string.Format("{0}-{1}-{2}", p1.ProductID, p1.ProductName, p1.UnitPrice) };
                     };

            this.dataGridView3.DataSource = q4.ToList();
          
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //SelectMany
            //inner join  (Implicit inner join)
            //Note : 這是較 Linq 較直覺的寫法,join 太 sql 了

            var q = from c in db.Categories
                    from p in c.Products
                    select new { c.CategoryID,  c.CategoryName, p.ProductID, p.ProductName, p.UnitPrice };

            //q = DataContext.Categories.SelectMany(c => c.Products, (c, p) => new { c.CategoryName, p.ProductID, p.ProductName, p.UnitPrice }).ToList();

            this.dataGridView1.DataSource = q.ToList();

            //======================================
            //cross join
            var q2 = from c in db.Categories
                     from p in db.Products
                     select new { c.CategoryName, p.ProductID, p.ProductName, p.UnitPrice };

            MessageBox.Show("cross join count = " + q2.Count());
            this.dataGridView2.DataSource = q2.ToList();


        }

        private void button23_Click(object sender, EventArgs e)
        {
            //============================
            //自訂 compare logic
            var q3 = db.Products.OrderBy(p => p, new MyComparer()).ToList();
            this.dataGridView2.DataSource = q3.ToList();
        }

        class MyComparer : IComparer<Product>
        {

            public int Compare(Product x, Product y)
            {
                if (x.UnitPrice < y.UnitPrice)
                    return -1;
                else if (x.UnitPrice > y.UnitPrice)
                    return 1;
                else
                    return string.Compare(x.ProductName[0].ToString(), y.ProductName[0].ToString(), true);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //記得 Products.ToList();  (Products 是IEumerable<> iterator)
            this.dataGridView1.DataSource = db.Categories.First().Products.ToList();

            MessageBox.Show(db.Products.First().Category.CategoryName);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            var q = from p in db.Products
                        select new { p.ProductID, p.ProductName, p.Category.CategoryName, p.UnitsInStock };
            this.dataGridView3.DataSource = q.ToList();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var q = from p in db.Products
                    group p by p.Category.CategoryName into g
                    select new { CategoryName = g.Key, Avg = g.Average(p => p.UnitsInStock) };

            this.dataGridView1.DataSource = q.ToList();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //TODO 3. 

        }

        private void button55_Click(object sender, EventArgs e)
        {
            db.Products.Add(new Product { ProductName ="Test "+ DateTime.Now.ToLongTimeString(), Discontinued = true });
            db.SaveChanges();

            //
          //  this.Read_RefreshDataGridView();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            //update
            var product = (from p in db.Products
                           where p.ProductName.Contains("Test")
                           select p).FirstOrDefault();

            if (product == null) return;
            product.ProductName = "Test" + product.ProductName;

          this.db.SaveChanges();
            this.Read_RefreshDataGridView();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            //delete one product
            var product = (from p in db.Products
                           where p.ProductName.Contains("Test")
                           select p).FirstOrDefault();

            if (product == null) return;
            this.db.Products.Remove(product);
            this.db.SaveChanges();

            this.Read_RefreshDataGridView();

        }

        private void button54_Click(object sender, EventArgs e)
        {

            //delete all
            var q = from p in db.Products
                    where p.ProductName.Contains("Test")
                    select p;

            foreach (var product in q)
            {
                this.db.Products.Remove(product);
            }

            this.db.SaveChanges();
 this.Read_RefreshDataGridView();
        }    

        private void RefreshDataGridView_Click(object sender, EventArgs e)
        {
            this.Read_RefreshDataGridView();
         
        }
        void Read_RefreshDataGridView()
        {
            
            this.dataGridView1.DataSource = null;
          
            BindingSource bs = new BindingSource();
            bs.DataSource = db.Products.ToList();
            this.dataGridView1.DataSource = bs;

          bs.MoveLast();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            //類型 'System.NotSupportedException' 的未處理例外狀況發生於 EntityFramework.SqlServer.dll
            //其他資訊: LINQ to Entities 無法辨識方法 'LinqLabs.Category Last[Category](System.Linq.IQueryable`1[LinqLabs.Category])' 方法，而且這個方法無法轉譯成存放區運算式。
           
            // Note: Exception
            IEnumerable<Product> products1 = db.Categories.Last().Products;


            //Solution: AsEnumerable() 
            IEnumerable<Product> products2 = db.Categories.AsEnumerable().Last().Products;


            //DefaultIfEmpy
        }

        #region Solution 2: ObservableCollection<TEntity>   
        //db.Products.Local; 新增 刪除 will Notify , but Udata 不會 Notify

        private void button9_Click(object sender, EventArgs e)
        {    
            db.Products.Load(); //or db.Products.ToList();


            //Exception : this.dataGridView2.DataSource= db.Products;
            //類型 'System.NotSupportedException' 的未處理例外狀況發生於 EntityFramework.dll

            //NOTE:其他資訊: 不支援資料直接繫結到存放區查詢 (DbSet、DbQuery、DbSqlQuery、DbRawSqlQuery)。
            //請改成為 DbSet 填入資料 (例如，在 DbSet 上呼叫 Load)，然後繫結到本機資料。
            //若是 WPF，請繫結到 DbSet.Local。
            //若是 WinForms，則繫結到 DbSet.Local.ToBindingList()。
            //若是 ASP.NET WebForms，您可以繫結到針對查詢呼叫 ToList() 的結果，或使用模型繫結。如需詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=389592。
            //this.dataGridView2.DataSource = db.Products;

     
           //==============================================
            //用不同的 binding 方式, 測試 Add or Delete one product 的結果 , 是否通知事件 UI 

            //this.dataGridView1.DataSource = db.Products.ToList(); //都不 OK (List 是 readonly)
            //this.dataGridView2.DataSource = db.Products.Local; //for wpf ok, windows forms NOT OK (observarableCollection 會通知)
            //this.dataGridView3.DataSource = db.Products.Local.ToBindingList();  //windows Forms OK
            //===============================================

            // BindingList<T> 它會維持Control與給定的 System.Collections.ObjectModel.ObservableCollection<T>同步。
            //(ObservableCollection<T> 會通知 - public virtual event NotifyCollectionChangedEventHandler CollectionChanged;
            this.dataGridView1.DataSource = db.Products.Local.ToBindingList();
  
           //===================================================
           //.ToList() 它不會不會維持 Control 與給定的  List 同步 (應該是 list 不會通知)
             prodList = db.Products.ToList();
            this.dataGridView2.DataSource = prodList;
            prodList.Add(new Product { ProductName = "12345", Discontinued = true });

        
        }

        List<Product> prodList;
         private void button6_Click(object sender, EventArgs e)
        {
           db.Products.Local.Add(new Product { ProductName = "Test " + DateTime.Now.ToLongTimeString(), Discontinued = true });
         
             //other way
            //Product p = new Product { ProductName = "Test " + DateTime.Now.ToLongTimeString(), Discontinued = true };
            // db.Entry(p).State = EntityState.Added;

        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            db.SaveChanges();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //update
            var product = (from p in db.Products.Local
                           where p.ProductName.Contains("Test")
                           select p).FirstOrDefault();

            if (product == null) return;
            product.ProductName = "Test" + product.ProductName;
            
            //必須移動 position
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete one product
            var product = (from p in db.Products.Local
                           where p.ProductName.Contains("Test")
                           select p).FirstOrDefault();

            if (product == null) return;
            this.db.Products.Local.Remove(product);

   
        }

        private void button5_Click(object sender, EventArgs e)
        {     
          
            //delete all
            var q = from p in db.Products.Local
                    where p.ProductName.Contains("Test")
                    select p;

        
            //??????
            //var x = db.Products.Find(2);
            //db.Entry(x).State = EntityState.Added;

              //   Note: exception 集合已修改; 列舉作業可能尚未執行。
          //  foreach (var product in q)

            var list = q.ToList();
            for (int i = list.Count - 1; i >=0; i--)
            {
                //this.db.Entry(list[i]).State = EntityState.Deleted;
                this.db.Products.Local.Remove(list[i]);
            }

        }
  #endregion

        private void button15_Click(object sender, EventArgs e)
        {

            //var Product= this.db.Products.First();
            //Product.ProductName += "xxx";
            //if (this.db.Entry(Product).State == EntityState.Modified)
            //{
            //    //modify  entity
            //    MessageBox.Show(this.db.Entry(Product).State.ToString());
            //}
        


            //ObjectContext 要透過介面變數拿
            ObjectStateManager objectStateManager = ((IObjectContextAdapter)db).ObjectContext.ObjectStateManager;

            //很多功能在 ObjectContext   
            //確保 System.Data.Entity.Core.Objects.ObjectStateEntry 變更與 System.Data.Entity.Core.Objects.ObjectStateManager
            // 所追蹤之所有物件中的變更同步
            ((System.Data.Entity.Infrastructure.IObjectContextAdapter)db).ObjectContext.DetectChanges();


            //this.dataGridView1.DataSource = objectStateManager.GetObjectStateEntries(EntityState.Added);
            //this.dataGridView2.DataSource = objectStateManager.GetObjectStateEntries(EntityState.Deleted);
            //this.dataGridView3.DataSource = objectStateManager.GetObjectStateEntries(EntityState.Modified);

            this.dataGridView1.DataSource = objectStateManager.GetObjectStateEntries(EntityState.Added).Select(entity =>
            {
                dynamic d = entity.Entity;
                return new { entity.EntityKey, entity.State, ProductID = d.ProductID, ProductName=d.ProductName };
            }).ToList();

           this.dataGridView2.DataSource = objectStateManager.GetObjectStateEntries(EntityState.Deleted).Select(entity =>
           {
               dynamic d = entity.Entity;
               return new { entity.EntityKey, entity.State, ProductID = d.ProductID, ProductName = d.ProductName };
           }).ToList();
            this.dataGridView3.DataSource = objectStateManager.GetObjectStateEntries(EntityState.Modified).Select(entity =>
            {
                dynamic d = entity.Entity;
                return new { entity.EntityKey, entity.State, ProductID = d.ProductID, ProductName = d.ProductName };
            }).ToList();

        }

        private void button17_Click(object sender, EventArgs e)
        {

            //第一次對指定模型執行任何查詢時，Entity Framework 會執行許多幕後工作以載入及驗證模型。我們通常將第一次查詢稱為「冷」查詢。
            //對已載入的模型所執行的進一步查詢稱為「暖」查詢，其速度比較快。

            ////load way
            //way 1. 
            this.db.Categories.Load();
            this.db.Products.Load();

            //way 2:
            // this.db.Categories.ToList();

            //this.db.Categories.Local;
            // 摘要:
            //     取得 System.Collections.ObjectModel.ObservableCollection`1，代表此集合中所有 Added、Unchanged
            //     和 Modified 實體的本機檢視。當從內容中加入或移除實體時，此本機檢視會維持同步的狀態。同樣地，從本機檢視加入或移除的實體將會自動加入至內容中或是從內容中移除。
            //
            // 傳回:
            //     本機檢視

            //Gets an ObservableCollection<T> that represents a local view of all Added, Unchanged, and Modified entities in this set. 
            //This local view will stay in sync as entities are added or removed from the context.
            //Likewise, entities added to or removed from the local view will automatically be added to or removed from the context. 
            //
            //  NorthwindEntities 就是 DataContext 內容 <=同步=> Local;本機檢視 backStore  在this.db.Categories.Local;本機檢視。
            System.Collections.ObjectModel.ObservableCollection<Category> local = this.db.Categories.Local;


           DbSet<Category> CategorySet = db.Categories;
           DbSet<Category> categorySet = db.Set<Category>();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //var q = from p in db.Products
            //        group p by p.CategoryID into g
            //        select new { g.Key, count= g.Count(), myGroup= g };

            //var q1 = from g in q
            //         from item in g.myGroup
            //         select new { g.Key, g.count, item.ProductName, item.UnitPrice };
            //this.dataGridView1.DataSource = q1.ToList();

                         

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Repository<Product> ProductsRepository = new Repository<Product>(db);
            this.dataGridView1.DataSource = ProductsRepository.GetAll().ToList();
           
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //ObjectQuery - Entity SQL
            //    int productID = 900;
            //    using (AdventureWorksEntities context =
            //        new AdventureWorksEntities())
            //    {
            //        string queryString = @"SELECT VALUE product FROM 
            //AdventureWorksEntities.Products AS product
            //WHERE product.ProductID > @productID";

            //        ObjectQuery<Product> productQuery1 =
            //            new ObjectQuery<Product>(queryString,
            //                context, MergeOption.NoTracking);

            //        productQuery1.Parameters.Add(new ObjectParameter("productID", productID));

            //        ObjectQuery<DbDataRecord> productQuery2 =
            //            productQuery1.Select("it.ProductID");

            //        foreach (DbDataRecord result in productQuery2)
            //        {
            //            Console.WriteLine("{0}", result["ProductID"]);
            //        }
            //    }


            //why ?? order by productID
            //inner join
            var q1 = from c in db.Categories
                     join p in db.Products
                     on c.CategoryID equals p.CategoryID
                     select  new { c.CategoryID, c.CategoryName, p.ProductID, p.ProductName, p.UnitsInStock };

            this.dataGridView1.DataSource = q1.ToList();

        }

        private void button25_Click(object sender, EventArgs e)
        {

            var q = from p in db.Products
                     where p.UnitsInStock > 30
                     select new { p.ProductName, p.UnitsInStock, p.UnitPrice, totalPrice = p.UnitPrice * p.UnitsInStock };


            this.dataGridView1.DataSource = q.ToList();

            //==========================
            var q2 = from p in db.Products    
                     group p by MyKey(p.ProductName);

            //db.Products.Last();
//類型 'System.NotSupportedException' 的未處理例外狀況發生於 EntityFramework.SqlServer.dll
//其他資訊: LINQ to Entities 無法辨識方法 'Char MyKey(System.String)' 方法，而且這個方法無法轉譯成存放區運算式。
            //this.dataGridView2.DataSource = q2.ToList();
         
            //Why AsEnumerable()  IQueryable<>=>IEnumerable<>, 否則自己方法 or 複雜 query 無法轉譯
            var q3 = from p in db.Products.AsEnumerable()  //只會執行  select * from products
                     group p by MyKey(p.ProductName);


            this.dataGridView3.DataSource = q3.ToList();
        }

        private char MyKey(string productName)
        {
            return productName[0];
        }

        private void button26_Click(object sender, EventArgs e)
        {
           this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.dataGridView1.DataSource = this.db.Categories.ToList();
          
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int categoryid = (int)this.dataGridView1.CurrentRow.Cells["CategoryID"].Value;
            this.dataGridView2.DataSource = db.Products.Where(p => p.CategoryID == categoryid).ToList();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            //find
            //Finds an entity with the given primary key values.
            //If an entity with the given primary key values exists in the context, then it is returned immediately without making a request to the store. 
            //Otherwise, a request is made to the store for an entity with the given primary key values and this entity, if found, is attached to the context and returned.
            //If no entity is found in the context or the store, then null is returned. 
            var product = db.Products.Find(1);

            if (product == null) return;

            MessageBox.Show(product.ProductName);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();


            //A DbContext instance represents a combination of the Unit Of Work and Repository patterns
            //such that it can be used to query from a database and group together changes that will then be written back to the store as a unit.DbContext is conceptually similar to ObjectContext.
            // DbContext 摘要:
            //     一個 DbContext 執行個體，表示工作單位和儲存機制模式的組合，
            //使其可用來從資料庫查詢並將變更群組在一起，然後這些變更會當做一個單位寫回存放區。DbContext
            //     在概念上類似於 ObjectContext。


            //====================================
//            實體架構 是 ADO.NET 中的一組技術，可支援資料導向軟體應用程式的開發
//edmx 用 XML 文件看
//   EDM 是由下列三個模型和對應檔(具有對應的副檔名) 所定義：
//•	概念結構定義語言檔案(.csdl) - 定義概念模型。
//•	存放結構定義語言檔案(.ssdl) - 定義儲存模型，也稱為邏輯模型。
//•	對應規格語言檔案(.msl) - 定義儲存和概念模型之間的對應。

            //概念上的模型 - 從 資料庫更新模型
             // NorthwindEntities : DBContext -內容;  In-Memory DB 環境
            // db.Products  : Entity - 實體  如 Products Entity (所以以後 object 就盡量叫做執行個體)
            // db.Products    放一個個 Entity Object product 物件 (導覽屬性)

            // 更新模型
            // Stored Procedure

            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            var q1 = from p in db.Products
                     //where p.UnitsInStock > 30
                     select new {p.ProductID, p.ProductName, p.UnitsInStock, p.UnitPrice, totalPrice = p.UnitPrice * p.UnitsInStock };

        
            int[] nums = { 1, 2, 3 };
            var q2 = from n in nums select new { n };

            this.dataGridView1.DataSource = q2;  //OK
                                                 
            //==================================================
            //型 'System.NotSupportedException' 的未處理例外狀況發生於 EntityFramework.dll

            //其他資訊: 不支援資料直接繫結到存放區查詢(DbSet、DbQuery、DbSqlQuery、DbRawSqlQuery)。
            //請改成為 DbSet 填入資料(例如，在 DbSet 上呼叫 Load)，然後繫結到本機資料。
            //若是 WPF，請繫結到 DbSet.Local。
            //若是 WinForms，則繫結到 DbSet.Local.ToBindingList()。
            //若是 ASP.NET WebForms，您可以繫結到針對查詢呼叫 ToList() 的結果，或使用模型繫結。

            //this.dataGridView1.DataSource = q1; // NotSupportedException

            //Solution1:用　list , 但不會看到新增刪除
              this.dataGridView1.DataSource = q1.ToList();

            //Solution2: wpf 用　local ObservableCollection , 會看到新增刪除
            //Solution2: winform 用　locall.ToBindingList(); , 會看到新增刪除

            BindingSource bs;  // 繼承: IBindingList
            db.Products.Load();
            this.dataGridView2.DataSource = db.Products.Local.ToBindingList();// return  IBindingList

            //move binding position or use BindingSource 較好
           BindingList<Product> binding = db.Products.Local.ToBindingList();
            this.dataGridView2.BindingContext[binding].Position += 1;
            binding.ListChanged += Binding_ListChanged;

        }

        private void Binding_ListChanged(object sender, ListChangedEventArgs e)
        {
           
        }

       async private void button31_Click(object sender, EventArgs e)
        {
            //其實用方法就可以了
            //Dynamic LINQ 讓 LINQ 的世界變的更美好
            //nuget system.linq.dynamic
            //using system.linq.dynamic
            db.Database.Log = Console.WriteLine;
          
            var query =
                db.Customers.Where("City == @0 and Orders.Count >= @1", "London", 10).
                OrderBy("CompanyName").
                Select("New (CompanyName as Name, Phone)");
                Console.WriteLine(query);

             var result = await   query.ToListAsync();
            this.dataGridView1.DataSource = result;

            //============================
            using (EntityConnection conn =
    new EntityConnection("name=AdventureWorksEntities"))
            {
                conn.Open();
                // Create a query that takes two parameters.
                string esqlQuery =
                    @"SELECT VALUE Contact FROM AdventureWorksEntities.Contacts 
                    AS Contact WHERE Contact.LastName = @ln AND
                    Contact.FirstName = @fn";

                using (EntityCommand cmd = new EntityCommand(esqlQuery, conn))
                {
                    // Create two parameters and add them to 
                    // the EntityCommand's Parameters collection 
                    EntityParameter param1 = new EntityParameter();
                    param1.ParameterName = "ln";
                    param1.Value = "Adams";
                    EntityParameter param2 = new EntityParameter();
                    param2.ParameterName = "fn";
                    param2.Value = "Frances";

                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);

                    using (DbDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                    {
                        // Iterate through the collection of Contact items.
                        while (rdr.Read())
                        {
                           this.listBox1.Items.Add(rdr["FirstName"]);
                          this.listBox1.Items.Add(rdr["LastName"]);
                        }
                    }
                }
                conn.Close();
            }


        }

        private void button32_Click(object sender, EventArgs e)
        {
         //   var qx = db.Products.Find(11);

            var q = from p in db.Products
                    group p by p.CategoryID into g
                    select new { g.Key, count = g.Count(), myGroup = g };

            var q1 = from g in q
                     from item in g.myGroup
                     select new { g.Key, g.count,item.ProductID, item.ProductName, item.UnitPrice  };
            this.dataGridView1.DataSource = q1.ToList();


            int[] targetIDs = { 2, 3, 7, 8 };
            var q2 = db.Products.Where(p => targetIDs.Contains(p.ProductID));
            this.dataGridView2.DataSource = q2.ToList();

           
            

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            var q = db.Categories.Select(c=>new {c.CategoryID,  c.CategoryName, Count = c.Products.Count })
                                            .OrderByDescending(p => p.Count)
                                            .Take(6);

            this.dataGridView1.DataSource = q.ToList();



            var q1 = (from p in db.Products.AsEnumerable()
                           where p.Category != null
                           group p by p.Category into g
                            select new { g.Key.CategoryID, g.Key.CategoryName, Count = g.Count() }).OrderByDescending(g => g.Count).Take(6);

            this.dataGridView2.DataSource = q1.ToList();

        
         


        }

        private void button34_Click(object sender, EventArgs e)
        {
            //local 是永遠記憶體查詢, 不會執行 T-SQL
            var q = from  p in  db.Products.Local
                         select  p;

            this.dataGridView1.DataSource = q.ToList();

            //=============================
            //select 具名型別 product Identity
            //非 local 是 Identity 的同步, 不在的 identity 才從實體 DB 撈

            var q1 = from p in db.Products
                     select p;

            this.dataGridView2.DataSource = q1.ToList();

            //select new 匿名型別, 一定都到 實體 db 查
            var q2 = from p in db.Products
                         orderby p.ProductID
                     select new { p.ProductID, p.ProductName };

            this.dataGridView3.DataSource = q2.ToList();

        }
    }
}
public static class DateTimeExtension
{
    public static string Season(this DateTime? source)
    {
        switch (source.Value.Month)
        {
            case 1:
            case 2:
            case 3:
                return "第一季";
            case 4:
            case 5:
            case 6:
                return "第二季";
            case 7:
            case 8:
            case 9:
                return "第三季";
            case 10:
            case 11:
            case 12:
                return "第四季";
        }
        return "";


    }
}