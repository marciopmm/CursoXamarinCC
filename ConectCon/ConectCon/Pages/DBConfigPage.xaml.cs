using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConectCon.Pages
{
	public partial class DBConfigPage : ContentPage
	{
		public DBConfigPage ()
		{
			InitializeComponent ();
            btnTeste.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LolaBilolaPage());
            };
		}
	}
}
