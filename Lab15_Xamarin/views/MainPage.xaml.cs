using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lab15_Xamarin.models;
using Lab15_Xamarin.views;
using Newtonsoft.Json;

namespace Lab15_Xamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetPersonal();
        }

        private async void GetPersonal()
        {
            HttpClient client = new HttpClient();
            string url = "https://agenda21.000webhostapp.com/lista.php";
            var response = await client.GetStringAsync(url);
            var personal = JsonConvert.DeserializeObject<List<ProductModel>>(response);
            listOfPersonal.ItemsSource = personal;

        }
    }
}
