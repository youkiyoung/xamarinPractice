using ButtonTutorial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ButtonTutorial.Views
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