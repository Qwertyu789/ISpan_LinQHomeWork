
namespace MyHomeWork
{
    partial class Frm作業_1
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaster = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnMathnopass = new System.Windows.Forms.Button();
            this.btnNobbb = new System.Windows.Forms.Button();
            this.brnFindbbb = new System.Windows.Forms.Button();
            this.btnLast2 = new System.Windows.Forms.Button();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.btnFront3 = new System.Windows.Forms.Button();
            this.btnHowmany = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNxtPg = new System.Windows.Forms.Button();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.btnLstPg = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbPiece = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nwDataSet1 = new LinqLabs.NWDataSet();
            this.ordersTableAdapter1 = new LinqLabs.NWDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager1 = new LinqLabs.NWDataSetTableAdapters.TableAdapterManager();
            this.order_DetailsTableAdapter1 = new LinqLabs.NWDataSetTableAdapters.Order_DetailsTableAdapter();
            this.productsTableAdapter1 = new LinqLabs.NWDataSetTableAdapters.ProductsTableAdapter();
            this.button37 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 451);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Font = new System.Drawing.Font("新細明體", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(4, 0);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(872, 40);
            this.lblDetails.TabIndex = 102;
            this.lblDetails.Text = "訂單明細";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(5, 45);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(870, 401);
            this.dataGridView2.TabIndex = 100;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1531, 455);
            this.splitContainer2.SplitterDistance = 642;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaster
            // 
            this.lblMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaster.Font = new System.Drawing.Font("新細明體", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaster.ForeColor = System.Drawing.Color.White;
            this.lblMaster.Location = new System.Drawing.Point(4, 0);
            this.lblMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(630, 40);
            this.lblMaster.TabIndex = 101;
            this.lblMaster.Text = "訂單";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 401);
            this.dataGridView1.TabIndex = 71;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button37);
            this.splitContainer1.Panel1.Controls.Add(this.btnMathnopass);
            this.splitContainer1.Panel1.Controls.Add(this.btnNobbb);
            this.splitContainer1.Panel1.Controls.Add(this.brnFindbbb);
            this.splitContainer1.Panel1.Controls.Add(this.btnLast2);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindStudent);
            this.splitContainer1.Panel1.Controls.Add(this.btnFront3);
            this.splitContainer1.Panel1.Controls.Add(this.btnHowmany);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearchStudent);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button14);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnNxtPg);
            this.splitContainer1.Panel1.Controls.Add(this.combobox);
            this.splitContainer1.Panel1.Controls.Add(this.btnLstPg);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.tbPiece);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1531, 801);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 136;
            // 
            // btnMathnopass
            // 
            this.btnMathnopass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMathnopass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMathnopass.Location = new System.Drawing.Point(1153, 149);
            this.btnMathnopass.Margin = new System.Windows.Forms.Padding(4);
            this.btnMathnopass.Name = "btnMathnopass";
            this.btnMathnopass.Size = new System.Drawing.Size(302, 39);
            this.btnMathnopass.TabIndex = 150;
            this.btnMathnopass.Text = "找出誰數學不及格";
            this.btnMathnopass.UseVisualStyleBackColor = false;
            this.btnMathnopass.Click += new System.EventHandler(this.btnMathnopass_Click);
            // 
            // btnNobbb
            // 
            this.btnNobbb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNobbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNobbb.Location = new System.Drawing.Point(843, 149);
            this.btnNobbb.Margin = new System.Windows.Forms.Padding(4);
            this.btnNobbb.Name = "btnNobbb";
            this.btnNobbb.Size = new System.Drawing.Size(302, 39);
            this.btnNobbb.TabIndex = 150;
            this.btnNobbb.Text = "找出\"bbb\"以外的成績";
            this.btnNobbb.UseVisualStyleBackColor = false;
            this.btnNobbb.Click += new System.EventHandler(this.btnNobbb_Click);
            // 
            // brnFindbbb
            // 
            this.brnFindbbb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.brnFindbbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnFindbbb.Location = new System.Drawing.Point(1153, 100);
            this.brnFindbbb.Margin = new System.Windows.Forms.Padding(4);
            this.brnFindbbb.Name = "brnFindbbb";
            this.brnFindbbb.Size = new System.Drawing.Size(302, 39);
            this.brnFindbbb.TabIndex = 150;
            this.brnFindbbb.Text = "找出\"bbb\"的成績";
            this.brnFindbbb.UseVisualStyleBackColor = false;
            this.brnFindbbb.Click += new System.EventHandler(this.brnFindbbb_Click);
            // 
            // btnLast2
            // 
            this.btnLast2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast2.Location = new System.Drawing.Point(1153, 52);
            this.btnLast2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast2.Name = "btnLast2";
            this.btnLast2.Size = new System.Drawing.Size(302, 39);
            this.btnLast2.TabIndex = 150;
            this.btnLast2.Text = "後兩個學員成績";
            this.btnLast2.UseVisualStyleBackColor = false;
            this.btnLast2.Click += new System.EventHandler(this.btnLast2_Click);
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFindStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindStudent.Location = new System.Drawing.Point(843, 100);
            this.btnFindStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(302, 39);
            this.btnFindStudent.TabIndex = 149;
            this.btnFindStudent.Text = "找出\"aaa\"\"bbb\"\"ccc\"";
            this.btnFindStudent.UseVisualStyleBackColor = false;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // btnFront3
            // 
            this.btnFront3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFront3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFront3.Location = new System.Drawing.Point(843, 52);
            this.btnFront3.Margin = new System.Windows.Forms.Padding(4);
            this.btnFront3.Name = "btnFront3";
            this.btnFront3.Size = new System.Drawing.Size(302, 39);
            this.btnFront3.TabIndex = 150;
            this.btnFront3.Text = "前三個學員成績";
            this.btnFront3.UseVisualStyleBackColor = false;
            this.btnFront3.Click += new System.EventHandler(this.btnFront3_Click);
            // 
            // btnHowmany
            // 
            this.btnHowmany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHowmany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowmany.Location = new System.Drawing.Point(1153, 11);
            this.btnHowmany.Margin = new System.Windows.Forms.Padding(4);
            this.btnHowmany.Name = "btnHowmany";
            this.btnHowmany.Size = new System.Drawing.Size(302, 37);
            this.btnHowmany.TabIndex = 149;
            this.btnHowmany.Text = "共幾個成績";
            this.btnHowmany.UseVisualStyleBackColor = false;
            this.btnHowmany.Click += new System.EventHandler(this.btnHowmany_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(843, 11);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(302, 37);
            this.btnSearchStudent.TabIndex = 148;
            this.btnSearchStudent.Text = "搜尋 班級學生成績";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(60, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(372, 42);
            this.button3.TabIndex = 136;
            this.button3.Text = "     FileInfo[] ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnALLdata);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(457, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 14);
            this.label3.TabIndex = 135;
            this.label3.Text = "LINQ to Northwind DataSet - Products";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(457, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 14);
            this.label9.TabIndex = 134;
            this.label9.Text = "年:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(57, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 14);
            this.label4.TabIndex = 103;
            this.label4.Text = "LINQ to FileInfo[]";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(452, 60);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(372, 42);
            this.button6.TabIndex = 133;
            this.button6.Text = "All 訂單 ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnAllOrders);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button14.Location = new System.Drawing.Point(60, 97);
            this.button14.Margin = new System.Windows.Forms.Padding(5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(372, 42);
            this.button14.TabIndex = 69;
            this.button14.Text = "     FileInfo[]  .Log  擋";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnlogextension);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(452, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 42);
            this.button1.TabIndex = 70;
            this.button1.Text = "     某年訂單 / 訂單明細";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnYearOrder);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(60, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 42);
            this.button2.TabIndex = 72;
            this.button2.Text = "     FileInfo[]   - 2017 Created - oerder ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn2017dataoderby);
            // 
            // btnNxtPg
            // 
            this.btnNxtPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNxtPg.ForeColor = System.Drawing.Color.Black;
            this.btnNxtPg.Location = new System.Drawing.Point(601, 278);
            this.btnNxtPg.Margin = new System.Windows.Forms.Padding(5);
            this.btnNxtPg.Name = "btnNxtPg";
            this.btnNxtPg.Size = new System.Drawing.Size(137, 42);
            this.btnNxtPg.TabIndex = 96;
            this.btnNxtPg.Text = "下一頁";
            this.btnNxtPg.UseVisualStyleBackColor = false;
            this.btnNxtPg.Click += new System.EventHandler(this.btnNxtPg_Click);
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(509, 167);
            this.combobox.Margin = new System.Windows.Forms.Padding(4);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(176, 21);
            this.combobox.TabIndex = 125;
            this.combobox.Text = "1996";
            // 
            // btnLstPg
            // 
            this.btnLstPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLstPg.ForeColor = System.Drawing.Color.Black;
            this.btnLstPg.Location = new System.Drawing.Point(452, 278);
            this.btnLstPg.Margin = new System.Windows.Forms.Padding(5);
            this.btnLstPg.Name = "btnLstPg";
            this.btnLstPg.Size = new System.Drawing.Size(137, 42);
            this.btnLstPg.TabIndex = 97;
            this.btnLstPg.Text = "上一頁";
            this.btnLstPg.UseVisualStyleBackColor = false;
            this.btnLstPg.Click += new System.EventHandler(this.btnLstPg_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(60, 183);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(372, 42);
            this.button4.TabIndex = 124;
            this.button4.Text = "     FileInfo[]   - 大檔案";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnHugedata);
            // 
            // tbPiece
            // 
            this.tbPiece.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPiece.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbPiece.Location = new System.Drawing.Point(564, 241);
            this.tbPiece.Margin = new System.Windows.Forms.Padding(5);
            this.tbPiece.Name = "tbPiece";
            this.tbPiece.Size = new System.Drawing.Size(180, 23);
            this.tbPiece.TabIndex = 98;
            this.tbPiece.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(445, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 99;
            this.label1.Text = "一頁幾筆";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(448, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 14);
            this.label5.TabIndex = 104;
            this.label5.Text = "LINQ to Northwind DataSet - Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(574, 519);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 135;
            this.label2.Text = "Year:";
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Order_DetailsTableAdapter = null;
            this.tableAdapterManager1.OrdersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.ProductsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = LinqLabs.NWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button37.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button37.Location = new System.Drawing.Point(943, 196);
            this.button37.Margin = new System.Windows.Forms.Padding(4);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(375, 39);
            this.button37.TabIndex = 151;
            this.button37.Text = "每個學生個人成績";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // Frm作業_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 801);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm作業_1";
            this.Text = "Frm作業_1";
            this.Load += new System.EventHandler(this.Frm作業_1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNxtPg;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Button btnLstPg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private LinqLabs.NWDataSet nwDataSet1;
        private LinqLabs.NWDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private LinqLabs.NWDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private LinqLabs.NWDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private LinqLabs.NWDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnMathnopass;
        private System.Windows.Forms.Button btnNobbb;
        private System.Windows.Forms.Button brnFindbbb;
        private System.Windows.Forms.Button btnLast2;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Button btnFront3;
        private System.Windows.Forms.Button btnHowmany;
        private System.Windows.Forms.Button button37;
    }
}