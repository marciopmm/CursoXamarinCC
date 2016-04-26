using ConectCon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConectCon.Pages
{
	public partial class PostPage : ContentPage
	{
		public PostPage (Post post)
		{
			InitializeComponent ();
            BindingContext = post;

            btnConfig.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DBConfigPage());
            };
		}
	}
}
