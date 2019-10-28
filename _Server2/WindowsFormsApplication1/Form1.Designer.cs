namespace WindowsFormsApplication1
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
            this.dataKargolar = new System.Windows.Forms.DataGridView();
            this.txtGetir = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txUpdatetUrunler = new System.Windows.Forms.RichTextBox();
            this.txtUpdateBarkod = new System.Windows.Forms.TextBox();
            this.txtUpdateKod = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEkleUrunler = new System.Windows.Forms.RichTextBox();
            this.txtEkleBarkod = new System.Windows.Forms.TextBox();
            this.txtEkleKod = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataSatislar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.btnSatisYenile = new System.Windows.Forms.Button();
            this.btnSatisGetir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSatisGuncelle = new System.Windows.Forms.Button();
            this.txtSatislarUrunler = new System.Windows.Forms.RichTextBox();
            this.txtSatislarKisiID = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.txtSatisEkleKodlar = new System.Windows.Forms.RichTextBox();
            this.txtSatisEkleKisi = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataKisiler = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtKisiGetir = new System.Windows.Forms.TextBox();
            this.btnKisiYenile = new System.Windows.Forms.Button();
            this.btnKisiGetir = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtKisiSifre = new System.Windows.Forms.TextBox();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.txtKisiIsim = new System.Windows.Forms.TextBox();
            this.txtKisiID = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.txtKisiEkleSifre = new System.Windows.Forms.TextBox();
            this.txtKisiEkleIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataKargolar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSatislar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKisiler)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataKargolar
            // 
            this.dataKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKargolar.Location = new System.Drawing.Point(11, 6);
            this.dataKargolar.Name = "dataKargolar";
            this.dataKargolar.RowTemplate.Height = 24;
            this.dataKargolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKargolar.Size = new System.Drawing.Size(918, 456);
            this.dataKargolar.TabIndex = 0;
            this.dataKargolar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKargolar_CellClick);
            this.dataKargolar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtGetir
            // 
            this.txtGetir.Location = new System.Drawing.Point(49, 58);
            this.txtGetir.Name = "txtGetir";
            this.txtGetir.Size = new System.Drawing.Size(157, 22);
            this.txtGetir.TabIndex = 1;
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(49, 86);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(157, 59);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txUpdatetUrunler);
            this.groupBox1.Controls.Add(this.txtUpdateBarkod);
            this.groupBox1.Controls.Add(this.txtUpdateKod);
            this.groupBox1.Location = new System.Drawing.Point(258, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(87, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txUpdatetUrunler
            // 
            this.txUpdatetUrunler.Location = new System.Drawing.Point(87, 81);
            this.txUpdatetUrunler.Name = "txUpdatetUrunler";
            this.txUpdatetUrunler.Size = new System.Drawing.Size(155, 131);
            this.txUpdatetUrunler.TabIndex = 2;
            this.txUpdatetUrunler.Text = "";
            // 
            // txtUpdateBarkod
            // 
            this.txtUpdateBarkod.Location = new System.Drawing.Point(87, 51);
            this.txtUpdateBarkod.Name = "txtUpdateBarkod";
            this.txtUpdateBarkod.Size = new System.Drawing.Size(155, 22);
            this.txtUpdateBarkod.TabIndex = 1;
            // 
            // txtUpdateKod
            // 
            this.txtUpdateKod.Enabled = false;
            this.txtUpdateKod.Location = new System.Drawing.Point(87, 21);
            this.txtUpdateKod.Name = "txtUpdateKod";
            this.txtUpdateKod.Size = new System.Drawing.Size(155, 22);
            this.txtUpdateKod.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtEkleUrunler);
            this.groupBox2.Controls.Add(this.txtEkleBarkod);
            this.groupBox2.Controls.Add(this.txtEkleKod);
            this.groupBox2.Location = new System.Drawing.Point(593, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 269);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(87, 220);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(155, 42);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEkleUrunler
            // 
            this.txtEkleUrunler.Location = new System.Drawing.Point(87, 81);
            this.txtEkleUrunler.Name = "txtEkleUrunler";
            this.txtEkleUrunler.Size = new System.Drawing.Size(155, 131);
            this.txtEkleUrunler.TabIndex = 2;
            this.txtEkleUrunler.Text = "";
            // 
            // txtEkleBarkod
            // 
            this.txtEkleBarkod.Location = new System.Drawing.Point(87, 51);
            this.txtEkleBarkod.Name = "txtEkleBarkod";
            this.txtEkleBarkod.Size = new System.Drawing.Size(155, 22);
            this.txtEkleBarkod.TabIndex = 1;
            // 
            // txtEkleKod
            // 
            this.txtEkleKod.Location = new System.Drawing.Point(87, 21);
            this.txtEkleKod.Name = "txtEkleKod";
            this.txtEkleKod.Size = new System.Drawing.Size(155, 22);
            this.txtEkleKod.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataSatislar);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 772);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Satislar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataSatislar
            // 
            this.dataSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSatislar.Location = new System.Drawing.Point(12, 6);
            this.dataSatislar.Name = "dataSatislar";
            this.dataSatislar.RowTemplate.Height = 24;
            this.dataSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSatislar.Size = new System.Drawing.Size(918, 477);
            this.dataSatislar.TabIndex = 11;
            this.dataSatislar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSatislar_CellClick);
            this.dataSatislar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSatislar_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Tomato;
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtSatisID);
            this.groupBox4.Controls.Add(this.btnSatisYenile);
            this.groupBox4.Controls.Add(this.btnSatisGetir);
            this.groupBox4.Location = new System.Drawing.Point(26, 489);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 269);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bul";
            // 
            // txtSatisID
            // 
            this.txtSatisID.Location = new System.Drawing.Point(60, 58);
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.Size = new System.Drawing.Size(157, 22);
            this.txtSatisID.TabIndex = 1;
            // 
            // btnSatisYenile
            // 
            this.btnSatisYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYenile.Location = new System.Drawing.Point(60, 151);
            this.btnSatisYenile.Name = "btnSatisYenile";
            this.btnSatisYenile.Size = new System.Drawing.Size(157, 59);
            this.btnSatisYenile.TabIndex = 5;
            this.btnSatisYenile.Text = "Yenile";
            this.btnSatisYenile.UseVisualStyleBackColor = true;
            this.btnSatisYenile.Click += new System.EventHandler(this.btnSatisYenile_Click);
            // 
            // btnSatisGetir
            // 
            this.btnSatisGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisGetir.Location = new System.Drawing.Point(60, 86);
            this.btnSatisGetir.Name = "btnSatisGetir";
            this.btnSatisGetir.Size = new System.Drawing.Size(157, 59);
            this.btnSatisGetir.TabIndex = 2;
            this.btnSatisGetir.Text = "Getir";
            this.btnSatisGetir.UseVisualStyleBackColor = true;
            this.btnSatisGetir.Click += new System.EventHandler(this.btnSatisGetir_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.btnSatisGuncelle);
            this.groupBox5.Controls.Add(this.txtSatislarUrunler);
            this.groupBox5.Controls.Add(this.txtSatislarKisiID);
            this.groupBox5.Location = new System.Drawing.Point(266, 489);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(329, 269);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürün Güncelle";
            // 
            // btnSatisGuncelle
            // 
            this.btnSatisGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisGuncelle.Location = new System.Drawing.Point(87, 197);
            this.btnSatisGuncelle.Name = "btnSatisGuncelle";
            this.btnSatisGuncelle.Size = new System.Drawing.Size(155, 42);
            this.btnSatisGuncelle.TabIndex = 3;
            this.btnSatisGuncelle.Text = "Güncelle";
            this.btnSatisGuncelle.UseVisualStyleBackColor = true;
            this.btnSatisGuncelle.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSatislarUrunler
            // 
            this.txtSatislarUrunler.Location = new System.Drawing.Point(87, 31);
            this.txtSatislarUrunler.Name = "txtSatislarUrunler";
            this.txtSatislarUrunler.Size = new System.Drawing.Size(155, 131);
            this.txtSatislarUrunler.TabIndex = 2;
            this.txtSatislarUrunler.Text = "";
            // 
            // txtSatislarKisiID
            // 
            this.txtSatislarKisiID.Location = new System.Drawing.Point(87, 170);
            this.txtSatislarKisiID.Name = "txtSatislarKisiID";
            this.txtSatislarKisiID.Size = new System.Drawing.Size(155, 22);
            this.txtSatislarKisiID.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.btnSatisEkle);
            this.groupBox6.Controls.Add(this.txtSatisEkleKodlar);
            this.groupBox6.Controls.Add(this.txtSatisEkleKisi);
            this.groupBox6.Location = new System.Drawing.Point(601, 489);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(329, 269);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Satış Ekle";
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisEkle.Location = new System.Drawing.Point(87, 196);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(155, 42);
            this.btnSatisEkle.TabIndex = 3;
            this.btnSatisEkle.Text = "Ekle";
            this.btnSatisEkle.UseVisualStyleBackColor = true;
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // txtSatisEkleKodlar
            // 
            this.txtSatisEkleKodlar.Location = new System.Drawing.Point(87, 31);
            this.txtSatisEkleKodlar.Name = "txtSatisEkleKodlar";
            this.txtSatisEkleKodlar.Size = new System.Drawing.Size(155, 131);
            this.txtSatisEkleKodlar.TabIndex = 2;
            this.txtSatisEkleKodlar.Text = "";
            // 
            // txtSatisEkleKisi
            // 
            this.txtSatisEkleKisi.Location = new System.Drawing.Point(87, 168);
            this.txtSatisEkleKisi.Name = "txtSatisEkleKisi";
            this.txtSatisEkleKisi.Size = new System.Drawing.Size(155, 22);
            this.txtSatisEkleKisi.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataKargolar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 772);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Urunler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tomato;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtGetir);
            this.groupBox3.Controls.Add(this.btnYenile);
            this.groupBox3.Controls.Add(this.btnGetir);
            this.groupBox3.Location = new System.Drawing.Point(18, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 269);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bul";
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(49, 151);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(157, 59);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 801);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataKisiler);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(946, 772);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kisiler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataKisiler
            // 
            this.dataKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKisiler.Location = new System.Drawing.Point(14, 8);
            this.dataKisiler.Name = "dataKisiler";
            this.dataKisiler.RowTemplate.Height = 24;
            this.dataKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKisiler.Size = new System.Drawing.Size(918, 463);
            this.dataKisiler.TabIndex = 11;
            this.dataKisiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKisiler_CellClick);
            this.dataKisiler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKisiler_CellDoubleClick);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Tomato;
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtKisiGetir);
            this.groupBox7.Controls.Add(this.btnKisiYenile);
            this.groupBox7.Controls.Add(this.btnKisiGetir);
            this.groupBox7.Location = new System.Drawing.Point(26, 489);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(234, 269);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Bul";
            // 
            // txtKisiGetir
            // 
            this.txtKisiGetir.Location = new System.Drawing.Point(56, 58);
            this.txtKisiGetir.Name = "txtKisiGetir";
            this.txtKisiGetir.Size = new System.Drawing.Size(157, 22);
            this.txtKisiGetir.TabIndex = 1;
            // 
            // btnKisiYenile
            // 
            this.btnKisiYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiYenile.Location = new System.Drawing.Point(56, 151);
            this.btnKisiYenile.Name = "btnKisiYenile";
            this.btnKisiYenile.Size = new System.Drawing.Size(157, 59);
            this.btnKisiYenile.TabIndex = 5;
            this.btnKisiYenile.Text = "Yenile";
            this.btnKisiYenile.UseVisualStyleBackColor = true;
            this.btnKisiYenile.Click += new System.EventHandler(this.btnKisiYenile_Click);
            // 
            // btnKisiGetir
            // 
            this.btnKisiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiGetir.Location = new System.Drawing.Point(56, 86);
            this.btnKisiGetir.Name = "btnKisiGetir";
            this.btnKisiGetir.Size = new System.Drawing.Size(157, 59);
            this.btnKisiGetir.TabIndex = 2;
            this.btnKisiGetir.Text = "Getir";
            this.btnKisiGetir.UseVisualStyleBackColor = true;
            this.btnKisiGetir.Click += new System.EventHandler(this.btnKisiGetir_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.txtKisiSifre);
            this.groupBox8.Controls.Add(this.btnKisiGuncelle);
            this.groupBox8.Controls.Add(this.txtKisiIsim);
            this.groupBox8.Controls.Add(this.txtKisiID);
            this.groupBox8.Location = new System.Drawing.Point(266, 489);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(329, 269);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kisi Güncelle";
            // 
            // txtKisiSifre
            // 
            this.txtKisiSifre.Location = new System.Drawing.Point(87, 130);
            this.txtKisiSifre.Name = "txtKisiSifre";
            this.txtKisiSifre.PasswordChar = '*';
            this.txtKisiSifre.Size = new System.Drawing.Size(155, 22);
            this.txtKisiSifre.TabIndex = 4;
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiGuncelle.Location = new System.Drawing.Point(87, 165);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(155, 42);
            this.btnKisiGuncelle.TabIndex = 3;
            this.btnKisiGuncelle.Text = "Güncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = true;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // txtKisiIsim
            // 
            this.txtKisiIsim.Location = new System.Drawing.Point(87, 95);
            this.txtKisiIsim.Name = "txtKisiIsim";
            this.txtKisiIsim.Size = new System.Drawing.Size(155, 22);
            this.txtKisiIsim.TabIndex = 1;
            // 
            // txtKisiID
            // 
            this.txtKisiID.Enabled = false;
            this.txtKisiID.Location = new System.Drawing.Point(87, 60);
            this.txtKisiID.Name = "txtKisiID";
            this.txtKisiID.Size = new System.Drawing.Size(155, 22);
            this.txtKisiID.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.btnKisiEkle);
            this.groupBox9.Controls.Add(this.txtKisiEkleSifre);
            this.groupBox9.Controls.Add(this.txtKisiEkleIsim);
            this.groupBox9.Location = new System.Drawing.Point(601, 489);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(329, 269);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Kişi Ekle";
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiEkle.Location = new System.Drawing.Point(87, 143);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(155, 42);
            this.btnKisiEkle.TabIndex = 3;
            this.btnKisiEkle.Text = "Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // txtKisiEkleSifre
            // 
            this.txtKisiEkleSifre.Location = new System.Drawing.Point(87, 113);
            this.txtKisiEkleSifre.Name = "txtKisiEkleSifre";
            this.txtKisiEkleSifre.PasswordChar = '*';
            this.txtKisiEkleSifre.Size = new System.Drawing.Size(155, 22);
            this.txtKisiEkleSifre.TabIndex = 1;
            // 
            // txtKisiEkleIsim
            // 
            this.txtKisiEkleIsim.Location = new System.Drawing.Point(87, 83);
            this.txtKisiEkleIsim.Name = "txtKisiEkleIsim";
            this.txtKisiEkleIsim.Size = new System.Drawing.Size(155, 22);
            this.txtKisiEkleIsim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barkod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürünler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürünler:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barkod:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kod:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(2, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kod:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "İsim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(59, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(46, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "İsim:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(40, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Şifre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(40, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "İsim:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(34, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Şifre:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Index:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(14, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Ürünler:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(38, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Alıcı:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(14, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Ürünler:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(38, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "Alıcı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 801);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKargolar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSatislar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKisiler)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKargolar;
        private System.Windows.Forms.TextBox txtGetir;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUpdateKod;
        private System.Windows.Forms.RichTextBox txUpdatetUrunler;
        private System.Windows.Forms.TextBox txtUpdateBarkod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox txtEkleUrunler;
        private System.Windows.Forms.TextBox txtEkleBarkod;
        private System.Windows.Forms.TextBox txtEkleKod;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSatisID;
        private System.Windows.Forms.Button btnSatisYenile;
        private System.Windows.Forms.Button btnSatisGetir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSatisGuncelle;
        private System.Windows.Forms.RichTextBox txtSatislarUrunler;
        private System.Windows.Forms.TextBox txtSatislarKisiID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSatisEkle;
        private System.Windows.Forms.RichTextBox txtSatisEkleKodlar;
        private System.Windows.Forms.TextBox txtSatisEkleKisi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtKisiGetir;
        private System.Windows.Forms.Button btnKisiYenile;
        private System.Windows.Forms.Button btnKisiGetir;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.TextBox txtKisiIsim;
        private System.Windows.Forms.TextBox txtKisiID;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.TextBox txtKisiEkleSifre;
        private System.Windows.Forms.TextBox txtKisiEkleIsim;
        private System.Windows.Forms.TextBox txtKisiSifre;
        private System.Windows.Forms.DataGridView dataKisiler;
        private System.Windows.Forms.DataGridView dataSatislar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

