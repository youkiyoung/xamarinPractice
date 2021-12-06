using GridTutorial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GridTutorial.Views
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