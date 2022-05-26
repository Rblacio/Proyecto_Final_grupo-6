using Newtonsoft.Json;
using SOPORTECNICO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SOPORTECNICO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VHome : ContentPage
    {
        private const string Url = "http://172.17.208.129/REST/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<OrdenesTrabajo> _post;

        public VHome()
        {
            InitializeComponent();
        }
        private async void Listar_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<OrdenesTrabajo> posts = JsonConvert.DeserializeObject<List<OrdenesTrabajo>>(content);
            _post = new ObservableCollection<OrdenesTrabajo>(posts);

            ordenestrabajo.ItemsSource = _post;
        }
    }
}