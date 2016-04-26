using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConectCon.Pages
{
	public partial class LolaBilolaPage : ContentPage
	{
		public LolaBilolaPage ()
		{
			InitializeComponent ();

            btnForm.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new FormPage());
            };
		}
    }
}
