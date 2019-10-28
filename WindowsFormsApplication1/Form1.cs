using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=data1.accdb");   
        private static OleDbCommand kmt = new OleDbCommand();
        private static OleDbDataAdapter dr;
        private static DataTable tablo = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }

        public DataTable select(string sorgu)
        {

            tablo = new DataTable();
            dr = new OleDbDataAdapter(sorgu, baglanti);
            baglanti.Open();
            dr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void update(string sorgu)
        {
            kmt.Connection = baglanti;
            kmt.CommandText = sorgu;
            baglanti.Open();
            try
            {
                kmt.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
         
            baglanti.Close();
        }

       /* public void ekle(string sorgu)
        {
            kmt.Connection = baglanti;
            kmt.CommandText = sorgu;
            baglanti.Open();
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }*/

        public string urunlerDuzenle(string urun)
        {
            char satir = '-';
            string[] urunler = urun.Split(satir);
            urun = "";
            foreach (string a in urunler)
            {
                urun +=( a + "\n");
            }

            return urun;
        }

        public string urunleriGeriDuzenle(string urun)
        {
            char satir = '\n';
            string[] urunler = urun.Split(satir);
            urun = "";
            foreach (string a in urunler)
            {
                if(a.Trim() != "")
                urun += (a + "-");
            }

            return urun.Substring(0,urun.LastIndexOf('-'));
        }

        public void silButonuEkle(DataGridView d)
        {
            DataGridViewButtonColumn buton = new DataGridViewButtonColumn();
            buton.HeaderText = "Sil";
            buton.Text = "Sil";
            buton.Name = "btnSil";
            buton.UseColumnTextForButtonValue = true;
            d.Columns.Add(buton);
           

           
        }

        public void detayButonuEkle()
        {
            DataGridViewButtonColumn buton = new DataGridViewButtonColumn();
            buton.HeaderText = "Detay";
            buton.Text = "Detay";
            buton.Name = "btnDetay";
            buton.UseColumnTextForButtonValue = true;
            dataSatislar.Columns.Add(buton);
        }


        public Boolean controlSatis(string kisId,string urunlerList)
        {
            char satir = '\n';
            string[] urunler = urunlerDuzenle(urunlerList).Split(satir);
            for (int i = 0; i < urunler.Length - 1; i++)
            {
                DataTable tb = select("Select Urunler from Kargolar where Kod = '" + urunler[i] + "'");
                if (!(tb.Rows.Count > 0)) return false;

            }
            DataTable tb2 = select("Select ID from Kisiler where ID=" + int.Parse(kisId) + "");
            if (!(tb2.Rows.Count > 0)) return false;
            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataKargolar.DataSource = select("Select * From Kargolar");
            dataKisiler.DataSource = select("Select * From Kisiler");
            dataSatislar.DataSource = select("Select * From Satislar");

            silButonuEkle(dataKargolar);
            silButonuEkle(dataKisiler);
            silButonuEkle(dataSatislar);
            detayButonuEkle();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            dataKargolar.DataSource = select("Select * From Kargolar where Kod='"+txtGetir.Text+"'");
        }

      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateKod.Text = dataKargolar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUpdateBarkod.Text = dataKargolar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txUpdatetUrunler.Text =urunlerDuzenle(dataKargolar.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtUpdateBarkod.Text.Trim() != String.Empty && txtUpdateKod.Text.Trim() != String.Empty && txUpdatetUrunler.Text.Trim() != String.Empty)
            {
                string urun = urunleriGeriDuzenle(txUpdatetUrunler.Text);
                update("Update Kargolar set Kod='" + txtUpdateKod.Text + "', Barkod='" + txtUpdateBarkod.Text + "', Urunler='" + urun + "' where Kod='" + txtUpdateKod.Text + "'");
                txtUpdateKod.Text = txtUpdateBarkod.Text = txUpdatetUrunler.Text = String.Empty;
                dataKargolar.DataSource = select("Select * From Kargolar");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkleKod.Text.Trim() != String.Empty && txtEkleBarkod.Text.Trim() != String.Empty && txtEkleUrunler.Text.Trim() != String.Empty)
            {
                string urun = urunleriGeriDuzenle(txtEkleUrunler.Text);
                try
                {
                    update("Insert into Kargolar (Kod,Barkod,Urunler) values ('" + txtEkleKod.Text + "','" + txtEkleBarkod.Text + "','" + urun + "')");
                }
                catch (Exception)
                {

                    MessageBox.Show("Girilen kodu kontrol ediniz.", "Hata");
                }
                
                txtEkleKod.Text = txtEkleBarkod.Text = txtEkleUrunler.Text = String.Empty;
                dataKargolar.DataSource = select("Select * From Kargolar");
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataKargolar.DataSource = select("Select * From Kargolar");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                dataKargolar.DataSource = select("Select * From Kargolar");
            }else if (tabControl1.SelectedIndex == 1)
            {
                dataKisiler.DataSource =  select("Select * From Kisiler");
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                dataSatislar.DataSource = select("Select * From Satislar");
            }
        }

       

      

       

        private void btnKisiGetir_Click(object sender, EventArgs e)
        {
            dataKisiler.DataSource = select("Select * From Kisiler where Isim Like '%" + txtKisiGetir.Text + "%'");
        }

        private void btnKisiYenile_Click(object sender, EventArgs e)
        {
            dataKisiler.DataSource = select("Select * From Kisiler");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKisiID.Text = dataKargolar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKisiIsim.Text = dataKargolar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtKisiSifre.Text = dataKargolar.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            if(txtKisiIsim.Text.Trim() != String.Empty && txtKisiSifre.Text.Trim() != String.Empty)
            {
                update("Update Kisiler set Isim='" + txtKisiIsim.Text + "', Sifre='" + txtKisiSifre.Text + "' where ID='" + txtKisiID.Text + "'");
                txtKisiID.Text = txtKisiIsim.Text = txtKisiSifre.Text = String.Empty;
                dataKisiler.DataSource = select("Select * fron Kisiler");
            }
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            if (txtKisiEkleIsim.Text.Trim() != String.Empty && txtKisiEkleSifre.Text.Trim() != String.Empty)
            {
                update("Insert into kisiler (Isim,Sifre) values ('"+txtKisiEkleIsim.Text+"','"+txtKisiEkleSifre.Text+"')");
                txtKisiEkleIsim.Text = txtKisiEkleSifre.Text = String.Empty;
                dataKisiler.DataSource = select("Select * from Kisiler");
            }
        }

        private void dataKisiler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKisiID.Text = dataKisiler.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtKisiIsim.Text = dataKisiler.Rows[e.RowIndex].Cells["Isim"].Value.ToString();
            txtKisiSifre.Text = dataKisiler.Rows[e.RowIndex].Cells["Sifre"].Value.ToString();
        }

        private void dataSatislar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSatislarKisiID.Tag = dataSatislar.Rows[e.RowIndex].Cells["Index"].Value.ToString();
            txtSatislarKisiID.Text = dataSatislar.Rows[e.RowIndex].Cells["KisiID"].Value.ToString();
            txtSatislarUrunler.Text = urunlerDuzenle(dataSatislar.Rows[e.RowIndex].Cells["Kodlar"].Value.ToString());
        }

        private void btnSatisGetir_Click(object sender, EventArgs e)
        {
            dataSatislar.DataSource = select("Select * From Satislar where Index=" + txtSatisID.Text + "");
        }

        private void btnSatisYenile_Click(object sender, EventArgs e)
        {
            dataSatislar.DataSource = select("Select * From Satisar");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                if (txtSatislarKisiID.Text.Trim() != String.Empty && txtSatislarUrunler.Text.Trim() != String.Empty)
                {
                    if (controlSatis(txtSatislarKisiID.Text.Trim(),txtSatislarUrunler.Text.Trim()))
                    {
                        string urun = urunleriGeriDuzenle(txtSatislarUrunler.Text);
                        update("Update Satislar set Kodlar='"+urun+"', KisiID= '"+ txtSatislarKisiID.Text+"' where Index = "+txtSatislarKisiID.Tag+"");
                        txtSatislarKisiID.Text = txtUpdateBarkod.Text = txtSatislarUrunler.Text = String.Empty;
                        txtSatislarKisiID.Tag = null;
                        dataSatislar.DataSource = select("Select * From Satislar");
                    }
                    else
                    {
                        MessageBox.Show("Urun Kodlarını veya Kişi ID'sini Kontrol Ediniz...", "Hata");
                    }
            }
            
}

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            if (txtSatisEkleKodlar.Text.Trim() != String.Empty && txtSatisEkleKisi.Text.Trim() != String.Empty)
            {
                if (controlSatis(txtSatisEkleKisi.Text.Trim(),txtSatisEkleKodlar.Text.Trim()))
                {
                    string kodlar = urunlerDuzenle(txtSatisEkleKodlar.Text);
                    update("Insert Into Satislar (Kodlar,KisiID) values ('" + kodlar + "','" + txtSatisEkleKisi.Text + "')");
                    txtSatislarKisiID.Text = txtUpdateBarkod.Text = txtSatislarUrunler.Text = String.Empty;
                    dataSatislar.DataSource = select("Select * From Satislar");
                }
                else
                {
                    MessageBox.Show("Urun Kodlarını veya Kişi ID'sini Kontrol Ediniz...", "Hata");
                }

               
            }

        }

        private void dataKargolar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex!=-1 && dataKargolar.Columns[e.ColumnIndex].Name == "btnSil")
            {
                DialogResult dialogResult = MessageBox.Show("Kodlu Kargoyu Silmek İstediğinize Emin misiniz?", "sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string kod = dataKargolar.Rows[e.RowIndex].Cells[0].Value.ToString();
                    update("Delete from Kargolar where Kod = '"+kod+"'");
                    dataKargolar.DataSource = select("Select * From Kargolar");
                }
            }
        }

        private void dataKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && dataKisiler.Columns[e.ColumnIndex].Name == "btnSil")
            {
                DialogResult dialogResult = MessageBox.Show("ID'ye Sahip Kisiyi Silmek İstediğinize Emin misiniz?", "sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(dataKisiler.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    update("Delete from Kisiler where ID = " + id + "");
                    dataKisiler.DataSource = select("Select * From Kisiler");
                }
            }
        }

        private void dataSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && dataSatislar.Columns[e.ColumnIndex].Name == "btnSil")
            {
                DialogResult dialogResult = MessageBox.Show("Index'li Sahip Satışı Silmek İstediğinize Emin misiniz?", "sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int index = int.Parse(dataSatislar.Rows[e.RowIndex].Cells["Index"].Value.ToString());
                    update("Delete from Satislar where ID = " + index + "");
                    dataSatislar.DataSource = select("Select * From Satislar");
                }
            }
            else if (e.ColumnIndex != -1 && dataSatislar.Columns[e.ColumnIndex].Name == "btnDetay")
            {
                char satir = '\n';
                string urunler = "";
                string[] kodlar = urunlerDuzenle(dataSatislar.Rows[e.RowIndex].Cells["Kodlar"].Value.ToString()).Split(satir);
                
                string id = dataSatislar.Rows[e.RowIndex].Cells["KisiID"].Value.ToString();
                for (int i = 0; i < kodlar.Length-1; i++)
                {
                    DataTable tb = select("Select Urunler from Kargolar where Kod = '" + kodlar[i] + "' ");
                    urunler += "\n"+ kodlar[i]+"\n--------------------\n"+ urunlerDuzenle(tb.Rows[0][0].ToString());

                }

               
                DataTable tb2 = select("Select Isim from Kisiler where ID = " + id + "");
                string isim = tb2.Rows[0][0].ToString();
                MessageBox.Show("Ürünler:\n----------------\n" + urunler + "\nIsim: " + isim, "Detay");

            }
        }
    }
    }

