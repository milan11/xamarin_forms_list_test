using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            var items = new List<object>();

            for (int i = 0; i < 20; ++i)
            {
                items.Add(new object());
            }

            SomeList.ItemsSource = items;
        }
    }
}
