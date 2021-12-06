using StackLayoutTutorial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StackLayoutTutorial.Views
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