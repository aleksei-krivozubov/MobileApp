using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {   
        public Menu()
        {
            InitializeComponent(); 
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            Detail.Title = "Вход";

            Detail.BindingContext = new UserViewModel();
        }

        public void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {   
            var item = e.SelectedItem as MenuMenuItem;
            if (item == null)
                return;


            var page = (Page)Activator.CreateInstance(item.TargetType);
            
            page.Title = (e.SelectedItem as MenuMenuItem).Title;
            Detail = page;
            DetailPage.Title = (e.SelectedItem as MenuMenuItem).Title;
            Detail.BindingContext = DetailPage.BindingContext;
            
            IsPresented = false;
           
            MasterPage.ListView.SelectedItem = null;   // Снятие выделение с элемента

        }

    }
}