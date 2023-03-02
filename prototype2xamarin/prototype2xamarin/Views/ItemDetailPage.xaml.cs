using prototype2xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace prototype2xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}