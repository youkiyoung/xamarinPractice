using LabelTutorial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LabelTutorial.Views
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