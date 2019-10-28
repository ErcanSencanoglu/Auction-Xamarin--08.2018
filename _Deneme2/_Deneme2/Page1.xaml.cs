using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _Deneme2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        private TcpClient serverSocket;
        private Thread cnnThread;


        public Page1()
        {
            InitializeComponent();
            serverSocket= new TcpClient();
            cnnThread = new Thread(connect);
            serverSocket.SendTimeout = 500; 
        }
        private void btnGir_Clicked(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 3)
            {
                cnnThread = new Thread(connect);
                cnnThread.Start();
               
            }
            else
            {
                lblHata.Text = "Hata...\nKullanıcı Adı Kısa...";
               // txtName.Focus();
            }
           
        }
        private void connect()
        {
            try
            {
                serverSocket.Connect("127.0.0.1", 8888);
                    Device.BeginInvokeOnMainThread(() => {
                        Navigation.PushModalAsync(new MainPage(serverSocket, txtName.Text));
                    });
            }
            catch (SocketException)
            {
                serverSocket = new TcpClient();
                Device.BeginInvokeOnMainThread(() => {
                    lblHata.Text = "Hata...\nBağlantı Sağlanamadı...\nServer Başlatılmamış Olablir....";
                });
            }
        }

        
    }
}