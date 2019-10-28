using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Server2
{
    public partial class Form1 : Form
    {

        private static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:/Users/Ercan/Documents/Visual Studio 2015/Projects/_Server2/WindowsFormsApplication1/bin/Debug/data1.accdb");
        private static OleDbCommand kmt = new OleDbCommand();
        private static OleDbDataAdapter dr;
        private static DataTable tablo = new DataTable();





        delegate void TextDegisDelegate(string textt);
        public static List<TcpClient> cList = new List<TcpClient>();
        TcpListener serverSocket = new TcpListener(8888);
        TcpClient clientSocket = default(TcpClient);
        public static HandleClient[] hList = new HandleClient[100];
        public static int kisi = 0;
        public static LinkLabel l1, l2, l3,l4;
        public static ListBox lst1;
        public static int second = 0;
        String durum = "01$";

        public static theBest best;

        public struct theBest
        {
           public double miktar;
            public double artis;
            public string name;
            public int index;
            public string[] kodlar;
        }

        public Form1()
        {
            InitializeComponent();
            l1 = linkLabel1;
            l2 = linkLabel2;
            l3 = linkLabel3;
            l4 = linkLabel4;
            lst1 = listBox1;
        }

        public string urunlerDuzenle(string urun)
        {
            char satir = '-';
            string[] urunler = urun.Split(satir);
            urun = "";
            foreach (string a in urunler)
            {
                urun += (a + "\n");
            }

            return urun;
        }

        public string urunleriBul(string[] kodlar)
        {
            tablo.Clear();
            baglanti.Open();
            string urunler = "";
            for (int i = 0; i < kodlar.Length; i++)
            {
                dr = new OleDbDataAdapter(kmt.CommandText = "Select * from Kargolar where '" + kodlar[i] + "'", baglanti);
                dr.Fill(tablo);
                urunler += urunlerDuzenle(tablo.Rows[i][2].ToString());
            }
            baglanti.Close();
            return urunler;
        }
        public void kazananKayit(string[] kodlar,string kisiID)
        {
            string kod = "";
            foreach (string a in kodlar)
            {
                kod += a + "-"; 
            }
            kod = kod.Substring(0, kod.Length - 1);
            kmt.Connection = baglanti;
            kmt.CommandText = "Insert into Satislar (Kodlar,KisiID) values ('"+kod+"','"+ kisiID + "')";
            try
            {
                baglanti.Open();
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnKodGirisi_Click(object sender, EventArgs e)
        {
            char satir = '\n';
            best.kodlar = richTextBox2.Text.Trim().Split(satir);
            richTextBox1.Text = urunleriBul(best.kodlar);
        }

        public void writing(string a)
        {
            if (listBox1.InvokeRequired)
            {
                TextDegisDelegate del = new TextDegisDelegate(writing);
                listBox1.Invoke(del, new object[] { a });
            }
            else
            {
                listBox1.Items.Add(a);
            }

        }

        public void writing2(Label l, string a)
        {
            if (l.InvokeRequired)
            {
                TextDegisDelegate del = new TextDegisDelegate(writing);
                l.Invoke(del, new object[] { a });
            }
            else
            {
                l.Text = a;
            }

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            best.miktar = 0;
            best.artis = 0;
            best.name = String.Empty;
            
            serverSocket = new TcpListener(8888);
            clientSocket = default(TcpClient);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverSocket.Start();
            label1.Text = "Server Started";
            button2.Enabled = true;
            btnKodGirisi.Enabled = true;
            Thread waitC = new Thread(waitForClients);
            waitC.Start();
            
        }


        public void waitForClients()
        {
            while (true)
            {
                clientSocket = serverSocket.AcceptTcpClient();
                cList.Add(clientSocket);
                String name = getName();
            
                //
                writing(kisi+"-"+name);
                sendName(clientSocket, durum);
                Thread.Sleep(20);
                sendName(clientSocket, ("-1" + kisi));
                HandleClient hc = new HandleClient();
                hList[kisi++] = hc;
                
                hc.startClient(clientSocket, name, (kisi-1));
            }
        }

        private String getName()
        {
            try
            {
                Byte[] bytesForm = new Byte[100024];
                String dataFromClient = String.Empty;
                NetworkStream ns = clientSocket.GetStream();
                ns.Read(bytesForm, 0, (int)clientSocket.ReceiveBufferSize);
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesForm);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                //
                return dataFromClient;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
                throw;
            }
           
        }

        private void sendName(TcpClient client, String text)
        {
            NetworkStream serverStream = client.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(best.name == "")
            {
                durum = "05";
                sendAll("");
                MessageBox.Show("Ürün satılmadı...");
            }
            else
            {
                kazananKayit(best.kodlar, best.name.Substring(best.name.IndexOf('-')+1));
                durum = "04";
                sendAll(best.name + "|" + best.miktar);
                MessageBox.Show("Ürün satıldı:" + best.miktar + "\n" + best.name);
                kazananBelirle(cList[best.index]);
            }
           
            //kayıt edilecek
            durum = "01";
            sendAll("");
            best.miktar = best.artis = 0;      
            best.name = string.Empty;
            l1.Text = l2.Text = l3.Text =  "0";
            l4.Text = "xxxx";
            label1.Text = "Yeni ürün bekleniyor";
            lblTime.Text = "000";
            richTextBox1.Text= richTextBox2.Text =textBox2.Text=textBox3.Text= String.Empty;
            button3.BeginInvoke((Action)delegate () { button3.Enabled = false; });
            button4.BeginInvoke((Action)delegate () { button4.Enabled = false; });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            writing2(lblTime, second.ToString());
            if (second == 0) button4_Click(button4,e);
        }

        private void kazananBelirle(TcpClient c)
        {
            Byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes("06" + best.miktar + "$");
            if (c != null && c.Connected)
            {
                NetworkStream ns2 = c.GetStream();
                ns2.Write(sendBytes, 0, sendBytes.Length);
                ns2.Flush();
            }

        }

     

        private void sendAll(String text)
        {
            Byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes(durum +text+"$");
            foreach (TcpClient a in Form1.cList)
            {
                if (a != null && a.Connected)
                {
                    NetworkStream ns2 = a.GetStream();
                    ns2.Write(sendBytes, 0, sendBytes.Length);
                    ns2.Flush();
                }
            }         
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            durum = "02" + richTextBox1.Text;
            sendAll("");
            writing2(label1, "Ürün için Fiyat Bilgileri Bekleniyor");
            button3.BeginInvoke((Action)delegate () { button3.Enabled = true; });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writing2(linkLabel1, textBox2.Text);
            writing2(linkLabel2, textBox3.Text);
            writing2(linkLabel3, textBox2.Text);
            writing2(label1, "Ürün Satışta");
            second = 100;
            timer1.Start(); 
            best.name = String.Empty;
            best.miktar = Convert.ToInt32(textBox2.Text);
            best.artis = Convert.ToInt32(textBox3.Text);
            durum = "03|" + textBox2.Text+"*"+textBox3.Text;
            sendAll("");
            button4.BeginInvoke((Action)delegate () { button4.Enabled = true; });
        }
    }




    public class HandleClient
    {
       

        TcpClient clientSocket;
        //
        string clNo = String.Empty;
        int index = -1;
        bool dongu = true;
        public void writeLabel()
        {
            Form1.l2.BeginInvoke((Action)delegate () { Form1.l2.Text = Form1.best.miktar.ToString(); });        
            Form1.l3.BeginInvoke((Action)delegate () { Form1.l3.Text = Form1.best.artis.ToString(); });
            Form1.l4.BeginInvoke((Action)delegate () { Form1.l4.Text = Form1.best.name.ToString(); });
        }
        public void startClient(TcpClient inClientSocket, String clNo, int indexNo)
        {
            this.clientSocket = inClientSocket;
            //
            this.clNo = clNo;
            this.index = indexNo;
            this.dongu = true;
            Thread clThread = new Thread(doChat);
            clThread.Start();
        }



        private double artisHesapla(double a,double b)
        {
            if (a >= 1500 && b < 100)
            {
                return 100;
            }
            else if (a >= 500 && b < 50)
            {
                return 50;
            }
            else if (a >= 250 && b < 20)
            {
                return 20;
            }
            else if (a >= 150 && b < 10)
            {
                return 10;
            }
            else if (a >= 15 && b < 5)
            {
                return 5;
            }
            return b;
        }

        private void doChat()
        {
            Byte[] bytesForm = new byte[100024];
            Byte[] sendBytes = null;
            String dataFromClient = String.Empty;
            string serverResponse = null;
            try
            {
                while (dongu)
                {
                    if (clientSocket.Connected)
                    {
                        NetworkStream ns = clientSocket.GetStream();
                        try
                        {
                            ns.Read(bytesForm, 0, (int)clientSocket.ReceiveBufferSize);
                            dataFromClient = System.Text.Encoding.ASCII.GetString(bytesForm);
                            dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        }
                        catch (System.IO.IOException)
                        {
                            clientSocket.Close();
                            Form1.cList[Form1.cList.IndexOf(clientSocket)] = null;
                            Form1.hList[index] = null;
                            Form1.lst1.BeginInvoke((Action)delegate () {
                                int a = Form1.lst1.Items.IndexOf(index + "-" + clNo);
                                Form1.lst1.Items.Remove(index +"-"+ clNo); Form1.lst1.Refresh(); });
                            dongu = true;
                            break;
                            
                        }
                        
                        //
                        Console.WriteLine(">> From Client- " + clNo + ":" + dataFromClient);

                        if (Convert.ToDouble(dataFromClient) > Form1.best.miktar && Form1.best.artis <= (Convert.ToDouble(dataFromClient) - Form1.best.artis))
                        {
                           
                            Form1.best.miktar = Convert.ToDouble(dataFromClient);
                            Form1.best.artis = artisHesapla(Form1.best.miktar,Form1.best.artis);
                            Form1.best.name = index + "-" + clNo;
                            Form1.best.index = index;
                            if(Form1.second < 5) { Form1.second = 5; }
                            writeLabel();
                            serverResponse = "99" +(index+"-"+clNo)+"|" +Form1.best.miktar + "*" + Form1.best.artis + "$";
                            sendBytes = Encoding.ASCII.GetBytes((serverResponse));
                            ns.Write(sendBytes, 0, sendBytes.Length);
                            ns.Flush();
                            foreach (TcpClient a in Form1.cList)
                            {
                                if (a != null && a.Connected)
                                {
                                    NetworkStream ns2 = a.GetStream();
                                    ns2.Write(sendBytes, 0, sendBytes.Length);
                                    ns2.Flush();
                                }                    
                            }
                            Console.WriteLine(">> " + serverResponse);
                        }
                    }
                      

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
   }

    }

