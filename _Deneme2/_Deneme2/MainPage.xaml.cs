using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _Deneme2
{
	public partial class MainPage : ContentPage
	{
        TcpClient serverSocket;
        String name;
        double fiyat, arttirma, guncelFiyat;

        public MainPage(TcpClient serverSocket, String name)
		{
			InitializeComponent();
            this.serverSocket = serverSocket;
            this.name = name;

            
            sendText(serverSocket, name);
            Thread clThread = new Thread(doChat);
            clThread.Start();
		}


        private void doChat()
        {
            NetworkStream ns = serverSocket.GetStream();
            while (true)
            {
                writing(getText(serverSocket));
            }
        }

        private void sendText(TcpClient c, String text)
        {
            NetworkStream ns = c.GetStream();
            Byte[] outStream = System.Text.Encoding.ASCII.GetBytes(text + "$");
            ns.Write(outStream, 0, outStream.Length);
            ns.Flush();
        }

        private string getText(TcpClient c)
        {
            String dateFromServer = String.Empty;
            NetworkStream ns = c.GetStream();
            Byte[] inStream = new Byte[serverSocket.ReceiveBufferSize];
            ns.Read(inStream, 0, inStream.Length);
            dateFromServer = System.Text.Encoding.ASCII.GetString(inStream);
            dateFromServer = dateFromServer.Substring(0, dateFromServer.IndexOf("$"));
            return dateFromServer;
            //Device.BeginInvokeOnMainThread(() => { lbl2.Text = dateFromServer; });//Ogrenmek için yazdım burda bu koda ihtiyacım yok
        }

        private void setButtons(Boolean a)
        {
            btn1.IsEnabled = a;
            btn2.IsEnabled = a;
            btn3.IsEnabled = a;
            btn4.IsEnabled = a;
            btnFiyat.IsEnabled = a;
            txtFiyat.IsEnabled = a;
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            sendText(serverSocket, ((Button)(sender)).Text.ToString());
        }

       
        private void ContentPage_Disappearing(object sender, EventArgs e)
        {
            serverSocket.Close();   
        }

        private void setButtonsText(Double fiyat, Double artis)
        {
            btn1.Text = (fiyat + artis).ToString();
            btn2.Text = (fiyat + (artis * 2)).ToString();
            btn3.Text = (fiyat + (artis * 3)).ToString();
            btn4.Text = (fiyat + (artis * 4)).ToString();
        }

        private void writing(String text)
        {
            String durum = text.Substring(0, 2);
            text = text.Substring(2);
            switch (durum)
            {
                case "-1":
                    Device.BeginInvokeOnMainThread(() => { lblIndex.Text = "Index: "+text+"\nİsim: "+ this.name; setButtons(false); });
                    break;
                case "01":
                    Device.BeginInvokeOnMainThread(() => { lbl2.Text = "Bekleniyor"; setButtons(false); });
                    break;
                case "02":
                    char satir = '\n';
                    string[] urunler = text.Split(satir);
                    Device.BeginInvokeOnMainThread(() => {
                        lbl2.Text = "\nUrunler:\n";
                        foreach (String a in urunler)
                        {
                            lbl2.Text += (a + "\n");
                        }
                        setButtons(false);
                    });

                    guncelFiyat = arttirma = fiyat = 0;
                    break;

                case "03":

                    string baslangicText = text.Substring(text.IndexOf("|") + 1, (text.IndexOf("*") - text.IndexOf("|") - 1));//Bir matematik işlemi ile fiyatları almak için bir algoritma oluşturdum.
                    string artisText = text.Substring(text.IndexOf("*") + 1, (text.Length - text.IndexOf("*") - 1));
                    fiyat = Convert.ToDouble(baslangicText);
                    arttirma = Convert.ToDouble(artisText);
                    guncelFiyat = fiyat;

                    Device.BeginInvokeOnMainThread(() => {
                        lbl2.Text = "Satışta\n------------\n"+lbl2.Text;                     
                        lblBaslangi.Text = "Baslangıç: " + fiyat;
                        lblArtis.Text = "Artis Miktari: " + arttirma;
                        lblGuncel.Text = "Şuanki Fiyat: " + guncelFiyat;
                        setButtonsText(guncelFiyat, arttirma);
                        setButtons(true);
                    });
                    break;

                case "04":
                        string soldName = text.Substring(0,text.IndexOf("|"));
                        string soldPrice = text.Substring(text.IndexOf("|") + 1);
                         arttirma = fiyat = guncelFiyat = 0;
                    Device.BeginInvokeOnMainThread(() => {
                          setButtons(false);
                        DisplayAlert("Satıldı", "Urun " + soldName + " isimli kişiye\n" + soldPrice + " fiyat ile satılmıştır...", "Tamam");
                        lblBaslangi.Text = "Baslangıç: " + fiyat;
                        lblArtis.Text = "Artis Miktari: " + arttirma;
                        lblGuncel.Text = "Şuanki Fiyat: " + guncelFiyat;
                        setButtonsText(guncelFiyat, arttirma);
                        lblName.Text = String.Empty; ;
                    });

                    break;

                case "05":
                    arttirma = fiyat = guncelFiyat = 0;
                    Device.BeginInvokeOnMainThread(() => {
                        setButtons(false);
                        DisplayAlert("Satılmadıdı", "Urun Satılmadı...", "Tamam");
                        lblBaslangi.Text = "Baslangıç: " + fiyat;
                        lblArtis.Text = "Artis Miktari: " + arttirma;
                        lblGuncel.Text = "Şuanki Fiyat: " + guncelFiyat;
                        setButtonsText(guncelFiyat, arttirma);
                    });

                    break;
                case "06":
                    Device.BeginInvokeOnMainThread(() => {
                        DisplayAlert("Satın Alındı.", "Urunü "+text+ " Fiyatıyla Siz Satın Aldınız...", "Tamam");
                    });

                    break;
                default:
                    string name = text.Substring(0, text.IndexOf("|"));
                    string guncelText = text.Substring(text.IndexOf("|") + 1,text.IndexOf("*")-text.IndexOf("|")-1);
                    string artisText2 = text.Substring((text.IndexOf("*") + 1), (text.Length - text.IndexOf("*") - 1));
                    guncelFiyat = Convert.ToDouble(guncelText);
                    arttirma = Convert.ToDouble(artisText2);
                    
                    Device.BeginInvokeOnMainThread(() => {
                        lblName.Text = name;
                        lblGuncel.Text = "Şuanki Fiyat: " + guncelFiyat;
                    lblArtis.Text = "Artis Miktari: " + arttirma;
                    setButtonsText(guncelFiyat, arttirma);
                    });
                    break;

            }
            
        }

    }
}
