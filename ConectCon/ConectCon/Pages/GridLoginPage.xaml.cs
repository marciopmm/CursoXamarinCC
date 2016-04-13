using ConectCon.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConectCon.Pages
{
	public partial class GridLoginPage : ContentPage
	{
		public GridLoginPage ()
		{
			InitializeComponent ();

            btnLogin.Clicked += BtnLogin_Clicked;
		}

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            using (HttpClient http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/");

                var response = await http.GetAsync("posts/1");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    Post post = JsonConvert.DeserializeObject<Post>(content);
                    App.Current.MainPage = new PostPage(post);
                }
                else
                {
                    await DisplayAlert("O retorno é...", "PORRA NENHUMA", "OK");
                }
            }
        }
    }
}
