using ConectCon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConectCon.Pages
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();

            List<MenuPageItem> itens = new List<MenuPageItem>();
            itens.Add(new MenuPageItem()
            {
                Title = "Mensagens",
                IconSource = "mensagem.png",
                TargetType = typeof(DBConfigPage)
            });

            itens.Add(new MenuPageItem()
            {
                Title = "Gestão Financeira",
                IconSource = "financeiro.png",
                TargetType = typeof(DBConfigPage)
            });

            itens.Add(new MenuPageItem()
            {
                Title = "Documentos",
                IconSource = "docs.png",
                TargetType = typeof(DBConfigPage)
            });

            itens.Add(new MenuPageItem()
            {
                Title = "Corpo Diretivo",
                IconSource = "diretivo.png",
                TargetType = typeof(DBConfigPage)
            });

            lstMenu.ItemsSource = itens;

            lstMenu.ItemSelected += LstMenu_ItemSelected;
        }

        private void LstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuPageItem;
            if (item != null)
            {
                var page = (MasterDetailCCPage)App.Current.MainPage;
                var menuPage = (MenuPage)page.Master;

                page.Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                menuPage.lstMenu.SelectedItem = null;
                page.IsPresented = false;
            }
        }
    }
}
