using prototype2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace prototype2.Views
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