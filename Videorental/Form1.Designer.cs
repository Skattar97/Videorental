namespace Videorental
{
    partial class Form1
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.btnaddcust = new System.Windows.Forms.Button();
            this.btnupdatecust = new System.Windows.Forms.Button();
            this.btndelcust = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnupdatemov = new System.Windows.Forms.Button();
            this.textMgenre = new System.Windows.Forms.TextBox();
            this.textMplot = new System.Windows.Forms.TextBox();
            this.textMcopies = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btndelmov = new System.Windows.Forms.Button();
            this.textMtitle = new System.Windows.Forms.TextBox();
            this.btnaddmov = new System.Windows.Forms.Button();
            this.textMrating = new System.Windows.Forms.TextBox();
            this.textMyear = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioall = new System.Windows.Forms.RadioButton();
            this.radioout = new System.Windows.Forms.RadioButton();
            this.lblcidfk = new System.Windows.Forms.Label();
            this.lblmidfk = new System.Windows.Forms.Label();
            this.textrmid = new System.Windows.Forms.TextBox();
            this.ddcust = new System.Windows.Forms.ComboBox();
            this.ddmov = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnissumov = new System.Windows.Forms.Button();
            this.btnretmov = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1101, 520);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::Videorental.Properties.Resources.imag;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textFname);
            this.tabPage1.Controls.Add(this.textLname);
            this.tabPage1.Controls.Add(this.textAddress);
            this.tabPage1.Controls.Add(this.textPhone);
            this.tabPage1.Controls.Add(this.btnaddcust);
            this.tabPage1.Controls.Add(this.btnupdatecust);
            this.tabPage1.Controls.Add(this.btndelcust);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1034, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 14;
            this.label12.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "FirstName";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1090, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textFname
            // 
            this.textFname.Location = new System.Drawing.Point(93, 425);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(129, 20);
            this.textFname.TabIndex = 6;
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(93, 462);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(129, 20);
            this.textLname.TabIndex = 7;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(348, 428);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(116, 20);
            this.textAddress.TabIndex = 8;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(348, 465);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(114, 20);
            this.textPhone.TabIndex = 9;
            // 
            // btnaddcust
            // 
            this.btnaddcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcust.Location = new System.Drawing.Point(590, 445);
            this.btnaddcust.Name = "btnaddcust";
            this.btnaddcust.Size = new System.Drawing.Size(97, 23);
            this.btnaddcust.TabIndex = 1;
            this.btnaddcust.Text = "Add Customer";
            this.btnaddcust.UseVisualStyleBackColor = true;
            this.btnaddcust.Click += new System.EventHandler(this.btnaddcust_Click);
            // 
            // btnupdatecust
            // 
            this.btnupdatecust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecust.Location = new System.Drawing.Point(746, 445);
            this.btnupdatecust.Name = "btnupdatecust";
            this.btnupdatecust.Size = new System.Drawing.Size(114, 23);
            this.btnupdatecust.TabIndex = 2;
            this.btnupdatecust.Text = "Update Customer";
            this.btnupdatecust.UseVisualStyleBackColor = true;
            this.btnupdatecust.Click += new System.EventHandler(this.btnupdatecust_Click);
            // 
            // btndelcust
            // 
            this.btndelcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelcust.Location = new System.Drawing.Point(905, 445);
            this.btndelcust.Name = "btndelcust";
            this.btndelcust.Size = new System.Drawing.Size(115, 23);
            this.btndelcust.TabIndex = 3;
            this.btndelcust.Text = "Delete Customer";
            this.btndelcust.UseVisualStyleBackColor = true;
            this.btndelcust.Click += new System.EventHandler(this.btndelcust_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.BackgroundImage = global::Videorental.Properties.Resources.images__1_;
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnupdatemov);
            this.tabPage2.Controls.Add(this.textMgenre);
            this.tabPage2.Controls.Add(this.textMplot);
            this.tabPage2.Controls.Add(this.textMcopies);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btndelmov);
            this.tabPage2.Controls.Add(this.textMtitle);
            this.tabPage2.Controls.Add(this.btnaddmov);
            this.tabPage2.Controls.Add(this.textMrating);
            this.tabPage2.Controls.Add(this.textMyear);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 28;
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Genre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Plot";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Copies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Title";
            // 
            // btnupdatemov
            // 
            this.btnupdatemov.Location = new System.Drawing.Point(542, 415);
            this.btnupdatemov.Name = "btnupdatemov";
            this.btnupdatemov.Size = new System.Drawing.Size(99, 23);
            this.btnupdatemov.TabIndex = 20;
            this.btnupdatemov.Text = "Update Movie";
            this.btnupdatemov.UseVisualStyleBackColor = true;
            this.btnupdatemov.Click += new System.EventHandler(this.btnupdatemov_Click);
            // 
            // textMgenre
            // 
            this.textMgenre.Location = new System.Drawing.Point(379, 378);
            this.textMgenre.Name = "textMgenre";
            this.textMgenre.Size = new System.Drawing.Size(100, 20);
            this.textMgenre.TabIndex = 16;
            // 
            // textMplot
            // 
            this.textMplot.Location = new System.Drawing.Point(379, 456);
            this.textMplot.Name = "textMplot";
            this.textMplot.Size = new System.Drawing.Size(100, 20);
            this.textMplot.TabIndex = 15;
            // 
            // textMcopies
            // 
            this.textMcopies.Location = new System.Drawing.Point(379, 421);
            this.textMcopies.Name = "textMcopies";
            this.textMcopies.Size = new System.Drawing.Size(100, 20);
            this.textMcopies.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1084, 340);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btndelmov
            // 
            this.btndelmov.Location = new System.Drawing.Point(542, 453);
            this.btndelmov.Name = "btndelmov";
            this.btndelmov.Size = new System.Drawing.Size(97, 23);
            this.btndelmov.TabIndex = 5;
            this.btndelmov.Text = "Delete Movie";
            this.btndelmov.UseVisualStyleBackColor = true;
            this.btndelmov.Click += new System.EventHandler(this.btndelmov_Click);
            // 
            // textMtitle
            // 
            this.textMtitle.Location = new System.Drawing.Point(116, 374);
            this.textMtitle.Name = "textMtitle";
            this.textMtitle.Size = new System.Drawing.Size(116, 20);
            this.textMtitle.TabIndex = 12;
            // 
            // btnaddmov
            // 
            this.btnaddmov.Location = new System.Drawing.Point(542, 378);
            this.btnaddmov.Name = "btnaddmov";
            this.btnaddmov.Size = new System.Drawing.Size(97, 23);
            this.btnaddmov.TabIndex = 4;
            this.btnaddmov.Text = "Add Movie";
            this.btnaddmov.UseVisualStyleBackColor = true;
            this.btnaddmov.Click += new System.EventHandler(this.btnaddmov_Click);
            // 
            // textMrating
            // 
            this.textMrating.Location = new System.Drawing.Point(116, 417);
            this.textMrating.Name = "textMrating";
            this.textMrating.Size = new System.Drawing.Size(116, 20);
            this.textMrating.TabIndex = 10;
            // 
            // textMyear
            // 
            this.textMyear.Location = new System.Drawing.Point(116, 456);
            this.textMyear.Name = "textMyear";
            this.textMyear.Size = new System.Drawing.Size(116, 20);
            this.textMyear.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.BackgroundImage = global::Videorental.Properties.Resources.images__1_;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.lblcidfk);
            this.tabPage3.Controls.Add(this.lblmidfk);
            this.tabPage3.Controls.Add(this.textrmid);
            this.tabPage3.Controls.Add(this.ddcust);
            this.tabPage3.Controls.Add(this.ddmov);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.btnissumov);
            this.tabPage3.Controls.Add(this.btnretmov);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1093, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioall);
            this.groupBox1.Controls.Add(this.radioout);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(654, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Movies";
            // 
            // radioall
            // 
            this.radioall.AutoSize = true;
            this.radioall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioall.Location = new System.Drawing.Point(6, 19);
            this.radioall.Name = "radioall";
            this.radioall.Size = new System.Drawing.Size(74, 17);
            this.radioall.TabIndex = 16;
            this.radioall.TabStop = true;
            this.radioall.Text = "All Rented";
            this.radioall.UseVisualStyleBackColor = true;
            this.radioall.Click += new System.EventHandler(this.radioall_Click);
            // 
            // radioout
            // 
            this.radioout.AutoSize = true;
            this.radioout.Location = new System.Drawing.Point(97, 19);
            this.radioout.Name = "radioout";
            this.radioout.Size = new System.Drawing.Size(80, 17);
            this.radioout.TabIndex = 17;
            this.radioout.TabStop = true;
            this.radioout.Text = "Out Rented";
            this.radioout.UseVisualStyleBackColor = true;
            this.radioout.Click += new System.EventHandler(this.radioout_Click);
            // 
            // lblcidfk
            // 
            this.lblcidfk.AutoSize = true;
            this.lblcidfk.Location = new System.Drawing.Point(991, 415);
            this.lblcidfk.Name = "lblcidfk";
            this.lblcidfk.Size = new System.Drawing.Size(0, 13);
            this.lblcidfk.TabIndex = 33;
            this.lblcidfk.Visible = false;
            // 
            // lblmidfk
            // 
            this.lblmidfk.AutoSize = true;
            this.lblmidfk.Location = new System.Drawing.Point(991, 460);
            this.lblmidfk.Name = "lblmidfk";
            this.lblmidfk.Size = new System.Drawing.Size(0, 13);
            this.lblmidfk.TabIndex = 32;
            this.lblmidfk.Visible = false;
            // 
            // textrmid
            // 
            this.textrmid.Location = new System.Drawing.Point(908, 437);
            this.textrmid.Name = "textrmid";
            this.textrmid.Size = new System.Drawing.Size(72, 20);
            this.textrmid.TabIndex = 31;
            // 
            // ddcust
            // 
            this.ddcust.FormattingEnabled = true;
            this.ddcust.Location = new System.Drawing.Point(183, 412);
            this.ddcust.Name = "ddcust";
            this.ddcust.Size = new System.Drawing.Size(121, 21);
            this.ddcust.TabIndex = 26;
            this.ddcust.SelectedIndexChanged += new System.EventHandler(this.ddcust_SelectedIndexChanged);
            // 
            // ddmov
            // 
            this.ddmov.FormattingEnabled = true;
            this.ddmov.Location = new System.Drawing.Point(183, 455);
            this.ddmov.Name = "ddmov";
            this.ddmov.Size = new System.Drawing.Size(121, 21);
            this.ddmov.TabIndex = 25;
            this.ddmov.SelectedIndexChanged += new System.EventHandler(this.ddmov_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1032, 415);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 24;
            this.label16.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 415);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Movie ID";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1087, 402);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // btnissumov
            // 
            this.btnissumov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnissumov.ForeColor = System.Drawing.Color.Red;
            this.btnissumov.Location = new System.Drawing.Point(378, 427);
            this.btnissumov.Name = "btnissumov";
            this.btnissumov.Size = new System.Drawing.Size(67, 39);
            this.btnissumov.TabIndex = 14;
            this.btnissumov.Text = "Issue Movie";
            this.btnissumov.UseVisualStyleBackColor = true;
            this.btnissumov.Click += new System.EventHandler(this.btnissumov_Click);
            // 
            // btnretmov
            // 
            this.btnretmov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretmov.ForeColor = System.Drawing.Color.Green;
            this.btnretmov.Location = new System.Drawing.Point(498, 427);
            this.btnretmov.Name = "btnretmov";
            this.btnretmov.Size = new System.Drawing.Size(67, 39);
            this.btnretmov.TabIndex = 15;
            this.btnretmov.Text = "Return Movie";
            this.btnretmov.UseVisualStyleBackColor = true;
            this.btnretmov.Click += new System.EventHandler(this.btnretmov_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1101, 522);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnaddcust;
        private System.Windows.Forms.Button btnupdatecust;
        private System.Windows.Forms.Button btndelcust;
        private System.Windows.Forms.Button btnaddmov;
        private System.Windows.Forms.Button btndelmov;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textMrating;
        private System.Windows.Forms.TextBox textMyear;
        private System.Windows.Forms.TextBox textMtitle;
        private System.Windows.Forms.Button btnissumov;
        private System.Windows.Forms.Button btnretmov;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnupdatemov;
        private System.Windows.Forms.TextBox textMgenre;
        private System.Windows.Forms.TextBox textMplot;
        private System.Windows.Forms.TextBox textMcopies;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ddcust;
        private System.Windows.Forms.ComboBox ddmov;
        private System.Windows.Forms.Label lblcidfk;
        private System.Windows.Forms.Label lblmidfk;
        private System.Windows.Forms.TextBox textrmid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioall;
        private System.Windows.Forms.RadioButton radioout;
    }
}

