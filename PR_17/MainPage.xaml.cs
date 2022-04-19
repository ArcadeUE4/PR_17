using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Xamarin.Forms;

namespace PR_17
{
    public partial class MainPage : ContentPage
    {
        
        
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonPressed(object sender, EventArgs e)
        {
            if (entry.Text != "")
            {
                string url = "http://numbersapi.com";

                using (var webClient = new WebClient())
                {
                    var reponse = webClient.DownloadString(url + "/" + entry.Text);
                    label.Text = reponse;
                }

            }

        }

       
    }
}
