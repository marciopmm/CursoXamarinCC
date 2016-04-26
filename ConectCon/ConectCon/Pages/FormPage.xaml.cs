using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConectCon.Pages
{
	public partial class FormPage : ContentPage
	{
		public FormPage ()
		{
			InitializeComponent ();
            btnFechar.Clicked += async (sender, e) =>
            {
                await Navigation.PopModalAsync();
            };
		}

        
    }
}
